using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukrposhta.Menu;

namespace Ukrposhta
{
    public partial class ReportTextFileForm : Form
    {
        DatabaseConnection databaseconnection;
        EditingDepartments departments;
        ReportTextFile reportTextFile;
        public ReportTextFileForm()
        {
            InitializeComponent();

            databaseconnection = new DatabaseConnection();
            reportTextFile = new ReportTextFile();
            databaseconnection.ConnectionAdapter(reportTextFile.Report());
            dataGridView_ReportText.DataSource = databaseconnection.dataTable;
            dataGridView_ReportText.AllowUserToAddRows = false;
            departments = new EditingDepartments();
            FormClosing += CloseApplication;
        }
        private void Back_Payouts_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PPS ukrposhta = (PPS)Application.OpenForms[0];
            ukrposhta.Show();
        }
        private void button_MakeTextFile_Click(object sender, EventArgs e)
        {
 
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = @"C:\";
            saveFile.RestoreDirectory = true;
            saveFile.FileName = "PPS.txt";
            saveFile.DefaultExt = "txt";
            saveFile.Filter = "txt files (*.txt) | *.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Stream stream = saveFile.OpenFile();
                StreamWriter writer = new StreamWriter(stream);
                try
                {
                    
                    for (int i = 0; i < dataGridView_ReportText.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView_ReportText.Columns.Count; j++)
                        {
                            writer.Write(dataGridView_ReportText.Rows[i].Cells[j].Value + "     ");
                        }
                        writer.WriteLine();
                        writer.WriteLine();
                    }
                    this.Hide();
                    ReportTextFileForm reportTextFile = new ReportTextFileForm();
                    reportTextFile.label_Text.ForeColor = Color.Green;
                    reportTextFile.label_Text.Text = "Файл с данными успешно создан";
                    reportTextFile.Show();
                    
                }
                catch
                {
                    label_Text.ForeColor = Color.Red;
                    label_Text.Text = "Ошибка при создании файла";
                }
                finally
                {
                    writer.Close();
                    stream.Close();
                }

            }


        }
        private void CloseApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
