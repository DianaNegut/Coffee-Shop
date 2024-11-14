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
            try
            {
                using (var context = new CoffeeShopDataContext())
                {
                    Email.Text = this.email;

                    var rol = context.Angajats
                                     .Where(a => a.Email == this.email)
                                     .Select(a => a.Rol)
                                     .FirstOrDefault();

                    Rol.Text = rol ?? "N/A";

                    var angajat = context.Angajats
                                         .Where(a => a.Email == this.email)
                                         .FirstOrDefault();

                    string Nume = angajat?.Nume ?? "N/A";
                    string Prenume = angajat?.Prenume ?? "N/A";

                    string tot = Nume + " " + Prenume;
                    this.Nume_Prenume.Text = tot;
                }
            }
            catch (Exception ex)
            {
                Error er = new Error();
                er.SetErrorMessage($"A apărut o eroare: {ex.Message}");
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
            Orders c = new Orders(this.email);
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

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            LoginPage l = new LoginPage();
            l.Show();
            this.Hide();
        }
    }
}
