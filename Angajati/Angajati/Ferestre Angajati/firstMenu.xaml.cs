using Angajati.Ferestre_Angajati;
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

namespace Angajati
{
    /// <summary>
    /// Interaction logic for firstMenu.xaml
    /// </summary>
    public partial class firstMenu : Window
    {
        private string email;
        public firstMenu() : this("laura.popa@example.com") 
        {
        }

        public firstMenu(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            firstMenu fm = new firstMenu(this.email);
            fm.Show();
            this.Hide();
        }

        private void reservation_Click(object sender, RoutedEventArgs e)
        {
            Rezervari r = new Rezervari(this.email);
            r.Show();
            this.Hide();
        }

        private void user_Click(object sender, RoutedEventArgs e)
        {
            profilAngajat pa = new profilAngajat(this.email);
            this.Hide();
            pa.Show();
        }

        private void aboutus_Click(object sender, RoutedEventArgs e)
        {
            DespreNoi dn = new DespreNoi(this.email);
            this.Hide();
            dn.Show();
        }

        private void comenzi_Click(object sender, RoutedEventArgs e)
        {
            Comenzi c = new Comenzi(this.email);
            this.Hide();
            c.Show();
        }
    }
}
