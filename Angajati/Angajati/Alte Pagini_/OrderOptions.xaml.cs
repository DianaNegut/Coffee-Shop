using Angajati;
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

namespace Angajati
{
    /// <summary>
    /// Interaction logic for OrderOptions.xaml
    /// </summary>
    public partial class OrderOptions : Window
    {
        private string email;
        public OrderOptions(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        public static int? verificareStoc(string nume)
        {
            var context = new CoffeeShopDataContext();
            var produs = context.Produses.SingleOrDefault(p => p.Denumire == nume);
            if (produs != null)
                return produs.Stoc;
            else
                return null;
        }

        public static decimal? verificarePret(string nume, int quantity)
        {
            var context = new CoffeeShopDataContext();
            var produs = context.Produses.SingleOrDefault(p => p.Denumire == nume);
            if (produs != null)
            {
                return quantity * produs.Pret;
            }
            else return null;
        }

        public static void modificareStoc(string nume, int quantity)
        {
            var context = new CoffeeShopDataContext();
            var produs = context.Produses.SingleOrDefault(p => p.Denumire == nume);

            if (produs != null)
            {
                produs.Stoc -= quantity;
                context.SubmitChanges();
            }
        }

        public static string coffee_details;
        public static decimal? coffee_price;
        public static bool success;

        string milk(string selection)
        {
            switch (selection)
            {
                case "Normal":
                    return "lapte de vaca";

                case "Ovaz":
                    return "lapte de ovaz";

                case "Orez":
                    return "lapte de orez";

                case "Soia":
                    return "lapte de soia";

                case "Cocos":
                    return "lapte de cocos";

            }
            return null;
        }

        string syrup(string selection)
        {
            switch (selection)
            {
                case "Ciocolata":
                    return "sirop de ciocolata";

                case "Vanilie":
                    return "sirop de vanilie";

                case "Caramel":
                    return "sirop de caramel";

                case "Cocos":
                    return "sirop de cocos";

                case "Irish":
                    return "sirop irish";

                case "Amaretto":
                    return "sirop amaretto";

            }
            return null;
        }

        private void OkayBtn_Click(object sender, RoutedEventArgs e)
        {
            int po = 0;
                coffee_details = null;
                coffee_price = 0.00m;
                success = false;
                po = 0;
                int checkedb = 0;
                var radioButtons = MainGrid.Children.OfType<RadioButton>();
                foreach (var rb in radioButtons)
                {
                    string selection;
                    if (rb.IsChecked == true)
                    {
                        checkedb++;
                        string groupname = rb.GroupName;
                        if (groupname == "Lapte")
                        {
                            selection = milk(rb.Content.ToString());
                            if (Order.coffee_type == "cappuccino")
                            {
                                if (verificareStoc(selection) > 0)
                                {
                                    coffee_details += ' ';
                                    coffee_details += selection;
                                    coffee_price += verificarePret(selection, 1);
                                    modificareStoc(selection, 1);
                                }
                                else
                                {
                                    Error m = new Error();
                                    m.SetErrorMessage("Din pacate nu mai avem suficient din laptele selectat de dumneavoastra pentru aceasta bautura. Va rugam alegeti altceva!");
                                    m.Show();
                                    po++;
                                }
                            }
                            else
                            {
                                if (verificareStoc(selection) > 1)
                                {
                                    coffee_details += ' ';
                                    coffee_details += selection;
                                    coffee_price += verificarePret(selection, 2);
                                    modificareStoc(selection, 2);
                                }
                                else
                                {
                                Error m = new Error();
                                m.SetErrorMessage("Din pacate nu mai avem suficient din laptele selectat de dumneavoastra pentru aceasta bautura. Va rugam alegeti altceva!");
                                m.Show();
                                po++;
                                }
                            }
                        }
                        else if (groupname == "Siropuri")
                        {
                            selection = syrup(rb.Content.ToString());
                            if (verificareStoc(selection) > 0)
                            {
                                coffee_details += ' ';
                                coffee_details += selection;
                                coffee_price += verificarePret(selection, 1);
                            modificareStoc(selection, 1);
                            }
                            else
                            {
                            Error m = new Error();
                            m.SetErrorMessage("Din pacate nu mai avem acest sirop pe stoc. Va rugam alegeti altceva!");
                            m.Show();
                            
                            po++;
                            }
                        }
                        else
                        {
                            selection = rb.Content.ToString();
                            if (selection == "Da")
                            {
                                if (verificareStoc("frisca") > 0)
                                {
                                    coffee_details += ' ';
                                    coffee_details += selection;
                                    coffee_price += verificarePret("frisca", 1);
                                modificareStoc("frisca", 1);
                                }
                                else
                                {
                                Error m = new Error();
                                m.SetErrorMessage("Din pacate nu mai avem frisca pe stoc. Va rugam alegeti altceva!");
                                m.Show();
                               
                                po++;
                                }
                            }
                            else
                            {
                                coffee_details += ' ';
                                coffee_details += selection;
                            }
                        }
                    }

                }
            if (po == 0 && checkedb >= 2)
            {
                success = true;
            }
            else if (checkedb < 2)
            {
                
                Error m = new Error();
                m.SetErrorMessage("Va rugam selectati optiunile de lapte si frisca!");
                m.Show();
            }
            this.Close();

        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            success = false;
            coffee_details = null;
            this.Close();
        }

    }
}
