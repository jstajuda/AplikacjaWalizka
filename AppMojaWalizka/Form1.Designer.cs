namespace AppMojaWalizka
{
    partial class FormGlowny
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.parametry = new System.Windows.Forms.GroupBox();
            this.nocleg = new System.Windows.Forms.GroupBox();
            this.noclegNie = new System.Windows.Forms.RadioButton();
            this.noclegTak = new System.Windows.Forms.RadioButton();
            this.rodzajWyjazdu = new System.Windows.Forms.GroupBox();
            this.rodzajWyjazduWakacjeMiasto = new System.Windows.Forms.RadioButton();
            this.rodzajWyjazduWakacjeNadWoda = new System.Windows.Forms.RadioButton();
            this.rodzajWyjazduDoRodziny = new System.Windows.Forms.RadioButton();
            this.rodzajWyjazduWakacjeGory = new System.Windows.Forms.RadioButton();
            this.rodzajWyjazduSluzbowy = new System.Windows.Forms.RadioButton();
            this.poraRoku = new System.Windows.Forms.GroupBox();
            this.poraRokuWiosnaJesien = new System.Windows.Forms.RadioButton();
            this.zima = new System.Windows.Forms.RadioButton();
            this.lato = new System.Windows.Forms.RadioButton();
            this.plec = new System.Windows.Forms.GroupBox();
            this.plecMezczyzna = new System.Windows.Forms.RadioButton();
            this.plecKobieta = new System.Windows.Forms.RadioButton();
            this.akcjeGenerujListe = new System.Windows.Forms.Button();
            this.akcje = new System.Windows.Forms.GroupBox();
            this.akcjeImportujZCSV = new System.Windows.Forms.Button();
            this.akcjeEksportujDoCSV = new System.Windows.Forms.Button();
            this.akcjeDrukuj = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.elementyClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czyWziacDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parametry.SuspendLayout();
            this.nocleg.SuspendLayout();
            this.rodzajWyjazdu.SuspendLayout();
            this.poraRoku.SuspendLayout();
            this.plec.SuspendLayout();
            this.akcje.SuspendLayout();
            this.lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // parametry
            // 
            this.parametry.Controls.Add(this.nocleg);
            this.parametry.Controls.Add(this.rodzajWyjazdu);
            this.parametry.Controls.Add(this.poraRoku);
            this.parametry.Controls.Add(this.plec);
            this.parametry.Location = new System.Drawing.Point(12, 12);
            this.parametry.Name = "parametry";
            this.parametry.Size = new System.Drawing.Size(648, 125);
            this.parametry.TabIndex = 1;
            this.parametry.TabStop = false;
            this.parametry.Text = "Wybór parametrów";
            // 
            // nocleg
            // 
            this.nocleg.Controls.Add(this.noclegNie);
            this.nocleg.Controls.Add(this.noclegTak);
            this.nocleg.Location = new System.Drawing.Point(260, 24);
            this.nocleg.Name = "nocleg";
            this.nocleg.Size = new System.Drawing.Size(107, 92);
            this.nocleg.TabIndex = 3;
            this.nocleg.TabStop = false;
            this.nocleg.Text = "Nocleg";
            // 
            // noclegNie
            // 
            this.noclegNie.AutoSize = true;
            this.noclegNie.Location = new System.Drawing.Point(7, 44);
            this.noclegNie.Name = "noclegNie";
            this.noclegNie.Size = new System.Drawing.Size(41, 17);
            this.noclegNie.TabIndex = 1;
            this.noclegNie.TabStop = true;
            this.noclegNie.Text = "Nie";
            this.noclegNie.UseVisualStyleBackColor = true;
            // 
            // noclegTak
            // 
            this.noclegTak.AutoSize = true;
            this.noclegTak.Location = new System.Drawing.Point(7, 20);
            this.noclegTak.Name = "noclegTak";
            this.noclegTak.Size = new System.Drawing.Size(44, 17);
            this.noclegTak.TabIndex = 0;
            this.noclegTak.TabStop = true;
            this.noclegTak.Text = "Tak";
            this.noclegTak.UseVisualStyleBackColor = true;
            // 
            // rodzajWyjazdu
            // 
            this.rodzajWyjazdu.Controls.Add(this.rodzajWyjazduWakacjeMiasto);
            this.rodzajWyjazdu.Controls.Add(this.rodzajWyjazduWakacjeNadWoda);
            this.rodzajWyjazdu.Controls.Add(this.rodzajWyjazduDoRodziny);
            this.rodzajWyjazdu.Controls.Add(this.rodzajWyjazduWakacjeGory);
            this.rodzajWyjazdu.Controls.Add(this.rodzajWyjazduSluzbowy);
            this.rodzajWyjazdu.Location = new System.Drawing.Point(373, 24);
            this.rodzajWyjazdu.Name = "rodzajWyjazdu";
            this.rodzajWyjazdu.Size = new System.Drawing.Size(269, 92);
            this.rodzajWyjazdu.TabIndex = 2;
            this.rodzajWyjazdu.TabStop = false;
            this.rodzajWyjazdu.Text = "Rodzaj wyjazdu";
            // 
            // rodzajWyjazduWakacjeMiasto
            // 
            this.rodzajWyjazduWakacjeMiasto.AutoSize = true;
            this.rodzajWyjazduWakacjeMiasto.Location = new System.Drawing.Point(7, 67);
            this.rodzajWyjazduWakacjeMiasto.Name = "rodzajWyjazduWakacjeMiasto";
            this.rodzajWyjazduWakacjeMiasto.Size = new System.Drawing.Size(107, 17);
            this.rodzajWyjazduWakacjeMiasto.TabIndex = 4;
            this.rodzajWyjazduWakacjeMiasto.TabStop = true;
            this.rodzajWyjazduWakacjeMiasto.Text = "Wakacje - miasto";
            this.rodzajWyjazduWakacjeMiasto.UseVisualStyleBackColor = true;
            // 
            // rodzajWyjazduWakacjeNadWoda
            // 
            this.rodzajWyjazduWakacjeNadWoda.AutoSize = true;
            this.rodzajWyjazduWakacjeNadWoda.Location = new System.Drawing.Point(125, 44);
            this.rodzajWyjazduWakacjeNadWoda.Name = "rodzajWyjazduWakacjeNadWoda";
            this.rodzajWyjazduWakacjeNadWoda.Size = new System.Drawing.Size(124, 17);
            this.rodzajWyjazduWakacjeNadWoda.TabIndex = 3;
            this.rodzajWyjazduWakacjeNadWoda.TabStop = true;
            this.rodzajWyjazduWakacjeNadWoda.Text = "Wakacje - nad wodą";
            this.rodzajWyjazduWakacjeNadWoda.UseVisualStyleBackColor = true;
            // 
            // rodzajWyjazduDoRodziny
            // 
            this.rodzajWyjazduDoRodziny.AutoSize = true;
            this.rodzajWyjazduDoRodziny.Location = new System.Drawing.Point(125, 21);
            this.rodzajWyjazduDoRodziny.Name = "rodzajWyjazduDoRodziny";
            this.rodzajWyjazduDoRodziny.Size = new System.Drawing.Size(75, 17);
            this.rodzajWyjazduDoRodziny.TabIndex = 2;
            this.rodzajWyjazduDoRodziny.TabStop = true;
            this.rodzajWyjazduDoRodziny.Text = "Do rodziny";
            this.rodzajWyjazduDoRodziny.UseVisualStyleBackColor = true;
            // 
            // rodzajWyjazduWakacjeGory
            // 
            this.rodzajWyjazduWakacjeGory.AutoSize = true;
            this.rodzajWyjazduWakacjeGory.Location = new System.Drawing.Point(7, 44);
            this.rodzajWyjazduWakacjeGory.Name = "rodzajWyjazduWakacjeGory";
            this.rodzajWyjazduWakacjeGory.Size = new System.Drawing.Size(97, 17);
            this.rodzajWyjazduWakacjeGory.TabIndex = 1;
            this.rodzajWyjazduWakacjeGory.TabStop = true;
            this.rodzajWyjazduWakacjeGory.Text = "Wakacje - góry";
            this.rodzajWyjazduWakacjeGory.UseVisualStyleBackColor = true;
            // 
            // rodzajWyjazduSluzbowy
            // 
            this.rodzajWyjazduSluzbowy.AutoSize = true;
            this.rodzajWyjazduSluzbowy.Location = new System.Drawing.Point(7, 20);
            this.rodzajWyjazduSluzbowy.Name = "rodzajWyjazduSluzbowy";
            this.rodzajWyjazduSluzbowy.Size = new System.Drawing.Size(72, 17);
            this.rodzajWyjazduSluzbowy.TabIndex = 0;
            this.rodzajWyjazduSluzbowy.TabStop = true;
            this.rodzajWyjazduSluzbowy.Text = "Służbowy";
            this.rodzajWyjazduSluzbowy.UseVisualStyleBackColor = true;
            // 
            // poraRoku
            // 
            this.poraRoku.Controls.Add(this.poraRokuWiosnaJesien);
            this.poraRoku.Controls.Add(this.zima);
            this.poraRoku.Controls.Add(this.lato);
            this.poraRoku.Location = new System.Drawing.Point(138, 24);
            this.poraRoku.Name = "poraRoku";
            this.poraRoku.Size = new System.Drawing.Size(115, 92);
            this.poraRoku.TabIndex = 1;
            this.poraRoku.TabStop = false;
            this.poraRoku.Text = "Pora roku";
            // 
            // poraRokuWiosnaJesien
            // 
            this.poraRokuWiosnaJesien.AutoSize = true;
            this.poraRokuWiosnaJesien.Location = new System.Drawing.Point(7, 67);
            this.poraRokuWiosnaJesien.Name = "poraRokuWiosnaJesien";
            this.poraRokuWiosnaJesien.Size = new System.Drawing.Size(93, 17);
            this.poraRokuWiosnaJesien.TabIndex = 2;
            this.poraRokuWiosnaJesien.TabStop = true;
            this.poraRokuWiosnaJesien.Text = "Wiosna/jesień";
            this.poraRokuWiosnaJesien.UseVisualStyleBackColor = true;
            // 
            // zima
            // 
            this.zima.AutoSize = true;
            this.zima.Location = new System.Drawing.Point(7, 44);
            this.zima.Name = "zima";
            this.zima.Size = new System.Drawing.Size(48, 17);
            this.zima.TabIndex = 1;
            this.zima.TabStop = true;
            this.zima.Text = "Zima";
            this.zima.UseVisualStyleBackColor = true;
            // 
            // lato
            // 
            this.lato.AutoSize = true;
            this.lato.Location = new System.Drawing.Point(7, 20);
            this.lato.Name = "lato";
            this.lato.Size = new System.Drawing.Size(46, 17);
            this.lato.TabIndex = 0;
            this.lato.TabStop = true;
            this.lato.Text = "Lato";
            this.lato.UseVisualStyleBackColor = true;
            // 
            // plec
            // 
            this.plec.Controls.Add(this.plecMezczyzna);
            this.plec.Controls.Add(this.plecKobieta);
            this.plec.Location = new System.Drawing.Point(12, 24);
            this.plec.Name = "plec";
            this.plec.Size = new System.Drawing.Size(115, 92);
            this.plec.TabIndex = 0;
            this.plec.TabStop = false;
            this.plec.Text = "Płeć";
            // 
            // plecMezczyzna
            // 
            this.plecMezczyzna.AutoSize = true;
            this.plecMezczyzna.Location = new System.Drawing.Point(7, 44);
            this.plecMezczyzna.Name = "plecMezczyzna";
            this.plecMezczyzna.Size = new System.Drawing.Size(78, 17);
            this.plecMezczyzna.TabIndex = 1;
            this.plecMezczyzna.TabStop = true;
            this.plecMezczyzna.Text = "Mężczyzna";
            this.plecMezczyzna.UseVisualStyleBackColor = true;
            // 
            // plecKobieta
            // 
            this.plecKobieta.AutoSize = true;
            this.plecKobieta.Location = new System.Drawing.Point(7, 20);
            this.plecKobieta.Name = "plecKobieta";
            this.plecKobieta.Size = new System.Drawing.Size(61, 17);
            this.plecKobieta.TabIndex = 0;
            this.plecKobieta.TabStop = true;
            this.plecKobieta.Text = "Kobieta";
            this.plecKobieta.UseVisualStyleBackColor = true;
            // 
            // akcjeGenerujListe
            // 
            this.akcjeGenerujListe.Location = new System.Drawing.Point(12, 19);
            this.akcjeGenerujListe.Name = "akcjeGenerujListe";
            this.akcjeGenerujListe.Size = new System.Drawing.Size(181, 29);
            this.akcjeGenerujListe.TabIndex = 2;
            this.akcjeGenerujListe.Text = "Generuj listę predefiniowaną";
            this.akcjeGenerujListe.UseVisualStyleBackColor = true;
            // 
            // akcje
            // 
            this.akcje.Controls.Add(this.akcjeImportujZCSV);
            this.akcje.Controls.Add(this.akcjeEksportujDoCSV);
            this.akcje.Controls.Add(this.akcjeDrukuj);
            this.akcje.Controls.Add(this.akcjeGenerujListe);
            this.akcje.Location = new System.Drawing.Point(12, 157);
            this.akcje.Name = "akcje";
            this.akcje.Size = new System.Drawing.Size(648, 63);
            this.akcje.TabIndex = 4;
            this.akcje.TabStop = false;
            this.akcje.Text = "Akcje";
            // 
            // akcjeImportujZCSV
            // 
            this.akcjeImportujZCSV.Location = new System.Drawing.Point(433, 19);
            this.akcjeImportujZCSV.Name = "akcjeImportujZCSV";
            this.akcjeImportujZCSV.Size = new System.Drawing.Size(110, 29);
            this.akcjeImportujZCSV.TabIndex = 2;
            this.akcjeImportujZCSV.Text = "Importuj z csv";
            this.akcjeImportujZCSV.UseVisualStyleBackColor = true;
            // 
            // akcjeEksportujDoCSV
            // 
            this.akcjeEksportujDoCSV.Location = new System.Drawing.Point(317, 19);
            this.akcjeEksportujDoCSV.Name = "akcjeEksportujDoCSV";
            this.akcjeEksportujDoCSV.Size = new System.Drawing.Size(110, 29);
            this.akcjeEksportujDoCSV.TabIndex = 2;
            this.akcjeEksportujDoCSV.Text = "Eksportuj do csv";
            this.akcjeEksportujDoCSV.UseVisualStyleBackColor = true;
            // 
            // akcjeDrukuj
            // 
            this.akcjeDrukuj.Location = new System.Drawing.Point(201, 19);
            this.akcjeDrukuj.Name = "akcjeDrukuj";
            this.akcjeDrukuj.Size = new System.Drawing.Size(110, 29);
            this.akcjeDrukuj.TabIndex = 2;
            this.akcjeDrukuj.Text = "Drukuj";
            this.akcjeDrukuj.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            this.lista.Controls.Add(this.dataGridView1);
            this.lista.Controls.Add(this.btnEdytuj);
            this.lista.Controls.Add(this.btnUsun);
            this.lista.Controls.Add(this.btnDodaj);
            this.lista.Location = new System.Drawing.Point(12, 241);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(647, 214);
            this.lista.TabIndex = 5;
            this.lista.TabStop = false;
            this.lista.Text = "Lista";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaDataGridViewTextBoxColumn,
            this.kategoriaDataGridViewTextBoxColumn,
            this.czyWziacDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.elementyClassBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 187);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(566, 54);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(75, 27);
            this.btnEdytuj.TabIndex = 4;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(566, 87);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 27);
            this.btnUsun.TabIndex = 4;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(566, 21);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 27);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.listaDodaj_Click);
            // 
            // elementyClassBindingSource
            // 
            this.elementyClassBindingSource.DataSource = typeof(AppMojaWalizka.ElementyClass);
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            this.kategoriaDataGridViewTextBoxColumn.DataPropertyName = "Kategoria";
            this.kategoriaDataGridViewTextBoxColumn.HeaderText = "Kategoria";
            this.kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            // 
            // czyWziacDataGridViewCheckBoxColumn
            // 
            this.czyWziacDataGridViewCheckBoxColumn.DataPropertyName = "CzyWziac";
            this.czyWziacDataGridViewCheckBoxColumn.HeaderText = "Czy wziąć";
            this.czyWziacDataGridViewCheckBoxColumn.Name = "czyWziacDataGridViewCheckBoxColumn";
            // 
            // FormGlowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 465);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.akcje);
            this.Controls.Add(this.parametry);
            this.Name = "FormGlowny";
            this.Text = "Moja walizka";
            this.parametry.ResumeLayout(false);
            this.nocleg.ResumeLayout(false);
            this.nocleg.PerformLayout();
            this.rodzajWyjazdu.ResumeLayout(false);
            this.rodzajWyjazdu.PerformLayout();
            this.poraRoku.ResumeLayout(false);
            this.poraRoku.PerformLayout();
            this.plec.ResumeLayout(false);
            this.plec.PerformLayout();
            this.akcje.ResumeLayout(false);
            this.lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox parametry;
        private System.Windows.Forms.GroupBox rodzajWyjazdu;
        private System.Windows.Forms.GroupBox poraRoku;
        private System.Windows.Forms.GroupBox plec;
        private System.Windows.Forms.Button akcjeGenerujListe;
        private System.Windows.Forms.RadioButton poraRokuWiosnaJesien;
        private System.Windows.Forms.RadioButton zima;
        private System.Windows.Forms.RadioButton lato;
        private System.Windows.Forms.RadioButton plecMezczyzna;
        private System.Windows.Forms.RadioButton plecKobieta;
        private System.Windows.Forms.GroupBox nocleg;
        private System.Windows.Forms.RadioButton noclegNie;
        private System.Windows.Forms.RadioButton noclegTak;
        private System.Windows.Forms.RadioButton rodzajWyjazduWakacjeMiasto;
        private System.Windows.Forms.RadioButton rodzajWyjazduWakacjeNadWoda;
        private System.Windows.Forms.RadioButton rodzajWyjazduDoRodziny;
        private System.Windows.Forms.RadioButton rodzajWyjazduWakacjeGory;
        private System.Windows.Forms.RadioButton rodzajWyjazduSluzbowy;
        private System.Windows.Forms.GroupBox akcje;
        private System.Windows.Forms.Button akcjeDrukuj;
        private System.Windows.Forms.GroupBox lista;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button akcjeImportujZCSV;
        private System.Windows.Forms.Button akcjeEksportujDoCSV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource elementyClassBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn czyWziacDataGridViewCheckBoxColumn;
    }
}

