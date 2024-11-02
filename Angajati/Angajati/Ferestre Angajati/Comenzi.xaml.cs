using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Angajati.Ferestre_Angajati
{
    /// <summary>
    /// Interaction logic for Comenzi.xaml
    /// </summary>
    public partial class Comenzi : Window
    {
        private string email;
        public ObservableCollection<Comanda> ComenziDisponibile { get; set; } = new ObservableCollection<Comanda>();

        public Comenzi(string email)
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
            // Clear any existing orders
            ComenziDisponibile.Clear();

            using (var adapter = new Coffee_ShoppDataSetTableAdapters.ComenziTableAdapter())
            {
                var dataTable = adapter.GetData();

                foreach (var row in dataTable)
                {
                    DateTime dataComanda = (DateTime)row["DataComanda"];
                    var idAngajatValue = row["IDAngajat"];
                    var pretComanda = row["Pret"];
                    float pretComandaFloat = Convert.ToSingle(pretComanda);
                    int? idAngajat = null;

                    if (idAngajatValue != DBNull.Value)
                    {
                        idAngajat = Convert.ToInt32(idAngajatValue);
                    }

                    // Only add today's orders assigned to an employee
                    if (idAngajat == null && dataComanda.Date == DateTime.Now.Date)
                    {
                        ComenziDisponibile.Add(new Comanda
                        {
                            IdComanda = row["IDComanda"].ToString(),
                            DataComanda = dataComanda,
                            PretComanda = pretComandaFloat
                        });
                    }
                }
            }

            // Control the visibility of NoOrdersPanel based on the list content
            NoOrdersPanel.Visibility = ComenziDisponibile.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
            OrdersListView.Visibility = ComenziDisponibile.Count == 0 ? Visibility.Collapsed : Visibility.Visible;
        }

        private void OnOrderItemClicked(object sender, MouseButtonEventArgs e)
        {
            
            if (sender is FrameworkElement element)
            {
                if (element.DataContext is Comanda comanda)
                {
                    string idComandaStr = comanda.IdComanda;
                    if (int.TryParse(idComandaStr, out int idComandaInt))
                    {
                        Icon_Comanda ic = new Icon_Comanda(idComandaInt, comanda.DataComanda, this.email);
                        ic.Show();
                    }
                    else
                    {
                        MessageBox.Show("ID-ul comenzii nu este valid.");
                    }
                }
            }
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
            new Comenzi(this.email).Show();
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
