using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Angajati.Message_Box;

namespace Angajati
{
    /// <summary>
    
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }


        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            //nu merge
            LoginPage login = new LoginPage();
            login.Show();
            this.Close();
        }

        private void txtNume_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textNume.Text) && txtNume.Text.Length > 0)
            {
                textNume.Visibility = Visibility.Collapsed;
            }
            else
            {
                textNume.Visibility = Visibility.Visible;
            }
        }

        private void txtPrenume_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textPrenume.Text) && txtPrenume.Text.Length > 0)
            {
                textPrenume.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPrenume.Visibility = Visibility.Visible;
            }
        }

        private async Task<bool> IsEmailInDatabaseAsync(string email)
        {
            using (var adapter = new Coffee_ShoppDataSetTableAdapters.ClientTableAdapter())
            {
                string trimmedEmail = email.Trim();

                Coffee_ShoppDataSet coffeeShopDataSet = new Coffee_ShoppDataSet();

               
                adapter.Fill(coffeeShopDataSet.Client);

                

                var client = coffeeShopDataSet.Client
                    .FirstOrDefault(c => c.Email == trimmedEmail);

               
                return client != null ? true : false; 
            }
        }
        private async Task<bool> IsUsernameInDatabaseAsync(string username)
        {
            using (var adapter = new Coffee_ShoppDataSetTableAdapters.ClientTableAdapter())
            {
                string trimmedUsername = username.Trim();

                Coffee_ShoppDataSet coffeeShopDataSet = new Coffee_ShoppDataSet();


                adapter.Fill(coffeeShopDataSet.Client);



                var client = coffeeShopDataSet.Client
                    .FirstOrDefault(c => c.Username == trimmedUsername);


                return client != null ? true : false;
            }
        }
        private async void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            string username = txtUsername.Text;

            if (!string.IsNullOrEmpty(username))
            {

                if (await IsUsernameInDatabaseAsync(username))
                {


                    textUsername.Text = "Username deja utilizat! Introduceți alt username!";
                    textUsername.Visibility = Visibility.Visible;

                }
                else
                {

                    textUsername.Visibility = Visibility.Collapsed;
                }
            }
            else
            {

                textUsername.Visibility = Visibility.Collapsed;
            }
        }

        private async void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            string email = txtEmail.Text;

            if (!string.IsNullOrEmpty(email))
            {
              
                if (await IsEmailInDatabaseAsync(email))
                {  

                    
                    textEmail.Text = "Email deja utilizat! Introduceți alt email!";
                    textEmail.Visibility = Visibility.Visible; 
                    
                }
                else
                {
                    
                    textEmail.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                
                textEmail.Visibility = Visibility.Collapsed; 
            }
        }
        private void myDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var adapter = new Coffee_ShoppDataSetTableAdapters.ClientTableAdapter())
            {

                if (textUsername.Visibility == Visibility.Visible && textEmail.Visibility == Visibility.Visible)
                {
                    Error error = new Error();
                    error.SetErrorMessage("Username si email deja utilizate! Vă rugăm să \nintroduceți un alt username si alt email.");
                    error.Show();
                    return;
                }
                if (textEmail.Visibility == Visibility.Visible)
                {
                    Error error = new Error();
                    error.SetErrorMessage("Email deja utilizat!\n Vă rugăm să introduceți un alt email.");
                    error.Show();
                    return;
                }
                if (textUsername.Visibility == Visibility.Visible)
                {
                    Error error = new Error();
                    error.SetErrorMessage("Username deja utilizat!\n Vă rugăm să introduceți un alt username.");
                    error.Show();
                    return;
                }

                Coffee_ShoppDataSet coffeeShopDataSet = new Coffee_ShoppDataSet();
                adapter.Fill(coffeeShopDataSet.Client);
                var newClientRow = coffeeShopDataSet.Client.NewClientRow();
                newClientRow.Username = txtUsername.Text;
                string passwordHash = PasswordHasher.HashPassword(txtPassword.Password);
                newClientRow.Parola = passwordHash;
                newClientRow.Email = txtEmail.Text.Trim();
                newClientRow.Nume = txtNume.Text.Trim();
                newClientRow.Prenume = txtPrenume.Text.Trim();
                newClientRow.DataNastere = myDatePicker.SelectedDate.Value;
                coffeeShopDataSet.Client.AddClientRow(newClientRow);
                // Salvează modificările în baza de date
                adapter.Update(coffeeShopDataSet.Client);

                LoginPage lp = new LoginPage();
                this.Hide();
                lp.Show();
            }
        }

    }
}
