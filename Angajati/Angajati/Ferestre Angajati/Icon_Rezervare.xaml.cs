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
    public partial class Icon_Rezervare : Window
    {
        private int idRezervare;
        private DateTime dataRezervare;
        private string email;
        public Icon_Rezervare(int idRezervare, DateTime data, string email)
        {
            InitializeComponent();
            this.email = email;
            Loaded += PopulareFereastra;
            
            this.dataRezervare = data;
            this.idRezervare = idRezervare;
        }
        private void PopulareFereastra(object sender, RoutedEventArgs e)
        {

            using (var adapter = new Coffee_ShoppDataSetTableAdapters.ComenziTableAdapter())
            {

                try
                {
                    var queriesAdapter = new Coffee_ShoppDataSetTableAdapters.QueriesTableAdapter();


                    string idClient = queriesAdapter.GetClientNameByReservationId(this.idRezervare).ToString();
                    Nume_Client.Text = idClient;
                    Data.Text = this.dataRezervare.ToString();
                    Numar_Rezervare.Text = this.idRezervare.ToString();
                    string nrLocuriValue = queriesAdapter.GetNrLocuriByIdRezervare(this.idRezervare).ToString();
                    Numar_locuri.Text = nrLocuriValue;


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A apărut o eroare: {ex.Message}");
                }

            }


        }

        private void ButtonFinalizareRezervare_Click(object sender, RoutedEventArgs e)
        {
            using (var adapter = new Coffee_ShoppDataSetTableAdapters.ComenziTableAdapter())
            {

                try
                {
                    var queriesAdapter = new Coffee_ShoppDataSetTableAdapters.QueriesTableAdapter();

                    int idAngajat = Convert.ToInt32(queriesAdapter.GetEmployeeIdByEmail(this.email));
                    queriesAdapter.UpdateIDAngajatByIdRezervare(idAngajat, this.idRezervare);

                    MessageBox.Show("Rezervare a fost finalizată cu succes!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A apărut o eroare: {ex.Message}");
                }

            }
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
