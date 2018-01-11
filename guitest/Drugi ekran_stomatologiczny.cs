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


            MessageBox.Show(c.ToString());
        }
        //MessageBox.Show(c.ToString());
        //    Button button = new Button(); 
        //    string c;
        //    //cki = Console.ReadKey(); 

        //    //Button button = sender as Button;
        //    c = "Dodano " + button.Text + " ząb";
        //    //control = Console.ReadKey();
        //    if (button.Click += button);
        //    {
        //        button.BackColor = Color.Red;
        //    }
        //    else
        //    {
        //        button.BackColor = Color.GhostWhite;
        //    }
        //}

        //    Button button = sender as Button;
        //    //c = "Dodano " + button.Text + " ząb";
        //    //if (e.Button == MouseButtons.Right) { button.BackColor = Color.Red; }
        //    //if (e.Button == MouseButtons.Left) { button.BackColor = Color.Orange; }
        //    if   == MouseButtons.Left)
        //    {
        //        button.BackColor = Color.Red; 
        //    }
        //   if (MouseButtons.Right)
        //   {
        //        button.BackColor = Color.Red;
        //    }
        //    else
        //    {
        //       button.BackColor = Color.Red;
        //    }
        //    //switch (e.Button)
        //    //{
        //    //    case MouseButtons.Left:
        //    //        button.BackColor = Color.Red;
        //    //        break;
        //    //    case MouseButtons.Right:
        //    //        button.BackColor = Color.Blue;
        //    //        break;
        //    //}
        //            //MessageBox.Show(c.ToString());
        //    }
        // private void dodawanie_zab(object sender, EventArgs e)
        //{
        //string c;


        //    //c = "Dodano " + button.Text + " ząb";
        //if (button.Click != )
        //    {
        //        button.BackColor = Color.Red;
        //    }
        //    else
        //    {
        //        button.BackColor = Color.Blue;
        //    }


        //   // MessageBox.Show(c.ToString());
        //}

        //var button = new Button();
        //button.Text = "my button";

        //this.Controls.Add(button);

        //button.Click += (args, args) =>
        //  {
        //      MessageBox.Show("Some stuff");
        //      Close();
        //  };

        //{
        //    // Get the control the Button control is located in. In this case a GroupBox.
        //    Control Button = button1.Parent;
        //    // Set the text and backcolor of the parent control.
        //    Button.Text = "My Groupbox";
        //    Button.BackColor = Color.Blue;
        //    //// Get the form that the Button control is contained within.
        //    //Form myForm = button1.FindForm();
        //    //// Set the text and color of the form containing the Button.
        //    //myForm.Text = "The Form of My Control";
        //    //myForm.BackColor = Color.Red;
        //}

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            guitest.GUI nowypacjent = new guitest.GUI();
            nowypacjent.Show();
            Visible = false;


        }


        private void button1_Click(object sender, EventArgs e)
        {
            //magia 
            //if (MessageBox.Show("Czy chcesz zapisać pacjenta?", "Okno potwierdzenia", MessageBoxButtons.YesNo) == DialogResult.Yes)

            DialogResult dialogResult = MessageBox.Show("Czy chcesz zapisać pacjenta?", "Okno potwierdzenia", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Zapisano pacjenta");
                Application.Exit();
            }


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




