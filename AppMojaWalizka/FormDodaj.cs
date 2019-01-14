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
        public ElementyClass Nazwa { get; set; }

        public FormDodaj()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nazwa.Element = txtNazwa.Text;
        }

        private void FormDodaj_Load(object sender, EventArgs e)
        {
            if(Nazwa != null)
            {
                txtNazwa.Text = Nazwa.Element;
            }
        }
    }
}
