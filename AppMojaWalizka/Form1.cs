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
                        MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
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
                MessageBox.Show("Your file was generated and its ready for use.");
            }
        }

        private void akcjeEksportujDoCSV_Click(object sender, EventArgs e)   
        {
            SaveToCSV(dataGridView1);
        }

        private void akcjeImportujZCSV_Click(object sender, EventArgs e)
        {/*
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("nazwaDataGridViewTextBoxColumn");
            dataTable.Columns.Add("kategoriaDataGridViewTextBoxColumn");
            dataTable.Columns.Add("czyWziacDataGridViewCheckBoxColumn");
            string filePath = "C:\\Users\\Krzysztof\\Desktop\\Osoby\\csv.csv";
            StreamReader streamReader = new StreamReader(filePath);
            string[] totalData = new string[File.ReadAllLines(filePath).Length];
            totalData = streamReader.ReadLine().Split(',');
            while (!streamReader.EndOfStream)
            {
                totalData = streamReader.ReadLine().Split(',');
                dataTable.Rows.Add(totalData[0], totalData[1], totalData[2]);
            }
            dataGridView1.DataSource = dataTable;*/
        }
    }
}
