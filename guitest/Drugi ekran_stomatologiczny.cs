using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        private void dodawanie_zab(object sender, EventArgs e)
        {
            string c;

            Button button = sender as Button;
            c = "Dodano " + button.Text + " ząb";
            if (button.BackColor == Color.Red)
            {
                button.BackColor = Color.GhostWhite;
            }
            else
            {
                button.BackColor = Color.Red;
            }


            //MessageBox.Show(c.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guitest.GUI nowypacjent = new guitest.GUI();
            nowypacjent.Show();
            Visible = false;


        }


        private void button1_Click(object sender, EventArgs e)
        {
            //magia 
            MessageBox.Show("Czy chcesz zapisać pacjenta?");
           // MessageBoxButtons.YesNoCancel);
           // MessageBoxIcon.Warning);
            //MessageBox.Show("Zapisano pacjenta");
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




