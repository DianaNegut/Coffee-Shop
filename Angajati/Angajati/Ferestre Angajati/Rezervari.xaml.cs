using Angajati.Ferestre_Angajati;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.Packaging;
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
    /// Interaction logic for Rezervari.xaml
    /// </summary>
    public partial class Rezervari : Window
    {
        private string email;
        public ObservableCollection<Rezervare> RezervariDisponibile { get; set; } = new ObservableCollection<Rezervare>();
        public Rezervari(string email)
        {
            this.email = email; 
            InitializeComponent();
            IncarcaRezervariDinBazaDeDate();
            RezervariListView.ItemsSource = RezervariDisponibile;
        }
        private void IncarcaRezervariDinBazaDeDate()
        {
            RezervariDisponibile.Clear();

            using (var context = new CoffeeShopDataContext())
            {
                var rezervariAzi = from rezervare in context.Rezervaris
                                   where rezervare.DataRezervare == DateTime.Now.Date && rezervare.IDAngajat == null
                                   select rezervare;

                foreach (var rezervare in rezervariAzi)
                {
                    RezervariDisponibile.Add(new Rezervare
                    {
                        IdRezervare = rezervare.IDRezervare.ToString(),
                        DataRezervare = rezervare.DataRezervare ?? DateTime.MinValue,
                        OraRezervare = rezervare.Ora,
                        NumarLocuri = rezervare.NrLocuri.HasValue ? rezervare.NrLocuri.Value : 0
                    });
                }
            }

            NoRezervariPanel.Visibility = RezervariDisponibile.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
            RezervariListView.Visibility = RezervariDisponibile.Count == 0 ? Visibility.Collapsed : Visibility.Visible;
        }


        private void home_Click(object sender, RoutedEventArgs e)
        {
            firstMenu fm = new firstMenu(this.email);
            this.Hide();
            fm.Show();
        }
        private void OnRezervareItemClicked(object sender, MouseButtonEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                if (element.DataContext is Rezervare rezervare)
                {
                    string idRezervarestr = rezervare.IdRezervare;
                    if (int.TryParse(idRezervarestr, out int idRezervareInt))
                    {
                        Icon_Rezervare ic = new Icon_Rezervare(idRezervareInt, rezervare.DataRezervare, this.email);
                        ic.Show(); 
                    }
                    else
                    {
                        MessageBox.Show("ID-ul comenzii nu este valid.");
                    }
                }
            }
        }

        private void reservation_Click(object sender, RoutedEventArgs e)
        {
            Rezervari r = new Rezervari(this.email);
            this.Hide();
            r.Show();
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

        private void comenzi_Click(object sender, RoutedEventArgs e)
        {
            Orders c = new Orders(this.email);
            this.Hide();
            c.Show();
        }

        private void aboutus_Click(object sender, RoutedEventArgs e)
        {
            DespreNoi dn = new DespreNoi(this.email);
            this.Hide();
            dn.Show();
        }
    }
}
