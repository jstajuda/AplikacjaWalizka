namespace AppMojaWalizka
{
    partial class main
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
            this.parametry = new System.Windows.Forms.GroupBox();
            this.plec = new System.Windows.Forms.GroupBox();
            this.poraRoku = new System.Windows.Forms.GroupBox();
            this.rodzajWyjazdu = new System.Windows.Forms.GroupBox();
            this.generujListe = new System.Windows.Forms.Button();
            this.plecKobieta = new System.Windows.Forms.RadioButton();
            this.plecMezczyzna = new System.Windows.Forms.RadioButton();
            this.lato = new System.Windows.Forms.RadioButton();
            this.zima = new System.Windows.Forms.RadioButton();
            this.poraRokuWiosnaJesien = new System.Windows.Forms.RadioButton();
            this.nocleg = new System.Windows.Forms.GroupBox();
            this.noclegTak = new System.Windows.Forms.RadioButton();
            this.noclegNie = new System.Windows.Forms.RadioButton();
            this.rodzajWyjazduSluzbowy = new System.Windows.Forms.RadioButton();
            this.rodzajWyjazduWakacjeGory = new System.Windows.Forms.RadioButton();
            this.rodzajWyjazduDoRodziny = new System.Windows.Forms.RadioButton();
            this.rodzajWyjazduWakacjeNadWoda = new System.Windows.Forms.RadioButton();
            this.rodzajWyjazduWakacjeMiasto = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.parametry.SuspendLayout();
            this.plec.SuspendLayout();
            this.poraRoku.SuspendLayout();
            this.rodzajWyjazdu.SuspendLayout();
            this.nocleg.SuspendLayout();
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
            // generujListe
            // 
            this.generujListe.Location = new System.Drawing.Point(14, 145);
            this.generujListe.Name = "generujListe";
            this.generujListe.Size = new System.Drawing.Size(265, 29);
            this.generujListe.TabIndex = 2;
            this.generujListe.Text = "Generuj listę predefiniowaną";
            this.generujListe.UseVisualStyleBackColor = true;
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
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 194);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(648, 177);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 383);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.generujListe);
            this.Controls.Add(this.parametry);
            this.Name = "main";
            this.Text = "Moja walizka";
            this.parametry.ResumeLayout(false);
            this.plec.ResumeLayout(false);
            this.plec.PerformLayout();
            this.poraRoku.ResumeLayout(false);
            this.poraRoku.PerformLayout();
            this.rodzajWyjazdu.ResumeLayout(false);
            this.rodzajWyjazdu.PerformLayout();
            this.nocleg.ResumeLayout(false);
            this.nocleg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox parametry;
        private System.Windows.Forms.GroupBox rodzajWyjazdu;
        private System.Windows.Forms.GroupBox poraRoku;
        private System.Windows.Forms.GroupBox plec;
        private System.Windows.Forms.Button generujListe;
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
        private System.Windows.Forms.ListView listView1;
    }
}

