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
    public partial class FormGlowny : Form
    {

        public FormGlowny()
        {
            InitializeComponent();
        }

        private void listaDodaj_Click(object sender, EventArgs e)
        {
            using (FormDodaj d = new FormDodaj() { Nazwa = new ElementyClass()})
            {
                if (d.ShowDialog() == DialogResult.OK)
                    elementyClassBindingSource.Add(d.Nazwa);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            ElementyClass elem = elementyClassBindingSource.Current as ElementyClass;
            if(elem != null)
            {
                using(FormDodaj f = new FormDodaj() { Nazwa = elem })
                {
                    if(f.ShowDialog() == DialogResult.OK)
                    {
                        elementyClassBindingSource.EndEdit();
                        btnEdytuj.Focus();
                    }
                }
            }
        }
    }
}
