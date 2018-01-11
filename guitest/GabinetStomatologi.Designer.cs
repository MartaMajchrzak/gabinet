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
            this.wyborDaty = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxNowyPacjent = new System.Windows.Forms.GroupBox();
            this.btnszukaj = new System.Windows.Forms.Button();
            this.listBoxPacjent = new System.Windows.Forms.ListBox();
            this.buttonzarejestruj = new System.Windows.Forms.Button();
            this.groupBoxDanekont = new System.Windows.Forms.GroupBox();
            this.adreskoreslbl = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.labelnrtel = new System.Windows.Forms.Label();
            this.textBoxnrtel = new System.Windows.Forms.TextBox();
            this.textBoxadreskores = new System.Windows.Forms.TextBox();
            this.labelPesel = new System.Windows.Forms.Label();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.labelDataur = new System.Windows.Forms.Label();
            this.dataurPacjenta = new System.Windows.Forms.DateTimePicker();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelImię = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.buttonPacjent = new System.Windows.Forms.Button();
            this.buttonszukaj = new System.Windows.Forms.Button();
            this.buttonNowypacjent = new System.Windows.Forms.Button();
            this.nowyPacjent_label = new System.Windows.Forms.Label();
            this.szukajPacjenta_label = new System.Windows.Forms.Label();
            this.pacjent_label = new System.Windows.Forms.Label();
            this.groupBoxNowyPacjent.SuspendLayout();
            this.groupBoxDanekont.SuspendLayout();
            this.SuspendLayout();
            // 
            // wyborDaty
            // 
            this.wyborDaty.CalendarMonthBackground = System.Drawing.Color.Lavender;
            this.wyborDaty.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.wyborDaty.Location = new System.Drawing.Point(505, 123);
            this.wyborDaty.Name = "wyborDaty";
            this.wyborDaty.Size = new System.Drawing.Size(85, 20);
            this.wyborDaty.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(468, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = " data";
            // 
            // groupBoxNowyPacjent
            // 
            this.groupBoxNowyPacjent.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBoxNowyPacjent.Controls.Add(this.btnszukaj);
            this.groupBoxNowyPacjent.Controls.Add(this.listBoxPacjent);
            this.groupBoxNowyPacjent.Controls.Add(this.buttonzarejestruj);
            this.groupBoxNowyPacjent.Controls.Add(this.groupBoxDanekont);
            this.groupBoxNowyPacjent.Controls.Add(this.labelPesel);
            this.groupBoxNowyPacjent.Controls.Add(this.textBoxPesel);
            this.groupBoxNowyPacjent.Controls.Add(this.labelDataur);
            this.groupBoxNowyPacjent.Controls.Add(this.dataurPacjenta);
            this.groupBoxNowyPacjent.Controls.Add(this.labelNazwisko);
            this.groupBoxNowyPacjent.Controls.Add(this.labelImię);
            this.groupBoxNowyPacjent.Controls.Add(this.textBoxNazwisko);
            this.groupBoxNowyPacjent.Controls.Add(this.textBoxImie);
            this.groupBoxNowyPacjent.Location = new System.Drawing.Point(12, 149);
            this.groupBoxNowyPacjent.Name = "groupBoxNowyPacjent";
            this.groupBoxNowyPacjent.Size = new System.Drawing.Size(590, 325);
            this.groupBoxNowyPacjent.TabIndex = 7;
            this.groupBoxNowyPacjent.TabStop = false;
            this.groupBoxNowyPacjent.Text = "Nowy pacjent";
            this.groupBoxNowyPacjent.Enter += new System.EventHandler(this.groupBoxNowyPacjent_Enter);
            // 
            // btnszukaj
            // 
            this.btnszukaj.Location = new System.Drawing.Point(418, 251);
            this.btnszukaj.Name = "btnszukaj";
            this.btnszukaj.Size = new System.Drawing.Size(75, 23);
            this.btnszukaj.TabIndex = 14;
            this.btnszukaj.Text = "szukaj";
            this.btnszukaj.UseVisualStyleBackColor = true;
            this.btnszukaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxPacjent
            // 
            this.listBoxPacjent.FormattingEnabled = true;
            this.listBoxPacjent.Location = new System.Drawing.Point(315, 129);
            this.listBoxPacjent.Name = "listBoxPacjent";
            this.listBoxPacjent.Size = new System.Drawing.Size(178, 108);
            this.listBoxPacjent.TabIndex = 13;
            this.listBoxPacjent.SelectedIndexChanged += new System.EventHandler(this.listBoxTest_SelectedIndexChanged);
            // 
            // buttonzarejestruj
            // 
            this.buttonzarejestruj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonzarejestruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonzarejestruj.Location = new System.Drawing.Point(130, 271);
            this.buttonzarejestruj.Name = "buttonzarejestruj";
            this.buttonzarejestruj.Size = new System.Drawing.Size(98, 35);
            this.buttonzarejestruj.TabIndex = 9;
            this.buttonzarejestruj.Text = "zarejestruj";
            this.buttonzarejestruj.UseVisualStyleBackColor = true;
            this.buttonzarejestruj.Click += new System.EventHandler(this.buttonzarejestruj_Click);
            // 
            // groupBoxDanekont
            // 
            this.groupBoxDanekont.Controls.Add(this.adreskoreslbl);
            this.groupBoxDanekont.Controls.Add(this.labelemail);
            this.groupBoxDanekont.Controls.Add(this.textBoxemail);
            this.groupBoxDanekont.Controls.Add(this.labelnrtel);
            this.groupBoxDanekont.Controls.Add(this.textBoxnrtel);
            this.groupBoxDanekont.Controls.Add(this.textBoxadreskores);
            this.groupBoxDanekont.Location = new System.Drawing.Point(16, 100);
            this.groupBoxDanekont.Name = "groupBoxDanekont";
            this.groupBoxDanekont.Size = new System.Drawing.Size(267, 137);
            this.groupBoxDanekont.TabIndex = 8;
            this.groupBoxDanekont.TabStop = false;
            this.groupBoxDanekont.Text = "Dane kontaktowe";
            // 
            // adreskoreslbl
            // 
            this.adreskoreslbl.AutoSize = true;
            this.adreskoreslbl.Location = new System.Drawing.Point(13, 35);
            this.adreskoreslbl.Name = "adreskoreslbl";
            this.adreskoreslbl.Size = new System.Drawing.Size(122, 13);
            this.adreskoreslbl.TabIndex = 10;
            this.adreskoreslbl.Text = "adres korespondencyjny";
            this.adreskoreslbl.Click += new System.EventHandler(this.adreskoreslbl_Click);
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Location = new System.Drawing.Point(20, 107);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(60, 13);
            this.labelemail.TabIndex = 9;
            this.labelemail.Text = "adres email";
            this.labelemail.Click += new System.EventHandler(this.labelemail_Click);
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(141, 100);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(120, 20);
            this.textBoxemail.TabIndex = 8;
            this.textBoxemail.TextChanged += new System.EventHandler(this.textBoxemail_TextChanged);
            // 
            // labelnrtel
            // 
            this.labelnrtel.AutoSize = true;
            this.labelnrtel.Location = new System.Drawing.Point(13, 70);
            this.labelnrtel.Name = "labelnrtel";
            this.labelnrtel.Size = new System.Drawing.Size(77, 13);
            this.labelnrtel.TabIndex = 7;
            this.labelnrtel.Text = "numer telefonu";
            // 
            // textBoxnrtel
            // 
            this.textBoxnrtel.Location = new System.Drawing.Point(141, 67);
            this.textBoxnrtel.Name = "textBoxnrtel";
            this.textBoxnrtel.Size = new System.Drawing.Size(120, 20);
            this.textBoxnrtel.TabIndex = 6;
            this.textBoxnrtel.TextChanged += new System.EventHandler(this.textBoxnrtel_TextChanged);
            // 
            // textBoxadreskores
            // 
            this.textBoxadreskores.Location = new System.Drawing.Point(141, 35);
            this.textBoxadreskores.Name = "textBoxadreskores";
            this.textBoxadreskores.Size = new System.Drawing.Size(120, 20);
            this.textBoxadreskores.TabIndex = 4;
            this.textBoxadreskores.TextChanged += new System.EventHandler(this.textBoxulica_TextChanged);
            // 
            // labelPesel
            // 
            this.labelPesel.AutoSize = true;
            this.labelPesel.Location = new System.Drawing.Point(297, 60);
            this.labelPesel.Name = "labelPesel";
            this.labelPesel.Size = new System.Drawing.Size(33, 13);
            this.labelPesel.TabIndex = 7;
            this.labelPesel.Text = "Pesel";
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Location = new System.Drawing.Point(393, 57);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesel.TabIndex = 6;
            this.textBoxPesel.TextChanged += new System.EventHandler(this.textBoxPesel_TextChanged);
            // 
            // labelDataur
            // 
            this.labelDataur.AutoSize = true;
            this.labelDataur.Location = new System.Drawing.Point(297, 38);
            this.labelDataur.Name = "labelDataur";
            this.labelDataur.Size = new System.Drawing.Size(79, 13);
            this.labelDataur.TabIndex = 5;
            this.labelDataur.Text = "Data urodzenia";
            // 
            // dataurPacjenta
            // 
            this.dataurPacjenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataurPacjenta.Location = new System.Drawing.Point(393, 31);
            this.dataurPacjenta.Name = "dataurPacjenta";
            this.dataurPacjenta.Size = new System.Drawing.Size(100, 20);
            this.dataurPacjenta.TabIndex = 4;
            this.dataurPacjenta.ValueChanged += new System.EventHandler(this.dataurPacjenta_ValueChanged);
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(14, 66);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(53, 13);
            this.labelNazwisko.TabIndex = 3;
            this.labelNazwisko.Text = "Nazwisko";
            // 
            // labelImię
            // 
            this.labelImię.AutoSize = true;
            this.labelImię.Location = new System.Drawing.Point(14, 40);
            this.labelImię.Name = "labelImię";
            this.labelImię.Size = new System.Drawing.Size(26, 13);
            this.labelImię.TabIndex = 2;
            this.labelImię.Text = "Imię";
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(73, 59);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(79, 20);
            this.textBoxNazwisko.TabIndex = 1;
            this.textBoxNazwisko.TextChanged += new System.EventHandler(this.textBoxNazwisko_TextChanged);
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(73, 34);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(79, 20);
            this.textBoxImie.TabIndex = 0;
            this.textBoxImie.TextChanged += new System.EventHandler(this.textBoxImie_TextChanged);
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
            this.buttonszukaj.Click += new System.EventHandler(this.buttonszukaj_Click_1);
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
            // szukajPacjenta_label
            // 
            this.szukajPacjenta_label.AutoSize = true;
            this.szukajPacjenta_label.Location = new System.Drawing.Point(269, 89);
            this.szukajPacjenta_label.Name = "szukajPacjenta_label";
            this.szukajPacjenta_label.Size = new System.Drawing.Size(84, 13);
            this.szukajPacjenta_label.TabIndex = 9;
            this.szukajPacjenta_label.Text = "Szukaj Pacjenta";
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
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(614, 486);
            this.Controls.Add(this.pacjent_label);
            this.Controls.Add(this.szukajPacjenta_label);
            this.Controls.Add(this.nowyPacjent_label);
            this.Controls.Add(this.groupBoxNowyPacjent);
            this.Controls.Add(this.buttonPacjent);
            this.Controls.Add(this.buttonszukaj);
            this.Controls.Add(this.buttonNowypacjent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wyborDaty);
            this.Name = "GUI";
            this.Text = "Gabinet stomatologiczny ";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.groupBoxNowyPacjent.ResumeLayout(false);
            this.groupBoxNowyPacjent.PerformLayout();
            this.groupBoxDanekont.ResumeLayout(false);
            this.groupBoxDanekont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker wyborDaty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNowypacjent; // podpiac do karty
        //nowy pacjent 
        private System.Windows.Forms.Button buttonszukaj;
        //stworz nowa karte
        private System.Windows.Forms.Button buttonPacjent;
        // stworz nowa karte
        private System.Windows.Forms.GroupBox groupBoxNowyPacjent;
        //mozliiwe tylko po wcisnieciu zarejestruj ,potem idzie do karty umow
        private System.Windows.Forms.Button buttonzarejestruj;
        //tablice nowy pacjent wysyla do bazy danych,niemozliwe gdy nei wprowadzi sie wszystkich
        //pol
        private System.Windows.Forms.GroupBox groupBoxDanekont;
        //zawiera textBoxnrtel, textBoxkod, listmiast, textBoxulica,textBox nrtel, textBoxemail
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox textBoxemail;
        //wez string zapisz do tbalicy
        private System.Windows.Forms.Label labelnrtel;
        private System.Windows.Forms.TextBox textBoxnrtel;
        private System.Windows.Forms.TextBox textBoxadreskores;
        //zamien string na ciag int, ustaw format np. 57-300, nie pozwol na blad niech sie samo pisz
        //kolejne miejsce w tablicy
        private System.Windows.Forms.Label labelPesel;
        private System.Windows.Forms.TextBox textBoxPesel;
        // zamien ciag string na ciag int, zrob warunek dla dlugosci pola, zapisz do kolejnego pola
        //tablicy nowy pacjent
        private System.Windows.Forms.Label labelDataur;
        private System.Windows.Forms.DateTimePicker dataurPacjenta;
        // jaki typ danych przechowuje wyjscie z data ur? wez i zapisz do tablicy nowy pacjent
        // zrob warunek/ ostrzezenie jesli pacjent jest za mlody lub za stary
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelImię;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        // nazwisko zapisuje jako string  nazwisko, zapis do tablicy
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.ListBox listBoxPacjent;
        private System.Windows.Forms.Button btnszukaj;
        private System.Windows.Forms.Label nowyPacjent_label;
        private System.Windows.Forms.Label szukajPacjenta_label;
        private System.Windows.Forms.Label pacjent_label;
        private System.Windows.Forms.Label adreskoreslbl;
        // bierze wartosc string i zapisuje jako imie , przechowuje je w tablicy nowy pacjent
    }
}

