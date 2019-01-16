using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


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
            using (FormDodaj d = new FormDodaj() { elem = new ElementyClass()})
            {
                if (d.ShowDialog() == DialogResult.OK)
                    elementyClassBindingSource.Add(d.elem);
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            ElementyClass element = elementyClassBindingSource.Current as ElementyClass;
            if(element != null)
            {
                using(FormDodaj f = new FormDodaj() { elem = element })
                {
                    if(f.ShowDialog() == DialogResult.OK)
                    {
                        elementyClassBindingSource.EndEdit();
                        btnEdytuj.Show();
                    }
                }
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }
        /*
        struct DataParameter
        {
            public List<DataGridView> ListaRzeczy;
            public string NazwaPliku { get; set; }
        }

        DataParameter _inputParameter;
        */
        private void akcjeEksportujDoCSV_Click(object sender, EventArgs e)   
        {/*
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //_inputParameter.ListaRzeczy = elementyClassBindingSource.DataSource as List<DataGridView>;
                    //_inputParameter.NazwaPliku = sfd.FileName;
                    using (Stream s = File.Open(sfd.FileName, FileMode.CreateNew)) 
                    using(StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(dataGridView1.Rows);
                    }

                }
            }*/
        }

    }
}
