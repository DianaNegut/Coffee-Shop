using Angajati.Login;
using Angajati.Message_Box;
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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections.Specialized;
using Angajati;

namespace Angajati
{
    /// <summary>
    /// Interaction logic for SendNotifAdmin.xaml
    /// </summary>
    public partial class SendNotifAdmin : Window
    {
        private string email;
        public SendNotifAdmin(string email)
        {
            this.email = email;
            InitializeComponent();

            using (var context = new CoffeeShopDataContext())
            {
                var usernameList = context.Clients.Select(user => user.Username).ToList();
                UsersList.ItemsSource = usernameList;
            }

        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Application.Current.Shutdown();
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            HomeAdmin ha = new HomeAdmin(email);
            ha.Show();
            this.Close();
        }

        private void AddAccountBtn_Click(object sender, RoutedEventArgs e)
        {
            AddAccountAdmin a = new AddAccountAdmin(email);
            a.Show();
            this.Close();
        }

        private void OffersBtn_Click(object sender, RoutedEventArgs e)
        {
            SendNotifAdmin sn = new SendNotifAdmin(email);
            sn.Show();
            this.Close();
        }

        private void SelectAllBtn_Click(object sender, RoutedEventArgs e)
        {
            UsersList.SelectAll();
        }

            private void StocBtn_Click(object sender, RoutedEventArgs e)
            {
                StocAdmin ha = new StocAdmin(email);
                ha.Show();
                this.Close();
            }

        private bool IsEmailInDatabase(string email)
        {
            using (var context = new CoffeeShopDataContext())
            {
                string trimmedEmail = email.Trim();

                var client = context.Clients.FirstOrDefault(c => c.Email == trimmedEmail);

                return client != null;
            }
        }

        private void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            var context = new CoffeeShopDataContext();
            var selected = UsersList.SelectedItems;
            foreach (string username in selected)
            {
                var client = context.Clients.SingleOrDefault(p => p.Username == username);
                if (IsEmailInDatabase(client.Email))
                {
                    Message m = new Message();
                    m.SetErrorMessage("Token trimis cu succes!");
                    m.Show();
                    TokenGenerator token = new TokenGenerator();
                    string recipientEmail = client.Email;
                    SendTokenByEmail(recipientEmail, token);
                }
                else
                {
                    Error eroare = new Error();
                    eroare.SetErrorMessage("Emailul nu se afla in baza de date a Cafenelei!");
                    eroare.Show();
                }
            }
        }


        private string FavoriteCoffee(string email)
        {
            var context = new CoffeeShopDataContext();
            var client = context.Clients.SingleOrDefault(p => p.Email == email);
            //var cafea  = context.GetMostOrderedCoffeeByClient(client.IDClient).FirstOrDefault();

            //  return cafea.Denumire;
            return "";
        }

        private void SendTokenByEmail(string recipientEmail, TokenGenerator token)
        {
            string senderEmail = "scriptcafe757@gmail.com";
            string senderPassword = "lvkv xqfz yyya ulut";
            string coffee = FavoriteCoffee(recipientEmail);
            MailMessage mail = new MailMessage();
            string body = $"Pana maine aveti 30% reducere la cafeaua dumneavoastra preferata: {coffee}. Puteti sa o personalizati in orice mod. Va asteptam!";
            mail.From = new MailAddress(senderEmail);
            mail.To.Add(recipientEmail);
            mail.Subject = "subject";
            mail.Body = body;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(senderEmail, senderPassword),
                EnableSsl = true,
            };

            try
            {
                smtpClient.Send(mail);
                Console.WriteLine($"Email successfully sent to {recipientEmail}!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending email: {ex.Message}");
            }
        }
    }
}
