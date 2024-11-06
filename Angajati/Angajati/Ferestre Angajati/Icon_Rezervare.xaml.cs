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

namespace Angajati.Ferestre_Angajati
{
    /// <summary>
    /// Interaction logic for Icon_Comanda.xaml
    /// </summary>
    public partial class Icon_Rezervare : Window
    {
        private int idRezervare;
        private DateTime dataRezervare;
        private string email;
        public Icon_Rezervare(int idRezervare, DateTime data, string email)
        {
            InitializeComponent();
            this.email = email;
            Loaded += PopulareFereastra;
            
            this.dataRezervare = data;
            this.idRezervare = idRezervare;
        }
        private void PopulareFereastra(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var context = new CoffeeShopDataContext())
                {
                    var reservation = (from r in context.Rezervaris
                                       where r.IDRezervare == this.idRezervare
                                       select r).FirstOrDefault();

                    if (reservation != null)
                    {
                        var client = (from c in context.Clients
                                      where c.IDClient == reservation.IDClient
                                      select c).FirstOrDefault();

                        if (client != null)
                        {
                            Nume_Client.Text = client.Nume;
                        }
                        else
                        {
                            Error er = new Error();
                            er.SetErrorMessage("Clientul nu a fost găsit.");
                            er.Show();
                        }

                        Data.Text = reservation.DataRezervare.ToString();
                        Numar_Rezervare.Text = this.idRezervare.ToString();
                        Numar_locuri.Text = reservation.NrLocuri.ToString();
                    }
                    else
                    {
                        Error er = new Error();
                        er.SetErrorMessage("Rezervarea nu a fost găsită.");
                        er.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                Error er = new Error();
                er.SetErrorMessage($"A apărut o eroare: {ex.Message}");
                er.Show();
            }
        }


        private void ButtonFinalizareRezervare_Click(object sender, RoutedEventArgs e)
        {
                using (var context = new CoffeeShopDataContext())
                {
                    var employee = (from er in context.Angajats
                                    where er.Email == this.email
                                    select er).FirstOrDefault();

                    if (employee != null)
                    {
                        int idAngajat = employee.IDAngajat;

                        var reservation = (from r in context.Rezervaris
                                           where r.IDRezervare == this.idRezervare
                                           select r).FirstOrDefault();

                        if (reservation != null)
                        {
                            reservation.IDAngajat = idAngajat;
                            context.SubmitChanges();
                            Message mes = new Message();
                            mes.SetErrorMessage("Rezervare a fost finalizată cu succes!");
                            mes.Show();
                        }
                        else
                        {
                            Error eroare = new Error();
                            eroare.SetErrorMessage("Rezervarea nu a fost găsită.");
                            eroare.Show();
                        }
                    }
                    else
                    {
                        Error eroare = new Error();
                        eroare.SetErrorMessage("Angajatul nu a fost găsit.");
                        eroare.Show();
                    }
                }
        }
            
        




        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Nume_Data_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
