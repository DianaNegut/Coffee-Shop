using Angajati;
using Angajati.Message_Box;
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

namespace Angajati
{
    /// <summary>
    /// Interaction logic for MyAccount.xaml
    /// </summary>
    public partial class MyAccount : Window
    {
        private string email;
        public MyAccount(string email)
        {
            this.email = email;
            InitializeComponent();
            PopulareFereastra();
        }
        private void PopulareFereastra()
        {
            try
            {
                using (var context = new CoffeeShopDataContext())
                {
                    Email.Text = this.email;

                    var puncte = context.Clients
                                     .Where(a => a.Email == this.email)
                                     .Select(a => a.Puncte)
                                     .FirstOrDefault();

                    Puncte.Text = puncte.ToString() ?? "N/A";

                    var client = context.Clients
                                         .Where(a => a.Email == this.email)
                                         .FirstOrDefault();

                    string Nume = client?.Nume ?? "N/A";
                    string Prenume = client?.Prenume ?? "N/A";

                    string tot = Nume + " " + Prenume;
                    this.Nume_Prenume.Text = tot;
                }
            }
            catch (Exception ex)
            {
                Error er = new Error();
                er.SetErrorMessage($"A apărut o eroare: {ex.Message}");
            }
        }


        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void OrderBtn_Click(object sender, RoutedEventArgs e)
        {
            Order ord = new Order(this.email);
            ord.Show();
            this.Close();

        }

        private void ReservationBtn_Click(object sender, RoutedEventArgs e)
        {
            Reservation res = new Reservation(this.email);
            res.Show();
            this.Close();
        }

        private void ShoppingBtn_Click(object sender, RoutedEventArgs e)
        {
            ShoppingCart sc = new ShoppingCart(this.email);
            sc.Show();
            this.Close();
        }

        private void ContactBtn_Click(object sender, RoutedEventArgs e)
        {
            AboutUs au = new AboutUs(this.email);
            au.Show();
            this.Close();
        }

        private void VouchersBtn_Click(object sender, RoutedEventArgs e)
        {
            Vouchers v = new Vouchers(this.email);
            v.Show();
            this.Close();
        }

        private void HomeBtn_Click(Object sender, RoutedEventArgs e)
        {
            MainPage mp = new MainPage(this.email);
            mp.Show();
            this.Close();
        }
    }
}

