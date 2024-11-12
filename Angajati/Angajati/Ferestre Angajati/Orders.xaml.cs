using Angajati.Message_Box;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;

namespace Angajati.Ferestre_Angajati
{
    /// <summary>
    /// Interaction logic for Orders.xaml
    /// </summary>
    public partial class Orders : Window
    {
        private string email;
        public ObservableCollection<Comanda> ComenziDisponibile { get; set; } = new ObservableCollection<Comanda>();

        public Orders(string email)
        {
            this.email = email;
            InitializeComponent();
            IncarcaComenziDinBazaDeDate();
            OrdersListView.ItemsSource = ComenziDisponibile; 
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void IncarcaComenziDinBazaDeDate()
        {
            ComenziDisponibile.Clear();
            using (var context = new CoffeeShopDataContext())
            {
                var comenziAzi = context.Comenzis
                                        .Where(comanda => comanda.DataComanda == DateTime.Now.Date
                                                          && comanda.IDAngajat == null);

                foreach (var comanda in comenziAzi)
                {
                    ComenziDisponibile.Add(new Comanda
                    {
                        IdComanda = comanda.IDComanda.ToString(),
                        DataComanda = comanda.DataComanda.HasValue ? comanda.DataComanda.Value : DateTime.MinValue,
                        PretComanda = (float)comanda.Pret
                    });
                }
            }
            NoOrdersPanel.Visibility = ComenziDisponibile.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
            OrdersListView.Visibility = ComenziDisponibile.Count == 0 ? Visibility.Collapsed : Visibility.Visible;
        }




        private void OnOrderItemClicked(object sender, MouseButtonEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                if (element.DataContext is Comanda comanda)
                {
                    
                    {
                        string idComandastr = comanda.IdComanda;
                         if (int.TryParse(idComandastr, out int idComandaint))
                        {
                            Icon_Comanda ic = new Icon_Comanda(idComandaint, comanda.DataComanda, this.email);
                            ic.Show();
                            ic.ComandaFinalizata += OnComandaFinalizata;

                        }
                        else
                        {
                            var error = new Error();
                            error.SetErrorMessage("Comanda nu a fost găsită!");
                            error.Show();
                        }
                    }
                }
            }
        }


        private void OnComandaFinalizata(object sender, EventArgs e)
        {
            IncarcaComenziDinBazaDeDate();
            OrdersListView.ItemsSource = ComenziDisponibile;
        }



        private void aboutus_Click(object sender, RoutedEventArgs e)
        {
            DespreNoi dn = new DespreNoi(this.email);
            dn.Show();
            this.Hide();
        }

        private void comenzi_Click(object sender, RoutedEventArgs e)
        {
            
            this.Hide();
            new Orders(this.email).Show();
        }

        private void reservation_Click(object sender, RoutedEventArgs e)
        {
            Rezervari r = new Rezervari(this.email);
            this.Hide();
            r.Show();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            firstMenu fm = new firstMenu(this.email);
            this.Hide();
            fm.Show();
        }

        private void user_Click(object sender, RoutedEventArgs e)
        {
            profilAngajat pa = new profilAngajat(this.email);
            this.Hide();
            pa.Show();
        }
    }
}
