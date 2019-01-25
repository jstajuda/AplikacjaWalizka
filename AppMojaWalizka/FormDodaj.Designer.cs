namespace AppMojaWalizka
{
    partial class FormDodaj
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKategoria = new System.Windows.Forms.ComboBox();
            this.kategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDodaj.Location = new System.Drawing.Point(119, 107);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(217, 31);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(119, 12);
            this.txtNazwa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(331, 22);
            this.txtNazwa.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(41, 16);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(54, 17);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Nazwa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategoria:";
            // 
            // cmbKategoria
            // 
            this.cmbKategoria.DataSource = this.kategoriaBindingSource;
            this.cmbKategoria.FormattingEnabled = true;
            this.cmbKategoria.Location = new System.Drawing.Point(120, 52);
            this.cmbKategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKategoria.Name = "cmbKategoria";
            this.cmbKategoria.Size = new System.Drawing.Size(328, 24);
            this.cmbKategoria.TabIndex = 3;
            // 
            // kategoriaBindingSource
            // 
            this.kategoriaBindingSource.DataSource = typeof(AppMojaWalizka.Kategoria);
            // 
            // FormDodaj
            // 
            this.AcceptButton = this.btnDodaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 153);
            this.Controls.Add(this.cmbKategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.btnDodaj);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDodaj";
            this.Text = "FormDodaj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDodaj_FormClosing);
            this.Load += new System.EventHandler(this.FormDodaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategoria;
        private System.Windows.Forms.BindingSource kategoriaBindingSource;
    }
}