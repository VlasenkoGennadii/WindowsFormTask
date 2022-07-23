using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukrposhta.Menu;

namespace Ukrposhta
{
    public partial class PayoutsForm : Form
    {
        DatabaseConnection databaseconnection;
        Payouts payouts;
        EditingDepartments editingDepartments;
        public PayoutsForm()
        {
            InitializeComponent(); 
            payouts = new Payouts();
            databaseconnection = new DatabaseConnection();
            editingDepartments = new EditingDepartments();
            databaseconnection.ConnectionAdapter(payouts.ShowAllPayouts());
            dataGridView_Payonuts.DataSource = databaseconnection.dataTable;
            dataGridView_Payonuts.AllowUserToAddRows = false;
            comboBox_SelectDepartment.Items.Clear();
            comboBox_SelectDepartment.Items.Add("All Departments");
            foreach (var department in editingDepartments.ShowAllDepartments())
            {
                comboBox_SelectDepartment.Items.Add(department.DepartmentName);
            }
            FormClosing += CloseApplication;



        }
        private void Back_Payouts_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PPS ukrposhta = (PPS)Application.OpenForms[0];
            ukrposhta.Show();

        }
        private void ShowSelectedDepartmentPayouts(object sender, EventArgs e)
        {
            
            payouts = new Payouts();
            databaseconnection = new DatabaseConnection();
            databaseconnection.ConnectionAdapter(payouts.ShowDepartmentPayouts(comboBox_SelectDepartment.SelectedItem.ToString()));
            dataGridView_Payonuts.DataSource = databaseconnection.dataTable;


        }
        private void CloseApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
