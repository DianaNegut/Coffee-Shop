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
using Angajati.Message_Box;
using static MaterialDesignThemes.Wpf.Theme;

namespace Angajati.Plata
{
    /// <summary>
    /// Interaction logic for Plata.xaml
    /// </summary>
    public partial class Plati : Window
    {
        float price;
        public Plati(float price)
        {
            this.price = price;
            InitializeComponent();
            this.SumaPlata.Text = price.ToString();
        }
        private bool IsValidCardNumber(string cardNumber)
        {
            int sum = 0;
            bool alternate = false;

            for (int i = cardNumber.Length - 1; i >= 0; i--)
            {
                int n = int.Parse(cardNumber[i].ToString());

                if (alternate)
                {
                    n *= 2;
                    if (n > 9) n -= 9;
                }

                sum += n;
                alternate = !alternate;
            }

            return (sum % 10 == 0);
        }
        private bool IsValidExpiryDate(int month, int year)
        {
            DateTime now = DateTime.Now;
            DateTime expiryDate = new DateTime(year, month, 1).AddMonths(1).AddDays(-1);
            return expiryDate >= now;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;

            if (textBox != null && textBox.Text == "0000")
            {
                textBox.Text = "";
                textBox.Foreground = new SolidColorBrush(Colors.Black); 
            }
        }

        private void TextBox_PreviewTextInputName(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = !e.Text.All(c => Char.IsLetter(c));
        }
        private void ValidateCard()
        {
            string cardNumber = $"{nr1.Text}{nr2.Text}{nr3.Text}{nr4.Text}";

            if (!IsValidCardNumber(cardNumber))
            {
                Error e = new Error();
                e.SetErrorMessage("Numărul de card nu este valid.");
                e.Show();
                return;
            }
            if (int.TryParse(DayTextBox.Text, out int month) && int.TryParse(MonthTextBox.Text, out int year))
            {
                if (!IsValidExpiryDate(month, year))
                {
                    Error e = new Error();
                    e.SetErrorMessage("Data de expirare nu este validă.");
                    e.Show();
                    return;
                }
            }
            else
            {
                Error e = new Error();
                e.SetErrorMessage("Data de expirare trebuie să fie numerică.");
                e.Show();
                return;
            }
            Message mesaj = new Message();
            mesaj.Show();
            mesaj.SetErrorMessage("Card valid!");
        }
    
        private void TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;
            e.Handled = !int.TryParse(e.Text, out _);
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;
            if (textBox != null)
            {
                textBox.Text = textBox.Text.ToUpper();
                textBox.CaretIndex = textBox.Text.Length;
            }
        }


        private void TextBox_GotFocusData(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;
            if (textBox.Text == "DAY/MONTH")
            {
                textBox.Text = "";
            }
        }

        private void TextBox_PreviewTextInputData(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;
            if (e.Text == "/")
            {
                if (textBox.Text.Length != 2)
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = !Char.IsDigit(e.Text, 0);
            }
        }

        private void TextBox_PreviewKeyDownData(object sender, System.Windows.Input.KeyEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;
            if (e.Key == Key.Back || e.Key == Key.Delete)
            {
                int indexOfSlash = textBox.Text.IndexOf('/');
                if (indexOfSlash >= 0 && (e.Key == Key.Back && textBox.CaretIndex == indexOfSlash ||
                                          e.Key == Key.Delete && textBox.CaretIndex == indexOfSlash + 1))
                {
                    e.Handled = true;
                }
            }
        }

        private void TextBox_TextChangedData(object sender, TextChangedEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;
            if (textBox.Text.Contains("/"))
            {
                int indexOfSlash = textBox.Text.IndexOf('/');
                if (textBox.Text.Length > indexOfSlash + 4)
                {
                    textBox.Text = textBox.Text.Substring(0, indexOfSlash + 5);
                }
            }
            if (textBox.Text.Length > 7)
            {
                textBox.Text = textBox.Text.Substring(0, 7);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Message m = new Message();
            m.SetErrorMessage("Plata a fost efectuata!");
            m.Show();
        }
        private void Button_AnularePlata(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
