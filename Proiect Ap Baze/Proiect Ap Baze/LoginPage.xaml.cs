using System;
using System.Collections.Generic;
using System.Data;
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

namespace Proiect_Ap_Baze
{
   
    public partial class Window1 : Window
    {
        public Window1()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPassword.Password))
            {
                var clientTableAdapter = new CoffeeShopDataSetTableAdapters.ClientTableAdapter();
                var clientDataSet = new CoffeeShopDataSet();

                // Umplem DataTable-ul cu datele din tabel
                clientTableAdapter.Fill(clientDataSet.Client);

                // Găsim clientul care corespunde emailului
                var foundClient = clientDataSet.Client
                    .AsEnumerable()
                    .FirstOrDefault(row => row.Field<string>("Email") == txtEmail.Text);

                // Verificăm dacă clientul există
                if (foundClient != null)
                {
                    // Hash-uim parola introdusă de utilizator
                    string hashedPassword = PasswordHasher.HashPassword(txtPassword.Password);

                    // Verificăm parola
                    if (foundClient.Field<string>("Parola") == hashedPassword)
                    {
                        MessageBox.Show("Autentificat cu succes!");
                    }
                    else
                    {
                        MessageBox.Show("Parola incorectă!");
                    }
                }
                else
                {
                    MessageBox.Show("Email-ul nu există în baza de date!");
                }
            }
            else
            {
                MessageBox.Show("Te rog, completează toate câmpurile!");
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
    }
    
}
