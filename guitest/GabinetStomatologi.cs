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
            listBoxPacjent.DataSource = pacjenci; //wlasciwosci listy DataSource przypiusjemy liste pacjenci
            listBoxPacjent.DisplayMember = "FullInfo";// listbox wyswietla fullinfo, w klasie pacjent tworzymy full info, czyli wybieramy 
            // kilka informacji z klasy pacjent do wyswietlenia w list boxie
        }
        private void buttonzarejestruj_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.ZarejestrujPacjenta(textBoxImie.Text, textBoxNazwisko.Text, textBoxemail.Text, textBoxnrtel.Text, textBoxPesel.Text, dataurPacjenta.Text, textBoxulica.Text, textBoxkod.Text);
           
            textBoxImie.Text = "";
            textBoxNazwisko.Text = "";
            textBoxemail.Text = "";
            textBoxnrtel.Text = "";
            textBoxPesel.Text = "";
            textBoxPesel.Text = "";
            dataurPacjenta.Text = "";
            textBoxulica.Text = "";
            textBoxkod.Text = "";




        }

        private void textBoxPesel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();// odwolanie do bazy danych z poziomu przycisku zarejestruj
            pacjenci = db.GetPeople(textBoxNazwisko.Text);// metoda get people dla okna nazawisko, pacjenci=nasza lista
            UpdateBinding(); // do szukania
        }

        private void labelemail_Click(object sender, EventArgs e)
        {

        }

        private void listBoxTest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxkod_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxnrtel_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPacjent_Click(object sender, EventArgs e)
        {
           /* Close();
           // using (kartaZabieg karta = new kartaZabieg()) 
            kartaPacjenta kartaZabieg= new kartaPacjenta())
            {
                kartaZabieg.Show();
                kartaZabieg.ShowDialog();
            }*/
                
                
                
        }

        private void textBoxulica_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pacjent_label_Click(object sender, EventArgs e)
        {

        }
    }
}
