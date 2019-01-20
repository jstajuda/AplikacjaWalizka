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
        private void SaveToCSV(DataGridView DGV)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Output.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Nie było możliwe, żeby zapisać ten plik." + ex.Message);
                    }
                }
                int columnCount = DGV.ColumnCount;
                string columnNames = "";
                string[] output = new string[DGV.RowCount + 1];
                for (int i = 0; i < columnCount; i++)
                {
                    if (i < columnCount - 1)
                    {
                        columnNames += DGV.Columns[i].Name.ToString() + ",";
                    }
                    else
                    {
                        columnNames += DGV.Columns[i].Name.ToString();
                    }
                }
                output[0] += columnNames;
                for (int i = 1; (i - 1) < DGV.RowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        if (j < columnCount - 1)
                        {
                            output[i] += DGV.Rows[i - 1].Cells[j].Value.ToString() + ",";
                        }
                        else
                        {
                            output[i] += DGV.Rows[i - 1].Cells[j].Value.ToString();
                        }
                    }
                }
                System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
            }
        }

        private void akcjeEksportujDoCSV_Click(object sender, EventArgs e)   
        {
            SaveToCSV(dataGridView1);
        }

        private void akcjeImportujZCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string path = "";
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = ofd.FileName.ToString();
            }
            //MessageBox.Show(path);

            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(path);
            if (lines.Length > 0)
            {
                /*
                // ten fragment kodu może być użyteczny w przypadku obsługi 
                // paremetru "ma nagłówek/nie ma nagłówka"

                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                */
                
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    
                    {
                        ElementyClass elem = new ElementyClass();
                        elem.Nazwa = dataWords[0];
                        elem.Kategoria = dataWords[1];
                        elem.CzyWziac = dataWords[2].ToLower()=="true" ? true : false;
                        elementyClassBindingSource.Add(elem);
                    }
                }

            }
        }
        /*
        private void DodajWiersze()
        {

        }
        */

    }
}
