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
            this.labelemail = new System.Windows.Forms.Label();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.labelnrtel = new System.Windows.Forms.Label();
            this.textBoxnrtel = new System.Windows.Forms.TextBox();
            this.labelulica = new System.Windows.Forms.Label();
            this.textBoxulica = new System.Windows.Forms.TextBox();
            this.labelkodmiasto = new System.Windows.Forms.Label();
            this.textBoxkod = new System.Windows.Forms.TextBox();
            this.labelPesel = new System.Windows.Forms.Label();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.labelDataur = new System.Windows.Forms.Label();
            this.dataurPacjenta = new System.Windows.Forms.DateTimePicker();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelImię = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.buttonTerminarz = new System.Windows.Forms.Button();
            this.buttonPacjent = new System.Windows.Forms.Button();
            this.buttonUmowpacjenta = new System.Windows.Forms.Button();
            this.buttonszukaj = new System.Windows.Forms.Button();
            this.buttonNowypacjent = new System.Windows.Forms.Button();
            this.nowyPacjent_label = new System.Windows.Forms.Label();
            this.szukajPacjenta_label = new System.Windows.Forms.Label();
            this.dodajWizyte_label = new System.Windows.Forms.Label();
            this.pacjent_label = new System.Windows.Forms.Label();
            this.terminarz_label = new System.Windows.Forms.Label();
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
            this.groupBoxNowyPacjent.BackColor = System.Drawing.Color.PaleGreen;
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
            this.groupBoxNowyPacjent.Location = new System.Drawing.Point(12, 162);
            this.groupBoxNowyPacjent.Name = "groupBoxNowyPacjent";
            this.groupBoxNowyPacjent.Size = new System.Drawing.Size(590, 312);
            this.groupBoxNowyPacjent.TabIndex = 7;
            this.groupBoxNowyPacjent.TabStop = false;
            this.groupBoxNowyPacjent.Text = "Nowy pacjent";
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
            this.buttonzarejestruj.Location = new System.Drawing.Point(130, 251);
            this.buttonzarejestruj.Name = "buttonzarejestruj";
            this.buttonzarejestruj.Size = new System.Drawing.Size(98, 35);
            this.buttonzarejestruj.TabIndex = 9;
            this.buttonzarejestruj.Text = "zarejestruj";
            this.buttonzarejestruj.UseVisualStyleBackColor = true;
            this.buttonzarejestruj.Click += new System.EventHandler(this.buttonzarejestruj_Click);
            // 
            // groupBoxDanekont
            // 
            this.groupBoxDanekont.Controls.Add(this.labelemail);
            this.groupBoxDanekont.Controls.Add(this.textBoxemail);
            this.groupBoxDanekont.Controls.Add(this.labelnrtel);
            this.groupBoxDanekont.Controls.Add(this.textBoxnrtel);
            this.groupBoxDanekont.Controls.Add(this.labelulica);
            this.groupBoxDanekont.Controls.Add(this.textBoxulica);
            this.groupBoxDanekont.Controls.Add(this.labelkodmiasto);
            this.groupBoxDanekont.Controls.Add(this.textBoxkod);
            this.groupBoxDanekont.Location = new System.Drawing.Point(16, 97);
            this.groupBoxDanekont.Name = "groupBoxDanekont";
            this.groupBoxDanekont.Size = new System.Drawing.Size(218, 143);
            this.groupBoxDanekont.TabIndex = 8;
            this.groupBoxDanekont.TabStop = false;
            this.groupBoxDanekont.Text = "Dane kontaktowe";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Location = new System.Drawing.Point(12, 127);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(60, 13);
            this.labelemail.TabIndex = 9;
            this.labelemail.Text = "adres email";
            this.labelemail.Click += new System.EventHandler(this.labelemail_Click);
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(92, 122);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(120, 20);
            this.textBoxemail.TabIndex = 8;
            // 
            // labelnrtel
            // 
            this.labelnrtel.AutoSize = true;
            this.labelnrtel.Location = new System.Drawing.Point(5, 90);
            this.labelnrtel.Name = "labelnrtel";
            this.labelnrtel.Size = new System.Drawing.Size(77, 13);
            this.labelnrtel.TabIndex = 7;
            this.labelnrtel.Text = "numer telefonu";
            // 
            // textBoxnrtel
            // 
            this.textBoxnrtel.Location = new System.Drawing.Point(92, 90);
            this.textBoxnrtel.Name = "textBoxnrtel";
            this.textBoxnrtel.Size = new System.Drawing.Size(120, 20);
            this.textBoxnrtel.TabIndex = 6;
            this.textBoxnrtel.TextChanged += new System.EventHandler(this.textBoxnrtel_TextChanged);
            // 
            // labelulica
            // 
            this.labelulica.AutoSize = true;
            this.labelulica.Location = new System.Drawing.Point(18, 64);
            this.labelulica.Name = "labelulica";
            this.labelulica.Size = new System.Drawing.Size(32, 13);
            this.labelulica.TabIndex = 5;
            this.labelulica.Text = "ulica ";
            // 
            // textBoxulica
            // 
            this.textBoxulica.Location = new System.Drawing.Point(92, 61);
            this.textBoxulica.Name = "textBoxulica";
            this.textBoxulica.Size = new System.Drawing.Size(120, 20);
            this.textBoxulica.TabIndex = 4;
            this.textBoxulica.TextChanged += new System.EventHandler(this.textBoxulica_TextChanged);
            // 
            // labelkodmiasto
            // 
            this.labelkodmiasto.AutoSize = true;
            this.labelkodmiasto.Location = new System.Drawing.Point(6, 38);
            this.labelkodmiasto.Name = "labelkodmiasto";
            this.labelkodmiasto.Size = new System.Drawing.Size(63, 13);
            this.labelkodmiasto.TabIndex = 3;
            this.labelkodmiasto.Text = "kod i miasto";
            // 
            // textBoxkod
            // 
            this.textBoxkod.Location = new System.Drawing.Point(92, 35);
            this.textBoxkod.Name = "textBoxkod";
            this.textBoxkod.Size = new System.Drawing.Size(120, 20);
            this.textBoxkod.TabIndex = 1;
            this.textBoxkod.TextChanged += new System.EventHandler(this.textBoxkod_TextChanged);
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
            // buttonTerminarz
            // 
            this.buttonTerminarz.BackgroundImage = global::guitest.Properties.Resources.calendar;
            this.buttonTerminarz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTerminarz.Location = new System.Drawing.Point(490, 29);
            this.buttonTerminarz.Name = "buttonTerminarz";
            this.buttonTerminarz.Size = new System.Drawing.Size(64, 57);
            this.buttonTerminarz.TabIndex = 6;
            this.buttonTerminarz.UseVisualStyleBackColor = true;
            // 
            // buttonPacjent
            // 
            this.buttonPacjent.BackgroundImage = global::guitest.Properties.Resources.pacjent;
            this.buttonPacjent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPacjent.Location = new System.Drawing.Point(376, 29);
            this.buttonPacjent.Name = "buttonPacjent";
            this.buttonPacjent.Size = new System.Drawing.Size(64, 57);
            this.buttonPacjent.TabIndex = 5;
            this.buttonPacjent.UseVisualStyleBackColor = true;
            this.buttonPacjent.Click += new System.EventHandler(this.buttonPacjent_Click);
            // 
            // buttonUmowpacjenta
            // 
            this.buttonUmowpacjenta.BackgroundImage = global::guitest.Properties.Resources.calendar_add_512;
            this.buttonUmowpacjenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUmowpacjenta.Location = new System.Drawing.Point(262, 29);
            this.buttonUmowpacjenta.Name = "buttonUmowpacjenta";
            this.buttonUmowpacjenta.Size = new System.Drawing.Size(64, 57);
            this.buttonUmowpacjenta.TabIndex = 4;
            this.buttonUmowpacjenta.UseVisualStyleBackColor = true;
            // 
            // buttonszukaj
            // 
            this.buttonszukaj.BackgroundImage = global::guitest.Properties.Resources.lupka;
            this.buttonszukaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonszukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonszukaj.Location = new System.Drawing.Point(148, 29);
            this.buttonszukaj.Name = "buttonszukaj";
            this.buttonszukaj.Size = new System.Drawing.Size(64, 57);
            this.buttonszukaj.TabIndex = 3;
            this.buttonszukaj.UseVisualStyleBackColor = true;
            // 
            // buttonNowypacjent
            // 
            this.buttonNowypacjent.BackgroundImage = global::guitest.Properties.Resources.plus2;
            this.buttonNowypacjent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNowypacjent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNowypacjent.Location = new System.Drawing.Point(34, 29);
            this.buttonNowypacjent.Name = "buttonNowypacjent";
            this.buttonNowypacjent.Size = new System.Drawing.Size(64, 57);
            this.buttonNowypacjent.TabIndex = 2;
            this.buttonNowypacjent.UseVisualStyleBackColor = true;
            this.buttonNowypacjent.Click += new System.EventHandler(this.buttonNowypacjent_Click);
            // 
            // nowyPacjent_label
            // 
            this.nowyPacjent_label.AutoSize = true;
            this.nowyPacjent_label.Location = new System.Drawing.Point(33, 89);
            this.nowyPacjent_label.Name = "nowyPacjent_label";
            this.nowyPacjent_label.Size = new System.Drawing.Size(73, 13);
            this.nowyPacjent_label.TabIndex = 8;
            this.nowyPacjent_label.Text = "Nowy Pacjent";
            this.nowyPacjent_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // szukajPacjenta_label
            // 
            this.szukajPacjenta_label.AutoSize = true;
            this.szukajPacjenta_label.Location = new System.Drawing.Point(139, 89);
            this.szukajPacjenta_label.Name = "szukajPacjenta_label";
            this.szukajPacjenta_label.Size = new System.Drawing.Size(84, 13);
            this.szukajPacjenta_label.TabIndex = 9;
            this.szukajPacjenta_label.Text = "Szukaj Pacjenta";
            // 
            // dodajWizyte_label
            // 
            this.dodajWizyte_label.AutoSize = true;
            this.dodajWizyte_label.Location = new System.Drawing.Point(261, 89);
            this.dodajWizyte_label.Name = "dodajWizyte_label";
            this.dodajWizyte_label.Size = new System.Drawing.Size(65, 13);
            this.dodajWizyte_label.TabIndex = 10;
            this.dodajWizyte_label.Text = "dodaj wizytę";
            // 
            // pacjent_label
            // 
            this.pacjent_label.AutoSize = true;
            this.pacjent_label.Location = new System.Drawing.Point(388, 89);
            this.pacjent_label.Name = "pacjent_label";
            this.pacjent_label.Size = new System.Drawing.Size(42, 13);
            this.pacjent_label.TabIndex = 11;
            this.pacjent_label.Text = "pacjent";
            this.pacjent_label.Click += new System.EventHandler(this.pacjent_label_Click);
            // 
            // terminarz_label
            // 
            this.terminarz_label.AutoSize = true;
            this.terminarz_label.Location = new System.Drawing.Point(499, 89);
            this.terminarz_label.Name = "terminarz_label";
            this.terminarz_label.Size = new System.Drawing.Size(49, 13);
            this.terminarz_label.TabIndex = 12;
            this.terminarz_label.Text = "terminarz";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(614, 486);
            this.Controls.Add(this.terminarz_label);
            this.Controls.Add(this.pacjent_label);
            this.Controls.Add(this.dodajWizyte_label);
            this.Controls.Add(this.szukajPacjenta_label);
            this.Controls.Add(this.nowyPacjent_label);
            this.Controls.Add(this.groupBoxNowyPacjent);
            this.Controls.Add(this.buttonTerminarz);
            this.Controls.Add(this.buttonPacjent);
            this.Controls.Add(this.buttonUmowpacjenta);
            this.Controls.Add(this.buttonszukaj);
            this.Controls.Add(this.buttonNowypacjent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wyborDaty);
            this.Name = "GUI";
            this.Text = "Gabinet stomatologiczny ";
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
        private System.Windows.Forms.Button buttonUmowpacjenta;
        //stworz nowa karte
        private System.Windows.Forms.Button buttonPacjent;
        //wyswietla informacje o pacjencie
        private System.Windows.Forms.Button buttonTerminarz;
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
        //zamien string na int, okresl dlugosc wprowazonych cyfr, nie pozwol by wpisano za duzo
        //zapisz do tablicy
        private System.Windows.Forms.Label labelulica;
        private System.Windows.Forms.TextBox textBoxulica;
        // wez string zapisz do tablicy
        private System.Windows.Forms.Label labelkodmiasto;
        // wybierz z listy, co jest wyjsciem pobierz liste miast z bazy danych
        //przypisz wartosci liczbowe stringom nazwom iast, zapisz w tablicy
        private System.Windows.Forms.TextBox textBoxkod;
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
        private System.Windows.Forms.Label dodajWizyte_label;
        private System.Windows.Forms.Label pacjent_label;
        private System.Windows.Forms.Label terminarz_label;
        // bierze wartosc string i zapisuje jako imie , przechowuje je w tablicy nowy pacjent
    }
}

