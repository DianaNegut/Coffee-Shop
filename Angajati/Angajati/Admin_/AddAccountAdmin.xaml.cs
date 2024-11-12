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
    /// Interaction logic for AddAccountAdmin.xaml
    /// </summary>
    public partial class AddAccountAdmin : Window
    {
        string email;
        public AddAccountAdmin(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Application.Current.Shutdown();
        }
        private void txtNume_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textNume.Text) && txtNume.Text.Length > 0)
            {
                textNume.Visibility = Visibility.Collapsed;
            }
            else
            {
                textNume.Visibility = Visibility.Visible;
            }
        }

        private void txtPrenume_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textPrenume.Text) && txtPrenume.Text.Length > 0)
            {
                textPrenume.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPrenume.Visibility = Visibility.Visible;
            }
        }

        private async Task<bool> IsEmailInDatabaseAsync(string email)
        {
            return await Task.Run(() =>
            {
                using (var context = new CoffeeShopDataContext())
                {
                    string trimmedEmail = email.Trim();

                    var angajat = context.Angajats.FirstOrDefault(c => c.Email == trimmedEmail);

                    return angajat != null;
                }
            });
        }

        private async Task<bool> IsUsernameInDatabaseAsync(string username)
        {
            return await Task.Run(() =>
            {
                using (var context = new CoffeeShopDataContext())
                {
                    string trimmedUsername = username.Trim();

                    var angajat = context.Angajats.FirstOrDefault(c => c.Username == trimmedUsername);

                    return angajat != null;
                }
            });
        }

        private async void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            string username = txtUsername.Text;

            if (!string.IsNullOrEmpty(username))
            {

                if (await IsUsernameInDatabaseAsync(username))
                {


                    textUsername.Text = "Username deja utilizat! Introduceți alt username!";
                    textUsername.Visibility = Visibility.Visible;

                }
                else
                {

                    textUsername.Visibility = Visibility.Collapsed;
                }
            }
            else
            {

                textUsername.Visibility = Visibility.Collapsed;
            }
        }

        private async void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            string email = txtEmail.Text;

            if (!string.IsNullOrEmpty(email))
            {

                if (await IsEmailInDatabaseAsync(email))
                {


                    textEmail.Text = "Email deja utilizat! Introduceți alt email!";
                    textEmail.Visibility = Visibility.Visible;

                }
                else
                {

                    textEmail.Visibility = Visibility.Collapsed;
                }
            }
            else
            {

                textEmail.Visibility = Visibility.Collapsed;
            }
        }
        private void myDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new CoffeeShopDataContext())
            {
                string username = txtUsername.Text.Trim();
                string email = txtEmail.Text.Trim();
                var existingEmployeeByEmail = context.Angajats.FirstOrDefault(c => c.Email == email);

                var existingEmployeeByUsername = context.Angajats.FirstOrDefault(c => c.Username == username);

                if (existingEmployeeByEmail != null && existingEmployeeByUsername != null)
                {
                    Error error = new Error();
                    error.SetErrorMessage("Username si email deja utilizate! Vă rugăm să \nintroduceți un alt username si alt email.");
                    error.Show();
                    return;
                }

                if (existingEmployeeByEmail != null)
                {
                    Error error = new Error();
                    error.SetErrorMessage("Email deja utilizat!\n Vă rugăm să introduceți un alt email.");
                    error.Show();
                    return;
                }

                if (existingEmployeeByUsername != null)
                {
                    Error error = new Error();
                    error.SetErrorMessage("Username deja utilizat! Vă rugăm să introduceți un alt username.");
                    error.Show();
                    return;
                }
                var newEmployee = new Angajat
                {
                    Username = username,
                    Parola = PasswordHasher.HashPassword(txtPassword.Password),
                    Email = email,
                    Nume = txtNume.Text.Trim(),
                    Prenume = txtPrenume.Text.Trim(),
                    DataNastere = myDatePicker.SelectedDate.Value
                };
                context.Angajats.InsertOnSubmit(newEmployee);
                context.SubmitChanges();
                MessageBox.Show("Angajat adaugat cu succes.", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);
                txtNume.Clear();
                txtPrenume.Clear();
                txtUsername.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                myDatePicker.SelectedDate = null;
            }
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
    }
}
