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

        private void buttonNowypacjent_Click(object sender, EventArgs e) // przycisk nowy pacjent otwiera okno rej
        {
            GUI nowyPacjent = new GUI();
            nowyPacjent.Show();
            Visible = false; 
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
            db.ZarejestrujPacjenta(textBoxImie.Text, textBoxNazwisko.Text, textBoxemail.Text, textBoxnrtel.Text, textBoxPesel.Text, dataurPacjenta.Text, textBoxadreskores.Text);
           
           textBoxImie.Text = "";
            textBoxNazwisko.Text = "";
            textBoxemail.Text = "";
            textBoxnrtel.Text = "";
            
           textBoxPesel.Text = "";
            dataurPacjenta.Text = "";
            textBoxadreskores.Text = "";
           
           /* Pacjent.Imie = textBoxImie.Text;
            Pacjent.Nazwisko = textBoxNazwisko.Text;
            Pacjent.Email = textBoxemail.Text;
            Pacjent.NrTel = textBoxnrtel.Text;
            Pacjent.nrPesel = textBoxPesel.Text;
            Pacjent.dataUrodzenia = dataurPacjenta.Text;
            Pacjent.Ulica = textBoxulica.Text;
            Pacjent.Kod = textBoxkod.Text;*/
            



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

        private void buttonPacjent_Click(object sender, EventArgs e)// przysisk pacjent otwiera karte pacjenta
        {
            kartaZabieg karta = new kartaZabieg();
            karta.Show();
            Visible = false;
           
                
                
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

        private void groupBoxNowyPacjent_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void adreskoreslbl_Click(object sender, EventArgs e)
        {

        }
    }
}
