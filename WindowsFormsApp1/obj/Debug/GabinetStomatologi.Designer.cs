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
            this.label2 = new System.Windows.Forms.Label();
            this.labelnrkarty = new System.Windows.Forms.Label();
            this.buttonumow = new System.Windows.Forms.Button();
            this.buttonzarejestruj = new System.Windows.Forms.Button();
            this.groupBoxDanekont = new System.Windows.Forms.GroupBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.labelnrtel = new System.Windows.Forms.Label();
            this.textBoxnrtel = new System.Windows.Forms.TextBox();
            this.labelulica = new System.Windows.Forms.Label();
            this.textBoxulica = new System.Windows.Forms.TextBox();
            this.labelkodmiasto = new System.Windows.Forms.Label();
            this.listmiasto = new System.Windows.Forms.ListBox();
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
            this.listBoxTest = new System.Windows.Forms.ListBox();
            this.btnszukaj = new System.Windows.Forms.Button();
            this.groupBoxNowyPacjent.SuspendLayout();
            this.groupBoxDanekont.SuspendLayout();
            this.SuspendLayout();
            // 
            // wyborDaty
            // 
            this.wyborDaty.Location = new System.Drawing.Point(262, 89);
            this.wyborDaty.Name = "wyborDaty";
            this.wyborDaty.Size = new System.Drawing.Size(200, 20);
            this.wyborDaty.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Office Preview Font", 8.25F);
            this.label1.Location = new System.Drawing.Point(225, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = " data";
            // 
            // groupBoxNowyPacjent
            // 
            this.groupBoxNowyPacjent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBoxNowyPacjent.Controls.Add(this.btnszukaj);
            this.groupBoxNowyPacjent.Controls.Add(this.listBoxTest);
            this.groupBoxNowyPacjent.Controls.Add(this.label2);
            this.groupBoxNowyPacjent.Controls.Add(this.labelnrkarty);
            this.groupBoxNowyPacjent.Controls.Add(this.buttonumow);
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
            this.groupBoxNowyPacjent.Location = new System.Drawing.Point(12, 115);
            this.groupBoxNowyPacjent.Name = "groupBoxNowyPacjent";
            this.groupBoxNowyPacjent.Size = new System.Drawing.Size(469, 239);
            this.groupBoxNowyPacjent.TabIndex = 7;
            this.groupBoxNowyPacjent.TabStop = false;
            this.groupBoxNowyPacjent.Text = "Nowy pacjent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "numer karty pacjenta";
            // 
            // labelnrkarty
            // 
            this.labelnrkarty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelnrkarty.Location = new System.Drawing.Point(385, 44);
            this.labelnrkarty.Name = "labelnrkarty";
            this.labelnrkarty.Size = new System.Drawing.Size(49, 20);
            this.labelnrkarty.TabIndex = 11;
            // 
            // buttonumow
            // 
            this.buttonumow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonumow.Location = new System.Drawing.Point(283, 138);
            this.buttonumow.Name = "buttonumow";
            this.buttonumow.Size = new System.Drawing.Size(98, 35);
            this.buttonumow.TabIndex = 10;
            this.buttonumow.Text = "umów na wizytę";
            this.buttonumow.UseVisualStyleBackColor = true;
            // 
            // buttonzarejestruj
            // 
            this.buttonzarejestruj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonzarejestruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonzarejestruj.Location = new System.Drawing.Point(283, 82);
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
            this.groupBoxDanekont.Controls.Add(this.listmiasto);
            this.groupBoxDanekont.Controls.Add(this.textBoxkod);
            this.groupBoxDanekont.Location = new System.Drawing.Point(14, 70);
            this.groupBoxDanekont.Name = "groupBoxDanekont";
            this.groupBoxDanekont.Size = new System.Drawing.Size(218, 143);
            this.groupBoxDanekont.TabIndex = 8;
            this.groupBoxDanekont.TabStop = false;
            this.groupBoxDanekont.Text = "Dane kontaktowe";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Location = new System.Drawing.Point(9, 101);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(60, 13);
            this.labelemail.TabIndex = 9;
            this.labelemail.Text = "adres email";
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(92, 94);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(120, 20);
            this.textBoxemail.TabIndex = 8;
            // 
            // labelnrtel
            // 
            this.labelnrtel.AutoSize = true;
            this.labelnrtel.Location = new System.Drawing.Point(9, 75);
            this.labelnrtel.Name = "labelnrtel";
            this.labelnrtel.Size = new System.Drawing.Size(77, 13);
            this.labelnrtel.TabIndex = 7;
            this.labelnrtel.Text = "numer telefonu";
            // 
            // textBoxnrtel
            // 
            this.textBoxnrtel.Location = new System.Drawing.Point(92, 68);
            this.textBoxnrtel.Name = "textBoxnrtel";
            this.textBoxnrtel.Size = new System.Drawing.Size(120, 20);
            this.textBoxnrtel.TabIndex = 6;
            // 
            // labelulica
            // 
            this.labelulica.AutoSize = true;
            this.labelulica.Location = new System.Drawing.Point(9, 49);
            this.labelulica.Name = "labelulica";
            this.labelulica.Size = new System.Drawing.Size(32, 13);
            this.labelulica.TabIndex = 5;
            this.labelulica.Text = "ulica ";
            // 
            // textBoxulica
            // 
            this.textBoxulica.Location = new System.Drawing.Point(75, 42);
            this.textBoxulica.Name = "textBoxulica";
            this.textBoxulica.Size = new System.Drawing.Size(137, 20);
            this.textBoxulica.TabIndex = 4;
            // 
            // labelkodmiasto
            // 
            this.labelkodmiasto.AutoSize = true;
            this.labelkodmiasto.Location = new System.Drawing.Point(9, 23);
            this.labelkodmiasto.Name = "labelkodmiasto";
            this.labelkodmiasto.Size = new System.Drawing.Size(63, 13);
            this.labelkodmiasto.TabIndex = 3;
            this.labelkodmiasto.Text = "kod i miasto";
            // 
            // listmiasto
            // 
            this.listmiasto.FormattingEnabled = true;
            this.listmiasto.Location = new System.Drawing.Point(125, 19);
            this.listmiasto.Name = "listmiasto";
            this.listmiasto.Size = new System.Drawing.Size(87, 17);
            this.listmiasto.TabIndex = 2;
            // 
            // textBoxkod
            // 
            this.textBoxkod.Location = new System.Drawing.Point(75, 16);
            this.textBoxkod.Name = "textBoxkod";
            this.textBoxkod.Size = new System.Drawing.Size(44, 20);
            this.textBoxkod.TabIndex = 1;
            // 
            // labelPesel
            // 
            this.labelPesel.AutoSize = true;
            this.labelPesel.Location = new System.Drawing.Point(155, 51);
            this.labelPesel.Name = "labelPesel";
            this.labelPesel.Size = new System.Drawing.Size(33, 13);
            this.labelPesel.TabIndex = 7;
            this.labelPesel.Text = "Pesel";
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Location = new System.Drawing.Point(240, 44);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesel.TabIndex = 6;
            this.textBoxPesel.TextChanged += new System.EventHandler(this.textBoxPesel_TextChanged);
            // 
            // labelDataur
            // 
            this.labelDataur.AutoSize = true;
            this.labelDataur.Location = new System.Drawing.Point(155, 23);
            this.labelDataur.Name = "labelDataur";
            this.labelDataur.Size = new System.Drawing.Size(79, 13);
            this.labelDataur.TabIndex = 5;
            this.labelDataur.Text = "Data urodzenia";
            // 
            // dataurPacjenta
            // 
            this.dataurPacjenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataurPacjenta.Location = new System.Drawing.Point(240, 16);
            this.dataurPacjenta.Name = "dataurPacjenta";
            this.dataurPacjenta.Size = new System.Drawing.Size(100, 20);
            this.dataurPacjenta.TabIndex = 4;
            this.dataurPacjenta.ValueChanged += new System.EventHandler(this.dataurPacjenta_ValueChanged);
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(11, 51);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(53, 13);
            this.labelNazwisko.TabIndex = 3;
            this.labelNazwisko.Text = "Nazwisko";
            // 
            // labelImię
            // 
            this.labelImię.AutoSize = true;
            this.labelImię.Location = new System.Drawing.Point(11, 25);
            this.labelImię.Name = "labelImię";
            this.labelImię.Size = new System.Drawing.Size(26, 13);
            this.labelImię.TabIndex = 2;
            this.labelImię.Text = "Imię";
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(70, 44);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(79, 20);
            this.textBoxNazwisko.TabIndex = 1;
            this.textBoxNazwisko.TextChanged += new System.EventHandler(this.textBoxNazwisko_TextChanged);
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(70, 19);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(79, 20);
            this.textBoxImie.TabIndex = 0;
            this.textBoxImie.TextChanged += new System.EventHandler(this.textBoxImie_TextChanged);
            // 
            // buttonTerminarz
            // 
            this.buttonTerminarz.BackgroundImage = global::guitest.Properties.Resources.calendar;
            this.buttonTerminarz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTerminarz.Location = new System.Drawing.Point(382, 12);
            this.buttonTerminarz.Name = "buttonTerminarz";
            this.buttonTerminarz.Size = new System.Drawing.Size(64, 57);
            this.buttonTerminarz.TabIndex = 6;
            this.buttonTerminarz.UseVisualStyleBackColor = true;
            // 
            // buttonPacjent
            // 
            this.buttonPacjent.BackgroundImage = global::guitest.Properties.Resources.pacjent;
            this.buttonPacjent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPacjent.Location = new System.Drawing.Point(295, 12);
            this.buttonPacjent.Name = "buttonPacjent";
            this.buttonPacjent.Size = new System.Drawing.Size(64, 57);
            this.buttonPacjent.TabIndex = 5;
            this.buttonPacjent.UseVisualStyleBackColor = true;
            // 
            // buttonUmowpacjenta
            // 
            this.buttonUmowpacjenta.BackgroundImage = global::guitest.Properties.Resources.calendar_add_512;
            this.buttonUmowpacjenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUmowpacjenta.Location = new System.Drawing.Point(208, 12);
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
            this.buttonszukaj.Location = new System.Drawing.Point(121, 12);
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
            this.buttonNowypacjent.Location = new System.Drawing.Point(34, 12);
            this.buttonNowypacjent.Name = "buttonNowypacjent";
            this.buttonNowypacjent.Size = new System.Drawing.Size(64, 57);
            this.buttonNowypacjent.TabIndex = 2;
            this.buttonNowypacjent.UseVisualStyleBackColor = true;
            this.buttonNowypacjent.Click += new System.EventHandler(this.buttonNowypacjent_Click);
            // 
            // listBoxTest
            // 
            this.listBoxTest.FormattingEnabled = true;
            this.listBoxTest.Location = new System.Drawing.Point(260, 201);
            this.listBoxTest.Name = "listBoxTest";
            this.listBoxTest.Size = new System.Drawing.Size(189, 17);
            this.listBoxTest.TabIndex = 13;
            // 
            // btnszukaj
            // 
            this.btnszukaj.Location = new System.Drawing.Point(385, 172);
            this.btnszukaj.Name = "btnszukaj";
            this.btnszukaj.Size = new System.Drawing.Size(75, 23);
            this.btnszukaj.TabIndex = 14;
            this.btnszukaj.Text = "szukaj";
            this.btnszukaj.UseVisualStyleBackColor = true;
            this.btnszukaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(493, 382);
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
        //tutaj beda: textbox imie, textbox nazwisko, listmiasto,texboxPesel,
        //textboxemail textboxulica textboxnrtel, label nrkarty, buttonzerejestruj, button umow
        //datetimepicker data ur pacjenta, group box dane kont. tu tworze tablice nowy pacjent
        // string [] NowyPacjent= {"imie', 'nazwisko, ;nr pesel,' data ur, kod miasto, 
        //ulica nr domu, nr tel, email}
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelnrkarty;
        //po pobraniu bazy danych pacjentow bierze najwiekszy indeks n pacjenta i generuje nr n+1
        //mozna wprowadzic jakis format np. nrpacjenta/koncowkapeselu, zapis do tablicy
        private System.Windows.Forms.Button buttonumow;
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
        private System.Windows.Forms.ListBox listmiasto;
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
        private System.Windows.Forms.ListBox listBoxTest;
        private System.Windows.Forms.Button btnszukaj;
        // bierze wartosc string i zapisuje jako imie , przechowuje je w tablicy nowy pacjent
    }
}

