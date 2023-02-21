using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp.API;

namespace WinApp
{
    public partial class Kadet : Form
    {
        public Kadet()
        {
            InitializeComponent();
            
        }

        private void wyszukajButton_Click(object sender, EventArgs e)
        {
            Wyszukiwarka wyszukiwarka = new Wyszukiwarka();
            wyszukiwarka.StartPosition= FormStartPosition.CenterScreen;
            wyszukiwarka.Width = 580;
            wyszukiwarka.Height = 440;
            wyszukiwarka.Show();
        }

        private void usunButton_Click(object sender, EventArgs e)
        {
            KadryServiceClient kadry = new KadryServiceClient();
            kadry.UsunPracownika(usunTitleTextbox.textBoxNazwa);

            usunTitleTextbox.textBoxNazwa = null;

        }


        private void dodajButton_Click(object sender, EventArgs e)
        {
            
            KadryServiceClient kadry = new KadryServiceClient();
            Pracownik pracownik = new Pracownik();
            pracownik.Imie = imieTitleTextbox.textBoxNazwa;
            pracownik.Nazwisko = nazwiskoTitleTextbox.textBoxNazwa;
            pracownik.Email = emailTitleTextbox.textBoxNazwa;
            pracownik.Pesel = peselTitleTextbox.textBoxNazwa;
            pracownik.Numer = numerTitleTextbox.textBoxNazwa;

            kadry.DodajPracownika(pracownik, "Startowe");

            imieTitleTextbox.textBoxNazwa = null;
            nazwiskoTitleTextbox.textBoxNazwa = null;
            emailTitleTextbox.textBoxNazwa = null;
            peselTitleTextbox.textBoxNazwa = null;
            numerTitleTextbox.textBoxNazwa = null;
            

        }

        private void edytujButton_Click(object sender, EventArgs e)
        {
            KadryServiceClient kadry = new KadryServiceClient();
            Pracownik pracownik = new Pracownik();
            pracownik.Imie = imieTitleTextbox.textBoxNazwa;
            pracownik.Nazwisko = nazwiskoTitleTextbox.textBoxNazwa;
            pracownik.Email = emailTitleTextbox.textBoxNazwa;
                                   
            kadry.ModyfikujPracownika(pracownik, peselTitleTextbox.textBoxNazwa);
            imieTitleTextbox.textBoxNazwa = null;
            nazwiskoTitleTextbox.textBoxNazwa = null;
            emailTitleTextbox.textBoxNazwa = null;
            peselTitleTextbox.textBoxNazwa = null;

        }

    }
}
