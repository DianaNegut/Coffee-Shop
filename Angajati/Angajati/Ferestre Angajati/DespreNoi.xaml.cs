﻿using System;
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
using Angajati.Message_Box;

namespace Angajati.Ferestre_Angajati
{
    /// <summary>
    /// Interaction logic for DespreNoi.xaml
    /// </summary>
    public partial class DespreNoi : Window
    {
        private string email;
        public DespreNoi(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void user_Click(object sender, RoutedEventArgs e)
        {
            profilAngajat pa = new profilAngajat(this.email);
            this.Hide();
            pa.Show();

        }

        private void aboutus_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            DespreNoi dn = new DespreNoi(this.email);
            dn.Show();
        }

        private void comenzi_Click(object sender, RoutedEventArgs e)
        {
            Orders c = new Orders(this.email);
            this.Hide();
            c.Show();
        }

        private void reservation_Click(object sender, RoutedEventArgs e)
        {
            Rezervari r = new Rezervari(this.email);
            r.Show();
            this.Hide();
        }
       

        private void home_Click(object sender, RoutedEventArgs e)
        {
            firstMenu fp = new firstMenu(this.email);
            fp.Show();
            this.Hide();
        }

        private void Button_Feedback_Click(object sender, RoutedEventArgs e)
        {

            string senderEmail = "scriptcafe757@gmail.com";
            string senderPassword = "lvkv xqfz yyya ulut";
            MailMessage mail = new MailMessage();
            string body = txtMesaj.Text;
            body += txtEmailAngajat.Text;
            mail.From = new MailAddress(senderEmail);
            string recipientEmail = "scriptcafe757@gmail.com";
            //trimite la admin
            mail.To.Add(recipientEmail);
            mail.Subject = "Review";
            mail.Body = body;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(senderEmail, senderPassword),
                EnableSsl = true,
            };

            try
            {
                smtpClient.Send(mail);
                Message m = new Message();
                m.SetErrorMessage("Emailul a fost trimis cu succes!");
                m.Show();
            }
            catch (Exception ex)
            {
                Error error = new Error();
                error.SetErrorMessage("Eroare la trimiterea emailului!");
                error.Show();
                
            }

        }

        
    }
}
