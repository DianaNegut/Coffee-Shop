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

namespace Angajati.Plata
{
    /// <summary>
    /// Interaction logic for Plata.xaml
    /// </summary>
    public partial class Plati : Window
    {
        public Plati()
        {
            InitializeComponent();
        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.Text = "";
        }
        private void TextBox_PreviewTextInputName(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = !e.Text.All(c => Char.IsLetter(c));
        }
        private void TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            e.Handled = !int.TryParse(e.Text, out _);
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.Text = textBox.Text.ToUpper();
                textBox.CaretIndex = textBox.Text.Length;
            }
        }


        private void TextBox_GotFocusData(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "DAY/MONTH")
            {
                textBox.Text = "";
            }
        }

        private void TextBox_PreviewTextInputData(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;
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
            TextBox textBox = sender as TextBox;
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
            TextBox textBox = sender as TextBox;
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



        
    }
}
