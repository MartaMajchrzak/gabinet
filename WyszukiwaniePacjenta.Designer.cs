namespace guitest
{
    partial class GUI
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPacjent = new System.Windows.Forms.Button();
            this.buttonNowypacjent = new System.Windows.Forms.Button();
            this.nowyPacjent_label = new System.Windows.Forms.Label();
            this.pacjent_label = new System.Windows.Forms.Label();
            this.szukajPacjenta_label = new System.Windows.Forms.Label();
            this.buttonszukaj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPacjent
            // 
            this.buttonPacjent.BackgroundImage = global::guitest.Properties.Resources.pacjent;
            this.buttonPacjent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPacjent.Location = new System.Drawing.Point(488, 29);
            this.buttonPacjent.Name = "buttonPacjent";
            this.buttonPacjent.Size = new System.Drawing.Size(64, 57);
            this.buttonPacjent.TabIndex = 5;
            this.buttonPacjent.UseVisualStyleBackColor = true;
            this.buttonPacjent.Click += new System.EventHandler(this.buttonPacjent_Click);
            // 
            // buttonNowypacjent
            // 
            this.buttonNowypacjent.BackgroundImage = global::guitest.Properties.Resources.plus2;
            this.buttonNowypacjent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNowypacjent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNowypacjent.Location = new System.Drawing.Point(62, 29);
            this.buttonNowypacjent.Name = "buttonNowypacjent";
            this.buttonNowypacjent.Size = new System.Drawing.Size(64, 57);
            this.buttonNowypacjent.TabIndex = 2;
            this.buttonNowypacjent.UseVisualStyleBackColor = true;
            this.buttonNowypacjent.Click += new System.EventHandler(this.buttonNowypacjent_Click);
            // 
            // nowyPacjent_label
            // 
            this.nowyPacjent_label.AutoSize = true;
            this.nowyPacjent_label.Location = new System.Drawing.Point(61, 89);
            this.nowyPacjent_label.Name = "nowyPacjent_label";
            this.nowyPacjent_label.Size = new System.Drawing.Size(73, 13);
            this.nowyPacjent_label.TabIndex = 8;
            this.nowyPacjent_label.Text = "Nowy Pacjent";
            this.nowyPacjent_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // pacjent_label
            // 
            this.pacjent_label.AutoSize = true;
            this.pacjent_label.Location = new System.Drawing.Point(485, 89);
            this.pacjent_label.Name = "pacjent_label";
            this.pacjent_label.Size = new System.Drawing.Size(77, 13);
            this.pacjent_label.TabIndex = 11;
            this.pacjent_label.Text = "Karta Pacjenta";
            this.pacjent_label.Click += new System.EventHandler(this.pacjent_label_Click);
            // 
            // szukajPacjenta_label
            // 
            this.szukajPacjenta_label.AutoSize = true;
            this.szukajPacjenta_label.Location = new System.Drawing.Point(269, 89);
            this.szukajPacjenta_label.Name = "szukajPacjenta_label";
            this.szukajPacjenta_label.Size = new System.Drawing.Size(84, 13);
            this.szukajPacjenta_label.TabIndex = 9;
            this.szukajPacjenta_label.Text = "Szukaj Pacjenta";
            // 
            // buttonszukaj
            // 
            this.buttonszukaj.BackgroundImage = global::guitest.Properties.Resources.lupka;
            this.buttonszukaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonszukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonszukaj.Location = new System.Drawing.Point(278, 29);
            this.buttonszukaj.Name = "buttonszukaj";
            this.buttonszukaj.Size = new System.Drawing.Size(64, 57);
            this.buttonszukaj.TabIndex = 3;
            this.buttonszukaj.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(44, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(496, 19);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "WYSZUKAJ PACJENTA LUB WIZYTĘ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(36, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 13);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "IMIĘ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(35, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox3.Size = new System.Drawing.Size(91, 13);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "NAZWISKO";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.UseWaitCursor = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(44, 175);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(496, 17);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "PACJENT";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(126, 209);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(414, 17);
            this.textBox5.TabIndex = 16;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.Location = new System.Drawing.Point(126, 246);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(414, 17);
            this.textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox7.Location = new System.Drawing.Point(44, 301);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(496, 17);
            this.textBox7.TabIndex = 18;
            this.textBox7.Text = "WIZYTA";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox8.Location = new System.Drawing.Point(126, 348);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(414, 17);
            this.textBox8.TabIndex = 20;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(36, 348);
            this.textBox9.Name = "textBox9";
            this.textBox9.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox9.Size = new System.Drawing.Size(91, 13);
            this.textBox9.TabIndex = 19;
            this.textBox9.Text = "DATA WIZYTY";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.UseWaitCursor = true;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(614, 486);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pacjent_label);
            this.Controls.Add(this.szukajPacjenta_label);
            this.Controls.Add(this.nowyPacjent_label);
            this.Controls.Add(this.buttonPacjent);
            this.Controls.Add(this.buttonszukaj);
            this.Controls.Add(this.buttonNowypacjent);
            this.Name = "GUI";
            this.Text = "Gabinet stomatologiczny ";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNowypacjent; // podpiac do karty
        //stworz nowa karte
        private System.Windows.Forms.Button buttonPacjent;
        private System.Windows.Forms.Label nowyPacjent_label;
        private System.Windows.Forms.Label pacjent_label;
        private System.Windows.Forms.Label szukajPacjenta_label;
        private System.Windows.Forms.Button buttonszukaj;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        // bierze wartosc string i zapisuje jako imie , przechowuje je w tablicy nowy pacjent
    }
}

