using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
using Angajati.Message_Box;
using Angajati.Plata;

namespace Angajati
{
    /// <summary>
    /// Interaction logic for ShoppingCart.xaml
    /// </summary>
    public partial class ShoppingCart : Window
    {
        private string email;
        public ShoppingCart(string email)
        {
            this.email = email;
            InitializeComponent();
            if (ShoppingCartManager.SelectedProducts.Count > 0)
            {
                TotalTag.Visibility = Visibility.Visible;
                decimal? total = 0.0m;
                var product = ShoppingCartManager.SelectedProducts[0];
                var price = ShoppingCartManager.SelectedProductsPrices[0];
                for (int i = 0; i < ShoppingCartManager.SelectedProducts.Count; i++)
                {
                    product = ShoppingCartManager.SelectedProducts[i];
                    price = ShoppingCartManager.SelectedProductsPrices[i];

                    productsListBox.Items.Add(product);
                    string coffeeName = product.Split(' ')[0];


                    if (coffeeName == Vouchers.activeVoucherCoffee)
                    {
                        decimal? disc = (Vouchers.activeVoucherValue / 100m) * price;
                        price = price - disc;
                    }
                    productsPricesListBox.Items.Add(price);
                    total += price;
                }


                TotalVal.Text = total.ToString() + "RON";
            }

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

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainPage mp = new MainPage(this.email);
            mp.Show();
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

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Application.Current.Shutdown();
        }
        private void AccountBtn_Click(object sender, RoutedEventArgs e)
        {
            MyAccount ma = new MyAccount(this.email);
            ma.Show();
            this.Close();
        }

        private void PlaceOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            var context = new CoffeeShopDataContext();
 //           int i = 0;
            if (ShoppingCartManager.SelectedProducts.Count == 0)
            {
                Error me = new Error();
                me.SetErrorMessage("Nu aveți niciun produs în coș.");
                me.Show();

                return;
            }

            if (cash.IsChecked == false && card.IsChecked == false)
            {
                Error me = new Error();
                me.SetErrorMessage("Vă rugăm selectați o metodă de plată pentru a putea plasa comanda!");
                me.Show();

                return;
            }

            int plata;
            if (cash.IsChecked == true)
                plata = 0; //cash
            else
                plata = 1; //card

            var selectedProductsCopy = ShoppingCartManager.SelectedProducts.ToList();
            int i = 0;

            foreach (string item in selectedProductsCopy)
            {
                string[] produs = item.Split(' ');
                string den = produs[0];
                string lapte, sirop = null, frisca;
                int fris, espshots;

                if (den != "Espresso")
                {
                    lapte = produs[2] + ' ' + produs[3] + ' ' + produs[4];

                    if (den == "IcedCoffee" || den == "Frappe")
                        espshots = 2;
                    else
                        espshots = 1;

                    if (item.Contains("sirop"))
                    {
                        sirop = produs[5] + " " + produs[6];
                        frisca = produs[7];
                        if (produs.Length > 8)
                        {
                            sirop += " " + produs[7];
                            frisca = produs[8];
                        }
                    }
                    else
                    {
                        frisca = produs[5];
                    }

                    fris = 0;
                    if (frisca == "frisca")
                        fris = 1;
                }
                else
                {
                    lapte = null;
                    sirop = null;
                    fris = 0;
                    espshots = 1;
                }

                decimal? pr = 0.00m;
                if (ShoppingCartManager.SelectedProductsPrices[i] != null)
                    pr += ShoppingCartManager.SelectedProductsPrices[i];

                // Procesare plată cu card
                if (plata == 1)
                {
                    Plati p = new Plati((float)pr, den, espshots, fris, sirop, lapte, email);
                    p.Show();
                    // this.Close(); // Dacă este necesar
                }
                else
                {
                    var cafea = new Cafele
                    {
                        Denumire = den,
                        ShoturiEspresso = espshots,
                        TipLapte = lapte,
                        Sirop = sirop,
                        Frisca = fris,
                        Pret = (int)pr
                    };

                    context.Cafeles.InsertOnSubmit(cafea);
                    context.SubmitChanges();

                    DateTime data = DateTime.Today;
                    int pret = (int)pr;

                    var client = context.Clients.SingleOrDefault(p => p.Email == this.email);

                    var comanda = new Comenzi
                    {
                        DataComanda = data,
                        Pret = pret,
                        IDClient = client.IDClient
                    };

                    context.Comenzis.InsertOnSubmit(comanda);
                    context.SubmitChanges();

                    int idcafea = cafea.IDProdus;
                    int cantitate = 1;
                    int idcomanda = comanda.IDComanda;

                    var detalii = new DetaliiComenzi
                    {
                        IDCafea = idcafea,
                        IDComanda = idcomanda,
                        Cantitate = cantitate
                    };

                    context.DetaliiComenzis.InsertOnSubmit(detalii);
                    context.SubmitChanges();

                    i++;

                    // Adăugare puncte pentru client
                    int pct = pret * 5;
                    context.AdaugaPuncte(pct, client.Email);
                    context.SubmitChanges();

                    // Afișare mesaj de confirmare
                    Message m = new Message();
                    m.SetErrorMessage("Comanda dumneavoastra a fost trimisa!");
                    m.Show();
                }
            }

            // Curățare colecții după terminarea buclei
            ShoppingCartManager.SelectedProducts.Clear();
            ShoppingCartManager.SelectedProductsPrices.Clear();
            productsListBox.Items.Clear();
            productsPricesListBox.Items.Clear();
            TotalTag.Visibility = Visibility.Collapsed;
            TotalVal.Text = string.Empty;


            //Message m = new Message();
            //m.SetErrorMessage("Comanda dumneavoastra a fost trimisa!");
            //m.Show();

            //ShoppingCartManager.SelectedProducts.Clear();
            //ShoppingCartManager.SelectedProductsPrices.Clear();
            //productsListBox.Items.Clear();
            //productsPricesListBox.Items.Clear();
            //TotalTag.Visibility = Visibility.Collapsed;
            //TotalVal.Text = string.Empty;

        }
    }
    
}
