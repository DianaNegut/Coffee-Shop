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
            try
            {
                using (var context = new CoffeeShopDataContext()) 
                {
                    var order = (from o in context.Comenzis
                                 where o.IDComanda == this.idComanda
                                 select o).FirstOrDefault();

                    if (order != null)
                    {
                        string idClient = (from c in context.Clients
                                           where c.IDClient == order.IDClient
                                           select c.Nume).FirstOrDefault();
                        Nume_Client.Text = idClient;
                        Data.Text = order.DataComanda.ToString();
                        Numar_Comanda.Text = order.IDComanda.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Comanda nu a fost găsită.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare: {ex.Message}");
            }
        }


        public void ButtonFinalizareComanda_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var context = new CoffeeShopDataContext())
                {
                    var employee = (from em in context.Angajats
                                    where em.Email == this.email
                                    select em).FirstOrDefault();

                    if (employee != null)
                    {
                        int idAngajat = employee.IDAngajat;

                        var order = (from o in context.Comenzis
                                     where o.IDComanda == this.idComanda
                                     select o).FirstOrDefault();

                        if (order != null)
                        {
                            order.IDAngajat = idAngajat;
                            context.SubmitChanges();
                            Message m = new Message();
                            m.SetErrorMessage("Comanda a fost finalizată cu succes!");
                            m.Show();
                        }
                        else
                        {
                            Error m = new Error();
                            m.SetErrorMessage("Comanda nu a fost găsită.");
                            m.Show();
                            
                        }
                    }
                    else
                    {
                        Error m = new Error();
                        m.SetErrorMessage("Angajatul nu a fost găsit.");
                        m.Show();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Error m = new Error();
                m.SetErrorMessage($"A apărut o eroare: {ex.Message}");
                m.Show();
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
