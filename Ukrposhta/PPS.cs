using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Ukrposhta.Menu;

namespace Ukrposhta
{
    public partial class PPS : Form
    {
        DatabaseConnection databaseconnection;
        MainPage mainPage = new MainPage();
        EditingDepartments departments;
        BonusItems bonusItems;
        public PPS()
        {
            InitializeComponent();
            databaseconnection = new DatabaseConnection();
            databaseconnection.ConnectionAdapter(mainPage.ShowAllEmployees());
            dataGridView_MainMenu.DataSource = databaseconnection.dataTable;
            dataGridView_MainMenu.AllowUserToAddRows = false;

            bonusItems = new BonusItems();
            
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.DataSource = bonusItems.ShowBonus().Select(x=>x.Grade).ToList();
            combo.HeaderText = "Grade";            
            dataGridView_MainMenu.Columns.Add(combo);

            departments = new EditingDepartments();
            foreach (var department in departments.ShowAllDepartments())
            {
                SelectDepartment.Items.Add(department.DepartmentName);
            }          
            
            dataGridView_MainMenu.CellContentClick += ShowEmployee;
            
            dataGridView_MainMenu.CurrentCellDirtyStateChanged += SelectBonus;
            FormClosing += CloseApplication;


        }
        public void SelectBonus(object sender, EventArgs e)
        {
            string grade = (string)((DataGridView)sender).SelectedCells[0].EditedFormattedValue;
            decimal salary = (decimal)((DataGridView)sender)[6, ((DataGridView)sender).SelectedCells[0].RowIndex].Value;
            databaseconnection = new DatabaseConnection();
            SqlDataReader reader = databaseconnection.Connection($"Select [Percent] from Bonus Where '{grade}' = Grade");
            reader.Read();
            string percent = ((string)reader[0]).Remove(((string)reader[0]).Length - 2);
            decimal bonus = salary * Convert.ToDecimal(percent) / 100;
            dataGridView_MainMenu[7, ((DataGridView)sender).SelectedCells[0].RowIndex].Value = bonus;
           
        }
        private void Ukr_Load(object sender, EventArgs e) { }
        public void ShowEmployee(object sender, EventArgs e)
        {

            DataGridView dataGridView = (DataGridView)sender;
            string FirsName = (string)dataGridView[1, ((DataGridViewCellEventArgs)e).RowIndex].Value;
            string LastName = (string)dataGridView[2, ((DataGridViewCellEventArgs)e).RowIndex].Value;
            string MiddleName = (string)dataGridView[3, ((DataGridViewCellEventArgs)e).RowIndex].Value;
            this.Hide();
            EmployeeInformationForm employeeInformation = new EmployeeInformationForm(FirsName, LastName, MiddleName);
            employeeInformation.Show();
            

        }  //Информация о сотруднике
        private void SelectedDepartments(object sender, EventArgs e)
        {
            try
            {
                if (SelectDepartment.CheckedItems.Count != 0)
                {
                    departments = new EditingDepartments();
                    databaseconnection.ConnectionAdapter(mainPage.ShowEmployeesFromDepartments(SelectDepartment.CheckedItems));
                    dataGridView_MainMenu.DataSource = databaseconnection.dataTable;
                }
                else
                {
                    databaseconnection.ConnectionAdapter(mainPage.ShowAllEmployees());
                    dataGridView_MainMenu.DataSource = databaseconnection.dataTable;
                    
                }

            }
            catch
            {                
                label_SelectDepartmentMainMaenu.Text = "Ошибка!";
            }

        } //Показ имеющихся отделов
        private void EditingDepartments_Menu(object sender, EventArgs e)
        {
            this.Hide();
            EditingDepartmentsForm editingDepartmentsForm = (EditingDepartmentsForm)Application.OpenForms["EditingDepartmentsForm"];
            
            if (editingDepartmentsForm == null)
            {
                editingDepartmentsForm = new EditingDepartmentsForm();
                editingDepartmentsForm.Show();
            }
            else
            {
                editingDepartmentsForm.Dispose();
                editingDepartmentsForm = new EditingDepartmentsForm();
                editingDepartmentsForm.Show();
            }

        } //Первый раздел
        private void EditingPositions_Menu(object sender, EventArgs e)
        {
            this.Hide();
            EditingPositionsForm editingPositions = (EditingPositionsForm)Application.OpenForms["EditingPositionsForm"];
            if(editingPositions == null)
            {
                editingPositions = new EditingPositionsForm();
                editingPositions.Show();
            }
            else
            {
                editingPositions.Dispose();
                editingPositions = new EditingPositionsForm();
                editingPositions.Show();
            }
            
            
            

        } //Второй раздел
        private void AddEmployee_Menu(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployeeForm addEmployeeForm = (AddEmployeeForm)Application.OpenForms["AddEmployeeForm"];
            if(addEmployeeForm == null)
            {
                addEmployeeForm = new AddEmployeeForm();
                addEmployeeForm.Show();
            }
            else
            {
                addEmployeeForm.Dispose();
                addEmployeeForm = new AddEmployeeForm();
                addEmployeeForm.Show();
            }
            
            


        } //Третий раздел
        private void Payouts_Menu(object sender, EventArgs e)
        {
            this.Hide();
            PayoutsForm payoutsForm = (PayoutsForm)Application.OpenForms["PayoutsForm"];
            if(payoutsForm == null)
            {
                payoutsForm = new PayoutsForm();
            }
            else
            {
                payoutsForm.Dispose();
                payoutsForm = new PayoutsForm();
                
            }
            payoutsForm.Show();


        } //Четвертый раздел
        private void ReportTextFile_butto(object sender, EventArgs e)
        {
            this.Hide();
            ReportTextFileForm reportTextFileForm = (ReportTextFileForm)Application.OpenForms["ReportTextFileForm"];
            if(reportTextFileForm == null)
            {
                reportTextFileForm = new ReportTextFileForm();
            }
            else
            {
                reportTextFileForm.Dispose();
                reportTextFileForm = new ReportTextFileForm();
                
            }
            reportTextFileForm.Show();

        } //Пятый раздел
        private void CloseApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            SelectedDepartments(sender, e);
        }
    }
}
