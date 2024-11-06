using System;
using System.Collections.Generic;
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

namespace Angajati.Login
{
    /// <summary>
    /// Interaction logic for Schimbare_Parola.xaml
    /// </summary>
    public partial class Schimbare_Parola : Window
    {
        private string email;
        public Schimbare_Parola(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void Button_Click_Validare(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password == txtPassword1.Password)
            {
                using (var context = new CoffeeShopDataContext())
                {
                    var client = context.Clients
                        .FirstOrDefault(c => c.Email == this.email);

                    if (client != null)
                    {
                        string passwordHash = PasswordHasher.HashPassword(txtPassword.Password);
                        client.Parola = passwordHash;
                        context.SubmitChanges();
                        Message mesaj = new Message();
                        mesaj.SetErrorMessage("Parola a fost actualizată cu succes!");
                        mesaj.Show();
                    }
                    else
                    {
                        Error er = new Error();
                        er.SetErrorMessage("Nu există un utilizator cu acest email.");
                        er.Show();
                    }
                }
            }
            else
            {
                Error er = new Error();
                er.SetErrorMessage("Parolele nu se potrivesc.");
                er.Show();
            }
        }


        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            Forgot_Password fp = new Forgot_Password();
            fp.Show();
            this.Hide();
        }
    }
}
