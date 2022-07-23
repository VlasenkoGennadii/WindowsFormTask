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
    public partial class AddEmployeeForm : Form
    {
        EditingEmpoyees editingEmpoyees;
        BonusItems bonusItems;
        EditingPositions editingPositions;
        DatabaseConnection databaseConnection;
        public AddEmployeeForm()
        {
            InitializeComponent();
            bonusItems = new BonusItems();
            editingPositions = new EditingPositions();
            foreach (var bonus in bonusItems.ShowBonus())
            {
                comboBox_Bonus.Items.Add(bonus.Grade);
            }
            foreach (var position in editingPositions.ShowAllPositions("Select Position from Positions"))
            {
                comboBox_SelectPositionAddEmployee.Items.Add(position.Position);
            }
            FormClosing += CloseApplication;
        }

        private void Back_Employee_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PPS ukrposhta = (PPS)Application.OpenForms[0];
            ukrposhta.Show();

        }
        private void button_AddNewEmployee_Click(object sender, EventArgs e)
        {
            int check = 0;
            editingEmpoyees = new EditingEmpoyees();
            databaseConnection = new DatabaseConnection();
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            try
            {
                int id = databaseConnection.ConnectionGiveId($"Select id from Positions Where Position = '{comboBox_SelectPositionAddEmployee.SelectedItem}'");
                if (textBox_FirstName.Text == "")
                {
                    check++;
                    label_AddNewEmployee.ForeColor = Color.OrangeRed;
                    label_FName.Text = "Вы не заполнили Имя!";
                }
                if (textBox_LastName.Text == "")
                {
                    check++;
                    label_AddNewEmployee.ForeColor = Color.OrangeRed;
                    label_LName.Text = "Вы не заполнили Фамилию!";
                }
                if (textBox_MiddleName.Text == "")
                {
                    check++;
                    label_AddNewEmployee.ForeColor = Color.OrangeRed;
                    label_MiddleName.Text = "Вы не заполнили Отчество!";
                }
                if (comboBox_SelectPositionAddEmployee.SelectedItem == null)
                {
                    check++;
                    label_AddNewEmployee.ForeColor = Color.OrangeRed;
                    label_Position.Text = "Вы не выбрали должность!";
                }
                if (comboBox_Bonus.SelectedItem == null)
                {
                    check++;
                    label_AddNewEmployee.ForeColor = Color.OrangeRed;
                    label_Bonus.Text = "Вы не выбрали премию!";
                }

                if (check == 0)
                {
                    Employee employee = new Employee()
                    {
                        FirstName = textBox_FirstName.Text,
                        LastName = textBox_LastName.Text,
                        MiddleName = textBox_MiddleName.Text,
                        Address = textBox_Address.Text,
                        Phone = textBox_Phone.Text,
                        Position = id,
                        Bonus = comboBox_Bonus.SelectedItem.ToString()
                    };
                    string message = editingEmpoyees.AddNewEmployee(employee);
                    if (message.Contains("Cпециальные"))
                    {
                        addEmployeeForm.label_AddNewEmployee.ForeColor = Color.Red;
                        addEmployeeForm.label_AddNewEmployee.Text = message;
                        this.Hide();
                        addEmployeeForm.Show();
                    }
                    else
                    {
                        addEmployeeForm.label_AddNewEmployee.ForeColor = Color.Green;
                        addEmployeeForm.label_AddNewEmployee.Text = message;
                        this.Hide();
                        addEmployeeForm.Show();



                    }

                }
            }
            catch
            {
                label_AddNewEmployee.ForeColor = Color.Red;
                label_AddNewEmployee.Text = "Произошла ошибка";
            }

        }
        private void CloseApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
        
    
