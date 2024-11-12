using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
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
using System.Xml.Linq;
using Angajati.Message_Box;
using Angajati.Login;

namespace Angajati
{
    /// <summary>
    /// Interaction logic for Forgot_Password.xaml
    /// </summary>
    public partial class Forgot_Password : Window
    {
        private string email;
        private TokenGenerator _tokenGenerator = new TokenGenerator();
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void textEmail_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.email = txtEmail.Text;
        }
        private void Button_Click_back(object sender, RoutedEventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Close();
        }
        private bool IsEmailInDatabase(string email)
        {
            using (var context = new CoffeeShopDataContext())
            {
                string trimmedEmail = email.Trim();

                var client = context.Clients
                                    .FirstOrDefault(c => c.Email == trimmedEmail);

                return client != null;
            }
        }


        private void Button_Click_generare_cod(object sender, RoutedEventArgs e)
        {
            if (IsEmailInDatabase(txtEmail.Text))
            {
                Message m = new Message();
                m.SetErrorMessage("Token trimis cu succes!");
                m.Show();
            TokenGenerator token= new TokenGenerator();
            string recipientEmail = txtEmail.Text;
            SendTokenByEmail(recipientEmail, token);
            }
            else
            {
                Error eroare = new Error();
                eroare.SetErrorMessage("Emailul nu se afla in baza de date a Cafenelei!");
                eroare.Show();
            }
        }

        private void SendTokenByEmail(string recipientEmail, TokenGenerator token)
        {
            string senderEmail = "scriptcafe757@gmail.com";
            string senderPassword = "lvkv xqfz yyya ulut";
            token.GenerateToken();
            string code = token.GetToken();
            MailMessage mail = new MailMessage();
            string body = $"Token-ul dumneavoastra de acces este: {code} si este valabil doar 5 minute!";
            mail.From = new MailAddress(senderEmail);
            mail.To.Add(recipientEmail);
            mail.Subject = "subject";
            mail.Body=body;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)  
            {
                Credentials = new NetworkCredential(senderEmail, senderPassword),
                EnableSsl = true, 
            };

            try
            {
                smtpClient.Send(mail);
                Console.WriteLine($"Email successfully sent to {recipientEmail}!");
                Resetare_Parola rp = new Resetare_Parola(token, email);
                this.Close();
                rp.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending email: {ex.Message}");
            }
        }
    }
    
}
