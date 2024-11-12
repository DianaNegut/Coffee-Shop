using Angajati;
using Angajati.Message_Box;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for StocAdmin.xaml
    /// </summary>
    public partial class StocAdmin : Window
    {
        private string email;
        public StocAdmin(string email)
        {
            this.email = email;
            InitializeComponent();

            using (var context = new CoffeeShopDataContext())
            {
                var productsList = context.Produses.Select(product => new { Produs = product.Denumire, StocDisponibil = product.Stoc }).ToList();
               ProductList.ItemsSource = productsList;
               
            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Application.Current.Shutdown();
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            HomeAdmin ha = new HomeAdmin(email);
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

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            if (button?.DataContext is var currentProduct)
            {
                var productName = currentProduct.GetType().GetProperty("Produs")?.GetValue(currentProduct)?.ToString();

                var stackPanel = VisualTreeHelper.GetParent(button) as StackPanel;
                if (stackPanel == null) return;

                var textBox = stackPanel.Children.OfType<TextBox>().FirstOrDefault();
                if (textBox != null)
                {
                    int stocadd = Convert.ToInt32(textBox.Text);
                    var context = new CoffeeShopDataContext();

                    context.AdaugaLaStoc(stocadd, productName);
                    context.SubmitChanges();

                    var productsList = context.Produses.Select(product => new { Produs = product.Denumire, StocDisponibil = product.Stoc }).ToList();
                    ProductList.ItemsSource = productsList;

                    textBox.Text = "";


                }
                else
                {
                    Error m = new Error();
                    m.SetErrorMessage("Vă rugăm introduceți o cantitate pe care să o adăugați la stocul curent!");
                    m.Show();
                }

            }
            else return;
        }


    }
}
