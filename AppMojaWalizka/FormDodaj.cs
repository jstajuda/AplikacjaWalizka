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
            if(elem != null)
            {
                txtNazwa.Text = elem.Nazwa;
                cmbKategoria.Text = elem.Kategoria;
            }
        }


    }
}
