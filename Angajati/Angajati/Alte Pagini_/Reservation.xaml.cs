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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Angajati
{
    /// <summary>
    /// Interaction logic for Reservation.xaml
    /// </summary>
    public partial class Reservation : Window
    {
        private string email;
        public Reservation(string email)
        {
            this.email = email;
            InitializeComponent();
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

        private void ReservationBtn_Click(object sender, RoutedEventArgs e)
        {
            DateTime? data = datePicker.SelectedDate;
            string ora = (comboBoxTime.SelectedItem as ComboBoxItem)?.Content.ToString();
            string locuri = (comboBoxPeople.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (ora == null && locuri == null && locuri == null)
            {
                Error eroare = new Error();
                eroare.SetErrorMessage("Selectie invalida!");
                eroare.Show();

            }
            int nrlocuri = int.Parse(locuri);

            var context = new CoffeeShopDataContext();
            int idMasa = 0;
           
            foreach ( var masa in context.Meses )
            {
                if(masa.DataRezervare == null && masa.NumarLocuriDisponibile >= nrlocuri)
                {
                    idMasa = masa.IDMasa;
                    break;
                }
            }

            if( idMasa != 0 ) {
                var client = context.Clients.SingleOrDefault(p => p.Email == this.email);
                var rezervare = new Rezervari
                {
                    IDClient = client.IDClient,
                    IDMasa = idMasa,
                    DataRezervare = data,
                    NrLocuri = nrlocuri
                };

                context.Rezervaris.InsertOnSubmit(rezervare);
                context.SubmitChanges();

                Message m = new Message();
                m.SetErrorMessage("Rezervarea dumneavoastra a fost inregistrata!");
                m.Show();
            }
            else
            {
                Error m = new Error();
                m.SetErrorMessage("Din pacate nu avem o astfel de masa disponibila la data si ora aleasa. Va rugam sa alegeti alte optiuni!");
                m.Show();
               
            }

        }


    }
}
