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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Angajati.Ferestre_Angajati
{
    /// <summary>
    /// Interaction logic for profilAngajat.xaml
    /// </summary>
    public partial class profilAngajat : Window
    {
        private string email;
        public profilAngajat(string email)
        {
            this.email = email;
            InitializeComponent();
            PopulareFereastra();
        }
        private void PopulareFereastra()
        {
            using (var adapter = new Coffee_ShoppDataSetTableAdapters.AngajatTableAdapter())
            {

                try
                {
                    var queriesAdapter = new Coffee_ShoppDataSetTableAdapters.QueriesTableAdapter();
                    Email.Text = this.email;
                    Rol.Text = queriesAdapter.GetRolByEmail(this.email).ToString();
                    var NumeResult = queriesAdapter.GetNumeByEmail(this.email);
                    var PrenumeResult = queriesAdapter.GetPrenumeByEmail(this.email);
                    string Nume = NumeResult != null ? NumeResult.ToString() : "N/A"; 
                    string Prenume = PrenumeResult != null ? PrenumeResult.ToString() : "N/A";
                    string tot = Nume +" "+ Prenume;
                    this.Nume_Prenume.Text = tot;

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A apărut o eroare: {ex.Message}");
                }

            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            firstMenu fm = new firstMenu(this.email);
            this.Hide();
            fm.Show();
        }

        private void reservation_Click(object sender, RoutedEventArgs e)
        {
            Rezervari r = new Rezervari(this.email);
            this.Hide();
            r.Show();
        }

        private void comenzi_Click(object sender, RoutedEventArgs e)
        {
            Comenzi c = new Comenzi(this.email);
            this.Hide();
            c.Show();
        }

        private void aboutus_Click(object sender, RoutedEventArgs e)
        {
            DespreNoi dn = new DespreNoi(this.email);
            dn.Show();
            this.Hide();
        }

        private void user_Click(object sender, RoutedEventArgs e)
        {
            profilAngajat pa = new profilAngajat(this.email);
            this.Hide();
            pa.Show();
        }
    }
}
