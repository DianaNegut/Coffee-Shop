using Angajati;
using Angajati.Login;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Angajati.Plata;

namespace Angajati
{
   
    public partial class LoginPage : Window
    {
        
        public LoginPage()
        {
            InitializeComponent();
        }

        private void textEmail_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtEmail.Focus();
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        { 
            //aici de facut regex email
            if (!string.IsNullOrEmpty(textEmail.Text) && txtEmail.Text.Length > 0)
            {
                textEmail.Visibility = Visibility.Collapsed;
            }
            else
            {
                textEmail.Visibility = Visibility.Visible;
            }
        }

        private void ShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            txtPassword.Visibility = Visibility.Collapsed;
            txtPasswordVisible.Visibility = Visibility.Visible;
            txtPasswordVisible.Text = txtPassword.Password;
        }

        private void ShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            txtPasswordVisible.Visibility = Visibility.Collapsed;
            txtPassword.Visibility = Visibility.Visible;
            txtPassword.Password = txtPasswordVisible.Text;
        }


        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Password) && txtPassword.Password.Length > 0)
            {
                txtPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                txtPassword.Visibility = Visibility.Visible;
            }
        }
        
        private void Button_Parola_uitata(object sender, RoutedEventArgs e)
        {
            Forgot_Password fp = new Forgot_Password();
            fp.Show();
            this.Close();


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Password;
            string passwordHash = PasswordHasher.HashPassword(password);

            using (var context = new CoffeeShopDataContext())
            {
                var clientUser = context.Clients
                    .FirstOrDefault(c => c.Email == email && c.Parola == passwordHash);
                var employeeUser = context.Angajats
                    .FirstOrDefault(a => a.Email == email && a.Parola == passwordHash);

                if (clientUser != null)
                {
                    // Aici pagina clientului
                    //ClientiPage clientiPage = new ClientiPage(txtEmail.Text);
                    //clientiPage.Show();
                    HomeAdmin mp = new HomeAdmin(txtEmail.Text);
                    mp.Show();
                    this.Close();
                }
                else if (employeeUser != null)
                {
                    firstMenu firstPageMenu = new firstMenu(txtEmail.Text);
                    firstPageMenu.Show();
                    this.Close();
                }
                else
                {
                    Error error = new Error();
                    error.SetErrorMessage("Emailul sau parola sunt incorecte!");
                    error.Show();
                }
            }
        }



        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Facebook(object sender, RoutedEventArgs e)
        {

            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/dianamihaela.negut/",
                UseShellExecute = true 
            });

        }

        private void Button_Click_Instagram(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/negut.diana/",
                UseShellExecute = true 
            });

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Close();
            
            
            
        }

        
    }
    
}
