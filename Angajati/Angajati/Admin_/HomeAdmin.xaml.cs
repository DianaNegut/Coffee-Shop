using System;
using System.Collections.Generic;
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
    /// Interaction logic for HomeAdmin.xaml
    /// </summary>
    public partial class HomeAdmin : Window
    {
        private string email;
        public HomeAdmin(string email)
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
            HomeAdmin ha = new HomeAdmin(this.email);
            ha.Show();
            this.Close();
        }

        private void AddAccountBtn_Click(object sender, RoutedEventArgs e)
        {
            AddAccountAdmin a = new AddAccountAdmin(email);
            a.Show();
            this.Close();
        }

        private void OffersBtn_Click(object sender, RoutedEventArgs e)
        {
            SendNotifAdmin sn = new SendNotifAdmin(email);
            sn.Show();
            this.Close();
        }

        private void StocBtn_Click(object sender, RoutedEventArgs e)
        {
            StocAdmin ha = new StocAdmin(email);
            ha.Show();
            this.Close();
        }
    }
}
