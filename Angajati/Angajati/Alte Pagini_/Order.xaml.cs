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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Angajati;
using Angajati.Message_Box;

namespace Angajati
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        private string email;
        public Order(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainPage mp = new MainPage(this.email);
            mp.Show();
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
            this.Close();
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

        //Butoane comenzi

        public static string coffee_type = null;

        private void EspressoBtn_Click(object sender, RoutedEventArgs e)
        {
            if (OrderOptions.verificareStoc("shot espresso") >= 1)
            {
                ShoppingCartManager.SelectedProducts.Add("Espresso");
                ShoppingCartManager.SelectedProductsPrices.Add(7);

                Message m = new Message();
                m.SetErrorMessage("Espresso-ul a fost adaugat la comanda");
                m.Show();

                OrderOptions.modificareStoc("shot espresso", 1);
            }
            else
            {
                Error m = new Error();
                m.SetErrorMessage("Din pacate acest produs nu mai este in stoc. Va rugam alegeti altceva!");
                m.Show();
                
            }
        }

        private void CappuccinoBtn_Click(object sender, RoutedEventArgs e)
        {
            coffee_type = "cappuccino";
            OrderOptions personalizare = new OrderOptions(this.email);
            personalizare.ShowDialog();
            if (OrderOptions.coffee_details != null && OrderOptions.success == true)
            {
                string produs;
                if (OrderOptions.coffee_details.Substring(OrderOptions.coffee_details.Length - 2) == "Da")
                    produs = "Cappuccino cu" + OrderOptions.coffee_details.Substring(0, OrderOptions.coffee_details.Length - 2) + "frisca";
                else
                    produs = "Cappuccino cu" + OrderOptions.coffee_details.Substring(0, OrderOptions.coffee_details.Length - 2);

                ShoppingCartManager.SelectedProducts.Add(produs);
                decimal? pret = OrderOptions.coffee_price;
                pret += 7;
                ShoppingCartManager.SelectedProductsPrices.Add(pret);
            }

        }

        private void LatteBtn_Click(object sender, RoutedEventArgs e)
        {
            coffee_type = "latte";
            OrderOptions personalizare = new OrderOptions(this.email);
            personalizare.ShowDialog();
            if (OrderOptions.coffee_details != null && OrderOptions.success == true)
            {
                string produs;
                if (OrderOptions.coffee_details.Substring(OrderOptions.coffee_details.Length - 2) == "Da")
                    produs = "Latte cu" + OrderOptions.coffee_details.Substring(0, OrderOptions.coffee_details.Length - 2) + "frisca";
                else
                    produs = "Latte cu" + OrderOptions.coffee_details.Substring(0, OrderOptions.coffee_details.Length - 2);

                ShoppingCartManager.SelectedProducts.Add(produs);
                decimal? pret = OrderOptions.coffee_price;
                pret += 7;
                ShoppingCartManager.SelectedProductsPrices.Add(pret);
            }

        }

        private void IcedBtn_Click(object sender, RoutedEventArgs e)
        {
            coffee_type = "iced";
            OrderOptions personalizare = new OrderOptions(this.email);
            personalizare.ShowDialog();
            if (OrderOptions.coffee_details != null && OrderOptions.success == true)
            {
                string produs;
                if (OrderOptions.coffee_details.Substring(OrderOptions.coffee_details.Length - 2) == "Da")
                    produs = "IcedCoffee cu" + OrderOptions.coffee_details.Substring(0, OrderOptions.coffee_details.Length - 2) + "frisca";
                else
                    produs = "IcedCoffee cu" + OrderOptions.coffee_details.Substring(0, OrderOptions.coffee_details.Length - 2);

                ShoppingCartManager.SelectedProducts.Add(produs);
                decimal? pret = OrderOptions.coffee_price;
                pret += 7;
                Console.WriteLine(pret);
                ShoppingCartManager.SelectedProductsPrices.Add(pret);
            }
        }

        private void FrappeBtn_Click(object sender, RoutedEventArgs e)
        {
            coffee_type = "frappe";
            OrderOptions personalizare = new OrderOptions(this.email);
            personalizare.ShowDialog();
            if (OrderOptions.coffee_details != null && OrderOptions.success == true)
            {
                string produs;
                if (OrderOptions.coffee_details.Substring(OrderOptions.coffee_details.Length - 2) == "Da")
                    produs = "Frappe cu" + OrderOptions.coffee_details.Substring(0, OrderOptions.coffee_details.Length - 2) + "frisca";
                else
                    produs = "Frappe cu" + OrderOptions.coffee_details.Substring(0, OrderOptions.coffee_details.Length - 2);

                ShoppingCartManager.SelectedProducts.Add(produs);
                decimal? pret = OrderOptions.coffee_price;
                pret += 7;
                ShoppingCartManager.SelectedProductsPrices.Add(pret);
            }
        }
    }
}
