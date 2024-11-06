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
            return await Task.Run(() =>
            {
                using (var context = new CoffeeShopDataContext())
                {
                    string trimmedEmail = email.Trim();

                    var client = context.Clients
                        .FirstOrDefault(c => c.Email == trimmedEmail);

                    return client != null;
                }
            });
        }

        private async Task<bool> IsUsernameInDatabaseAsync(string username)
        {
            return await Task.Run(() =>
            {
                using (var context = new CoffeeShopDataContext())
                {
                    string trimmedUsername = username.Trim();

                    var client = context.Clients
                        .FirstOrDefault(c => c.Username == trimmedUsername);

                    return client != null;
                }
            });
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
            using (var context = new CoffeeShopDataContext())
            {
                string username = txtUsername.Text.Trim();
                string email = txtEmail.Text.Trim();
                var existingClientByEmail = context.Clients
                    .FirstOrDefault(c => c.Email == email);

                var existingClientByUsername = context.Clients
                    .FirstOrDefault(c => c.Username == username);

                if (existingClientByEmail != null && existingClientByUsername != null)
                {
                    Error error = new Error();
                    error.SetErrorMessage("Username si email deja utilizate! Vă rugăm să \nintroduceți un alt username si alt email.");
                    error.Show();
                    return;
                }

                if (existingClientByEmail != null)
                {
                    Error error = new Error();
                    error.SetErrorMessage("Email deja utilizat!\n Vă rugăm să introduceți un alt email.");
                    error.Show();
                    return;
                }

                if (existingClientByUsername != null)
                {
                    Error error = new Error();
                    error.SetErrorMessage("Username deja utilizat! Vă rugăm să introduceți un alt username.");
                    error.Show();
                    return;
                }
                var newClient = new Client
                {
                    Username = username,
                    Parola = PasswordHasher.HashPassword(txtPassword.Password),
                    Email = email,
                    Nume = txtNume.Text.Trim(),
                    Prenume = txtPrenume.Text.Trim(),
                    DataNastere = myDatePicker.SelectedDate.Value
                };
                context.Clients.InsertOnSubmit(newClient);
                context.SubmitChanges();
                Message mesaj = new Message();
                mesaj.SetErrorMessage("Contul a fost creat cu succes!");
                mesaj.Show();
                LoginPage lp = new LoginPage();
                this.Hide();
                lp.Show();
            }
        }

    }
}
