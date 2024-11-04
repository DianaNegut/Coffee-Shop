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
    /// Interaction logic for Resetare_Parola.xaml
    /// </summary>
    public partial class Resetare_Parola : Window
    {
        private string email;
        private TokenGenerator token;
        public Resetare_Parola(TokenGenerator token, string email)
        {
            this.token = token;
            this.email = email;
            InitializeComponent();
        }

        private void Button_Click_back(object sender, RoutedEventArgs e)
        {
            Forgot_Password fp = new Forgot_Password();
            this.Close();
            fp.Show();
        }

        private void Button_Click_Validare(object sender, RoutedEventArgs e)
        {
            if (this.token.IsTokenValid() && txtToken.Text==this.token.GetToken())
            {
                //e valid
                Schimbare_Parola sp = new Schimbare_Parola(this.email);
                this.Close();
                sp.Show();


            }
            else
            {
                //token invalid
                //generare eroare
                Error err = new Error();
                err.SetErrorMessage("Token-ul este invalid!");
                err.Show();
                Forgot_Password fp = new Forgot_Password();
                this.Hide();
                fp.Show();
                
            }
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
