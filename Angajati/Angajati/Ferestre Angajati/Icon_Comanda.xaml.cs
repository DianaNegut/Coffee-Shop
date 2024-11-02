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

namespace Angajati.Ferestre_Angajati
{
    /// <summary>
    /// Interaction logic for Icon_Comanda.xaml
    /// </summary>
    public partial class Icon_Comanda : Window
    {
        private int idComanda;
        private DateTime dataComanda;
        private string email;
        public Icon_Comanda(int idComanda, DateTime data, string email)
        {
            InitializeComponent();
            this.email = email;
            Loaded += PopulareFereastra;
            ListViewProduse.ItemsSource = GetProduseComanda();

            this.dataComanda = data;
            this.idComanda = idComanda;
        }
        private void PopulareFereastra(object sender, RoutedEventArgs e)
        {

            using (var adapter = new Coffee_ShoppDataSetTableAdapters.ComenziTableAdapter())
            {

                try
                {
                    var queriesAdapter = new Coffee_ShoppDataSetTableAdapters.QueriesTableAdapter();
                    
                   
                    string idClient = queriesAdapter.GetClientNameByOrderId(this.idComanda).ToString();
                    Nume_Client.Text = idClient;
                    Data.Text = this.dataComanda.ToString();
                    Numar_Comanda.Text = this.idComanda.ToString();

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A apărut o eroare: {ex.Message}");
                }

            }
             
            
        }

        public void ButtonFinalizareComanda_Click(object sender, RoutedEventArgs e)
        {
            using (var adapter = new Coffee_ShoppDataSetTableAdapters.ComenziTableAdapter())
            {

                    try
                    {
                        var queriesAdapter = new Coffee_ShoppDataSetTableAdapters.QueriesTableAdapter();

                        int idAngajat = Convert.ToInt32(queriesAdapter.GetEmployeeIdByEmail(this.email));
                        queriesAdapter.UpdateIDAngajatByIdComanda(idAngajat, this.idComanda);

                        MessageBox.Show("Comanda a fost finalizată cu succes!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"A apărut o eroare: {ex.Message}");
                    }
                
            }
        }

        private List<Cafele> GetProduseComanda()
        {
            
            var produse = new List<Cafele>
            {
                new Cafele { NumeCafea = "Café Latte", Cantitate = 2, Pret = 15.00 },
                new Cafele { NumeCafea = "Espresso", Cantitate = 1, Pret = 10.00 },
                new Cafele { NumeCafea = "Café Latte", Cantitate = 2, Pret = 15.00 },
                new Cafele { NumeCafea = "Espresso", Cantitate = 1, Pret = 10.00 },
                new Cafele { NumeCafea = "Café Latte", Cantitate = 2, Pret = 15.00 },
                new Cafele { NumeCafea = "Espresso", Cantitate = 1, Pret = 10.00 },
                new Cafele { NumeCafea = "Café Latte", Cantitate = 2, Pret = 15.00 },
                new Cafele { NumeCafea = "Espresso", Cantitate = 1, Pret = 10.00 },
                new Cafele { NumeCafea = "Café Latte", Cantitate = 2, Pret = 15.00 },
                new Cafele { NumeCafea = "Espresso", Cantitate = 1, Pret = 10.00 },
                new Cafele { NumeCafea = "Croissant", Cantitate = 3, Pret = 5.50 }
            };

            return produse;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Nume_Data_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
