using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMojaWalizka
{
    

    public partial class FormDodaj : Form
    {
        
        public ElementyClass elem { get; set; }

        public FormDodaj()
        {
            InitializeComponent();
            cmbKategoria.DataSource = Enum.GetValues(typeof(EnumKategoria.Kategoria));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            elem.Nazwa = txtNazwa.Text;
            elem.CzyWziac = true;
            elem.Kategoria = cmbKategoria.Text;

        }

        private void FormDodaj_Load(object sender, EventArgs e)
        {
            txtNazwa.Text = elem.Nazwa;
            cmbKategoria.Text = elem.Kategoria;
        }

        private void FormDodaj_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (elem.Nazwa == "" || elem.Kategoria == "")
            {
                elem.Nazwa = "";
                elem.Kategoria = "";
                var wynik = MessageBox.Show("Nie wprowadzono danych poprawnie. Wprowadź dane do obu pól.", "Brak danych"
                                                ,MessageBoxButtons.OK
                                                ,MessageBoxIcon.Exclamation
                                                );

                e.Cancel = true;

            }
        }
    }
}
