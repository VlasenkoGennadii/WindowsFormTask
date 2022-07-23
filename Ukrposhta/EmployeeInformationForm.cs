using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukrposhta.Menu;

namespace Ukrposhta
{
    public partial class EmployeeInformationForm : Form
    {
        string firstName;
        string lastName;
        string middleName;
        DataGridView dataGridView;
        DatabaseConnection databaseConnection;
        PPS ukrposhta;
        EditingPositions editingPositions;
        BonusItems bonusItems;
        EditingEmpoyees editingEmpoyees;
        EmployeeInfornmation employeeInfornmation;
        SqlDataReader sqlDataReader;

        public EmployeeInformationForm(string FirstName, string LastName, string MiddleName)
        {
            firstName = FirstName;
            lastName = LastName;
            middleName = MiddleName;

            InitializeComponent();

            databaseConnection = new DatabaseConnection();
            editingPositions = new EditingPositions();
            ukrposhta = new PPS();
            bonusItems = new BonusItems();

            databaseConnection.ConnectionAdapter($"Select * from Employees Where FirstName = '{FirstName}' AND LastName = '{LastName}' AND MiddleName = '{MiddleName}'");
            dataGridView_EmployeeInformation.DataSource = databaseConnection.dataTable;

            foreach (var position in editingPositions.ShowAllPositions("Select Position from Positions"))
            {
                comboBox_SelectPosition.Items.Add(position.Position);
            }
            foreach (var bonus in bonusItems.ShowBonus())
            {
                comboBox_SelectBonus.Items.Add(bonus.Grade);
            }
            FormClosing += CloseApplication;
        }
        private void button_DeleteEmployee_Click(object sender, EventArgs e)
        {

            string deletemessage = "При удалении вы потеряете информацию о сотруднике. Все равно удалить эту позицию?";
            if (MessageBox.Show(deletemessage, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    databaseConnection = new DatabaseConnection();
                    editingEmpoyees = new EditingEmpoyees();
                    dataGridView = dataGridView_EmployeeInformation;
                    int id = (int)dataGridView[0, 0].Value;
                    editingEmpoyees.DeleteEmployee(id);
                    sqlDataReader = databaseConnection.Connection($"Select Top 1 FirstName, LastName, MiddleName from Employees Where Id > 0");
                    while (sqlDataReader.Read())
                    {
                        firstName = (string)sqlDataReader[0];
                        lastName = (string)sqlDataReader[1];
                        middleName = (string)sqlDataReader[2];
                    }


                }
                catch
                {
                    label_Update.ForeColor = Color.Red;
                    label_Update.Text = "Произошла ошибка";

                }
                EmployeeInformationForm employeeInformation = new EmployeeInformationForm(firstName, lastName, middleName);
                employeeInformation.label_Update.ForeColor = Color.Green;
                employeeInformation.label_Update.Text = "Операция прошла успешно";
                employeeInformation.Show();

                
                






            }
                     
        }
        private void button_ChangeEmployee_Click(object sender, EventArgs e)
        {
            string bonus = string.Empty;
            dataGridView = dataGridView_EmployeeInformation;
            databaseConnection = new DatabaseConnection();
            employeeInfornmation = new EmployeeInfornmation();
            int id = (int)dataGridView[0, 0].Value;
            
            int positionid = databaseConnection.ConnectionGiveId($"Select Id from Positions Where Position = '{(string)comboBox_SelectPosition.SelectedItem}'");
            if(comboBox_SelectBonus.SelectedItem == null)
            {
                bonus = (string)dataGridView[7, 0].Value;
            }
            else
            {
                bonus = comboBox_SelectBonus.SelectedItem.ToString();
            }
            Employee employee = new Employee()
            {
                FirstName = FirstName_textbox.Text,
                LastName = LastName_textbox.Text,
                MiddleName = MiddleName_textbox.Text,
                Phone = Phone_textbox.Text,
                Address = Adress_textbox.Text,
                Position = positionid,
                Bonus = bonus

            };
            string message = employeeInfornmation.UpdateEmployee(employee, id);
            if(message.Contains("Cпециальные") || message.Contains("Ошибка"))
            {
                label_Update.ForeColor = Color.Red;
                label_Update.Text = message;
            }
            else
            {
                this.Hide();
                if(FirstName_textbox.Text == "")
                {
                    firstName = (string)dataGridView[1, 0].Value;
                }
                else
                {
                    firstName = employee.FirstName;
                }
                if (LastName_textbox.Text == "")
                {
                    lastName = (string)dataGridView[2, 0].Value;
                }
                else
                {
                    lastName = employee.LastName;
                }
                if (MiddleName_textbox.Text == "")
                {
                    middleName = (string)dataGridView[3, 0].Value;
                }
                else
                {
                    middleName = employee.MiddleName;
                }
                EmployeeInformationForm employeeInformation = new EmployeeInformationForm(firstName, lastName, middleName);
                employeeInformation.label_Update.ForeColor = Color.Green;
                employeeInformation.label_Update.Text = message;
                employeeInformation.Show();
            }
            

        }
        private void Back_Employee_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PPS ukrposhta = (PPS)Application.OpenForms[0];
            ukrposhta.Show();
        }
        private void CloseApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
