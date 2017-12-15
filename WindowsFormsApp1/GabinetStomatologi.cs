using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guitest
{
    public partial class GUI : Form
    {
        List<Pacjent> pacjenci = new List<Pacjent>(); //zaczynam od pustej listy
        public GUI()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNowypacjent_Click(object sender, EventArgs e)
        {

        }

        private void textBoxImie_TextChanged(object sender, EventArgs e)
        {
            string imie = textBoxImie.Text;
        }

        private void textBoxNazwisko_TextChanged(object sender, EventArgs e)
        {
            string nazwisko = textBoxNazwisko.Text;
        }

        private void dataurPacjenta_ValueChanged(object sender, EventArgs e)
        {

        }
        private void UpdateBinding()
        {
            listBoxTest.DataSource = pacjenci;
            listBoxTest.DisplayMember = "FullInfo";
        }
        private void buttonzarejestruj_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.ZarejestrujPacjenta(textBoxImie.Text, textBoxNazwisko.Text, textBoxemail.Text, textBoxnrtel.Text);
            textBoxImie.Text = "";
            textBoxNazwisko.Text = "";
            textBoxemail.Text = "";
            textBoxnrtel.Text = "";
        }

        private void textBoxPesel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();// odwolanie do bazy danych z poziomu przycisku zarejestruj
            pacjenci = db.GetPeople(textBoxNazwisko.Text);// metoda get people dla okna nazawisko
            UpdateBinding(); // do szukania
        }
    }
}
