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
    public partial class kartaZabieg : Form
    {
  
      
        public kartaZabieg()
        {
            InitializeComponent();
        }

        
        private void dodawanie_zab(object sender, EventArgs e)
        {
            string c;
            
            Button button = sender as Button;
            c = "Dodano "+button.Text +" ząb";
            if(button.BackColor == Color.Red)
            {
                button.BackColor = Color.GhostWhite; 
            }
            else
            {
                button.BackColor = Color.Red; 
            }
            

            MessageBox.Show(c.ToString());
        }
                  
        private void button2_Click(object sender, EventArgs e)
        {
            Close();

            /*
            using (Form2 form2 = new Form2())
            {
                //form2.Show(); // opcja otwiera się drugie okienko, dwa równolegle 
                form2.ShowDialog();
            }*/
        }

       
        private void button1_Click(object sender, EventArgs e)
        { // zapisuje dane z karty pacjenta  do bazy danych 
          // DataAccess dl = new DataAccess(); //dl-daneleczenia
          //DataAccess dl = new DataAccess();
            /*dl.ZapiszPacjenta(textBoxImie.Text, textBoxNazwisko.Text, textBoxemail.Text, textBoxnrtel.Text, textBoxPesel.Text, dataurPacjenta.Text, textBoxulica.Text, textBoxkod.Text);

            textBoxImie.Text = "";
            textBoxNazwisko.Text = "";
            textBoxemail.Text = "";
            textBoxnrtel.Text = "";
            textBoxPesel.Text = "";
            textBoxPesel.Text = "";
            dataurPacjenta.Text = "";
            textBoxulica.Text = "";
            textBoxkod.Text = "";*/

            //magia 
            MessageBox.Show("Zapisano pacjenta");
            Application.Exit();
        }
    }
}




