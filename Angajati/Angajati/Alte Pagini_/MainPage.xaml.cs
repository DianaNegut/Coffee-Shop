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
using Angajati;

namespace Angajati
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        private string email;
        public MainPage(string email)
        {
            this.email = email;
            InitializeComponent();
        }
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Application.Current.Shutdown();
        }
        private void OrderBtn_Click(object sender, RoutedEventArgs e)
        {
            Order ord = new Order(this.email);
            ord.Show();
            this.Hide();
            
        }

        private void ReservationBtn_Click(object sender, RoutedEventArgs e)
        {
            Reservation res = new Reservation(this.email);
            res.Show();
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

        private void VouchersBtn_Click(object sender, RoutedEventArgs e)
        {
            Vouchers v = new Vouchers(this.email);
            v.Show();
            this.Hide();
        }

        private void AccountBtn_Click(object sender, RoutedEventArgs e)
        {
            MyAccount ma = new MyAccount(this.email);
            ma.Show();
            this.Close();
        }
    }
}
