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

namespace Angajati.Login
{
    /// <summary>
    /// Interaction logic for Schimbare_Parola.xaml
    /// </summary>
    public partial class Schimbare_Parola : Window
    {
        private string email;
        public Schimbare_Parola(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void Button_Click_Validare(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password == txtPassword1.Password)
            {   using (var adapter = new Coffee_ShoppDataSetTableAdapters.ClientTableAdapter())
                {
                    Coffee_ShoppDataSet coffeeShopDataSet = new Coffee_ShoppDataSet();

                    // Completează dataset-ul cu datele din tabelul Client
                    adapter.Fill(coffeeShopDataSet.Client);

                    // Căutăm rândul cu emailul specificat
                    var clientRows = coffeeShopDataSet.Client.Where(client => client.Email == this.email).ToList();

                    if (clientRows.Count > 0)
                    {
                        // Dacă am găsit un utilizator cu acest email, actualizăm parola
                        var clientRow = clientRows[0];

                        // Hashează parola nouă
                        string passwordHash = PasswordHasher.HashPassword(txtPassword.Password);

                        // Actualizează parola
                        clientRow.Parola = passwordHash;

                        // Salvează modificările în baza de date
                        adapter.Update(coffeeShopDataSet.Client);
                        MessageBox.Show("Parola a fost actualizată cu succes!");
                    }
                    else
                    {
                        MessageBox.Show("Nu există un utilizator cu acest email.");
                    }
                }
            }
            else
            {

            }
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            Forgot_Password fp = new Forgot_Password();
            fp.Show();
            this.Hide();
        }
    }
}
