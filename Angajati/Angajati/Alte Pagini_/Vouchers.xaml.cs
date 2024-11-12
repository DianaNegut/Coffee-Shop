using Angajati;
using Angajati.Ferestre_Angajati;
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
    /// Interaction logic for Vouchers.xaml
    /// </summary>
    public partial class Vouchers : Window
    {
        public static int activeVoucherValue;
        public static string activeVoucherCoffee;
        private string email;
        public Vouchers(string email)
        {
            this.email = email;
            InitializeComponent();

            var context = new CoffeeShopDataContext();
            var pctclient = context.Clients.Where(a => a.Email == this.email).Select(a => a.Puncte).FirstOrDefault();

            if(pctclient < 150 || pctclient == null)
            {
                NoVouchers.Visibility = Visibility.Visible;
            }
            else if(pctclient >= 150 && pctclient < 300)
            {
                Voucher1.Visibility = Visibility.Visible;
            }
            else if(pctclient >= 300 && pctclient < 500)
            {
                Voucher1.Visibility = Visibility.Visible;
                Voucher2.Visibility = Visibility.Visible;
            }
            else if(pctclient >= 500 && pctclient < 650)
            {
                Voucher1.Visibility = Visibility.Visible;
                Voucher2.Visibility = Visibility.Visible;
                Voucher3.Visibility = Visibility.Visible;
            }
            else if( pctclient >= 650 && pctclient < 900)
            {
                Voucher1.Visibility = Visibility.Visible;
                Voucher2.Visibility = Visibility.Visible;
                Voucher3.Visibility = Visibility.Visible;
                Voucher4.Visibility = Visibility.Visible;
            }
            else if (pctclient >= 900 && pctclient < 1000)
            {
                Voucher1.Visibility = Visibility.Visible;
                Voucher2.Visibility = Visibility.Visible;
                Voucher3.Visibility = Visibility.Visible;
                Voucher4.Visibility = Visibility.Visible;
                Voucher5.Visibility = Visibility.Visible;
            }
            else
            {
                Voucher1.Visibility = Visibility.Visible;
                Voucher2.Visibility = Visibility.Visible;
                Voucher3.Visibility = Visibility.Visible;
                Voucher4.Visibility = Visibility.Visible;
                Voucher5.Visibility = Visibility.Visible;
                Voucher6.Visibility = Visibility.Visible;
            }

        }
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Application.Current.Shutdown();
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainPage mp = new MainPage(this.email);
            mp.Show();
            this.Hide();
        }

        private void OrderBtn_Click(object sender, RoutedEventArgs e)
        {
            Order ord = new Order(this.email);
            ord.Show();
            this.Hide();
        }

        private void ShoppingBtn_Click(object sender, RoutedEventArgs e)
        {
            ShoppingCart sc = new ShoppingCart(this.email);
            sc.Show();
            this.Hide();
        }

        private void ContactBtn_Click(object sender, RoutedEventArgs e)
        {
            AboutUs au = new AboutUs(this.email);
            au.Show();
            this.Hide();
        }

        private void ReservationBtn_Click(object sender, RoutedEventArgs e)
        {
            Reservation res = new Reservation(this.email);
            res.Show();
            this.Hide();
        }



        private void Voucher1_Click(object sender, RoutedEventArgs e)
        {
            activeVoucherCoffee = "Cappuccino";
            activeVoucherValue = 15;
            Voucher1.Visibility = Visibility.Collapsed;

            var context = new CoffeeShopDataContext();
            context.ScadePuncte(150, this.email);
            context.SubmitChanges();

            Message m = new Message();
            m.SetErrorMessage("Voucher activat! Reducerea va fi aplicata la prima comanda online efectuata!");
            m.Show();
        }

        private void Voucher2_Click(object sender, RoutedEventArgs e)
        {
            activeVoucherCoffee = "Espresso";
            activeVoucherValue = 15;
            Voucher2.Visibility = Visibility.Collapsed;

            var context = new CoffeeShopDataContext();
            context.ScadePuncte(300, this.email);
            context.SubmitChanges();

            Message m = new Message();
            m.SetErrorMessage("Voucher activat! Reducerea va fi aplicata la prima comanda online efectuata!");
            m.Show();
        }

        private void Voucher3_Click(object sender, RoutedEventArgs e)
        {
            activeVoucherCoffee = "Latte";
            activeVoucherValue = 15;
            Voucher3.Visibility = Visibility.Collapsed;

            var context = new CoffeeShopDataContext();
            context.ScadePuncte(500, this.email);
            context.SubmitChanges();

            Message m = new Message();
            m.SetErrorMessage("Voucher activat! Reducerea va fi aplicata la prima comanda online efectuata!");
            m.Show();
        }

        private void Voucher4_Click(object sender, RoutedEventArgs e)
        {
            activeVoucherCoffee = "Cappuccino";
            activeVoucherValue = 30;
            Voucher4.Visibility = Visibility.Collapsed;

            var context = new CoffeeShopDataContext();
            context.ScadePuncte(650, this.email);
            context.SubmitChanges();

            Message m = new Message();
            m.SetErrorMessage("Voucher activat! Reducerea va fi aplicata la prima comanda online efectuata!");
            m.Show();
        }

        private void Voucher5_Click(object sender, RoutedEventArgs e)
        {
            activeVoucherCoffee = "Espresso";
            activeVoucherValue = 30;
            Voucher5.Visibility = Visibility.Collapsed;

            var context = new CoffeeShopDataContext();
            context.ScadePuncte(900, this.email);
            context.SubmitChanges();

            Message m = new Message();
            m.SetErrorMessage("Voucher activat! Reducerea va fi aplicata la prima comanda online efectuata!");
            m.Show();
        }

        private void Voucher6_Click(object sender, RoutedEventArgs e)
        {
            activeVoucherCoffee = "Latte";
            activeVoucherValue = 30;
            Voucher6.Visibility = Visibility.Collapsed;

            var context = new CoffeeShopDataContext();
            context.ScadePuncte(1000, this.email);
            context.SubmitChanges();

            Message m = new Message();
            m.SetErrorMessage("Voucher activat! Reducerea va fi aplicata la prima comanda online efectuata!");
            m.Show();
        }

        private void AccountBtn_Click(object sender, RoutedEventArgs e)
        {
            MyAccount ma = new MyAccount(this.email);
            ma.Show();
            this.Close();
        }
    }
}
