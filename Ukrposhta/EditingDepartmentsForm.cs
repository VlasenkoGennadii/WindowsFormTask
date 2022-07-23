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
    public partial class EditingDepartmentsForm : Form
    {
        DatabaseConnection databaseconnection;
        EditingDepartments editingDepartments;
        EditingDepartmentsForm editingDepartmentsForm;
        public EditingDepartmentsForm()
        {
            InitializeComponent();
            databaseconnection = new DatabaseConnection();
            databaseconnection.ConnectionAdapter("Select DepartmentName from Departments");
            dataGridView_Departments.DataSource = databaseconnection.dataTable;
            dataGridView_Departments.AllowUserToAddRows = false;
            editingDepartments = new EditingDepartments();
            foreach (var department in editingDepartments.ShowAllDepartments())
            {
                comboBox_SelectDeleteDepartment.Items.Add(department.DepartmentName);
                SelectDepartmentforRenamecomboBox.Items.Add(department.DepartmentName);
            }
            FormClosing += CloseApplication;

        }

       
        private void AddNewDepartment_button(object sender, EventArgs e)
        {
            editingDepartments = new EditingDepartments();
            editingDepartmentsForm = new EditingDepartmentsForm();
            if (textBox_AddDepartment.Text != "")
            {
                string message = editingDepartments.AddNewDepartment(textBox_AddDepartment.Text);
                
                
                if(message.Contains("спецсимволы") || message.Contains("существует"))
                {
                    label_error_AddDepertment.ForeColor = Color.Red;
                    label_error_AddDepertment.Text = message;
                }
                else
                {
                    this.Hide();
                    EditingDepartmentsForm editingDepartmentsForm = new EditingDepartmentsForm();
                    editingDepartmentsForm.label_error_AddDepertment.ForeColor = Color.Green;
                    editingDepartmentsForm.label_error_AddDepertment.Text = message;
                    editingDepartmentsForm.Show();
                }
                
            }
            else
            {
                label_error_AddDepertment.ForeColor = Color.Red;
                label_error_AddDepertment.Text = "Введите назавание отдела!";
            }

        }

        private void DeleteDepartment_Button_Click(object sender, EventArgs e)
        {
            
            editingDepartments = new EditingDepartments();
            if (comboBox_SelectDeleteDepartment.SelectedItem != null)
            {
                string deletemessage = $"При удалении этого отдела будет затронуто  некое число сотрудников. Удалить этот отдел?";
                if (MessageBox.Show(deletemessage, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.Hide();
                    editingDepartments.DeleteDepartment(comboBox_SelectDeleteDepartment.SelectedItem.ToString());
                    EditingDepartmentsForm editingDepartmentsForm = new EditingDepartmentsForm(); 
                    editingDepartmentsForm.label_deleteDepartment.ForeColor = Color.Green;
                    editingDepartmentsForm.label_deleteDepartment.Text = "Операция выполнена успешно!";
                    editingDepartmentsForm.Show();

                }
 
            }
            else
            {
                label_deleteDepartment.ForeColor = Color.Red;
                label_deleteDepartment.Text = "Выберите отдел который хотите удалить!";

            }

        }

        private void UpdateDepartment_ButtonClick(object sender, EventArgs e)
        {
            editingDepartments = new EditingDepartments();
            editingDepartmentsForm = new EditingDepartmentsForm();
            string upfatemessage = "Вы уверенны что хотите изменить название отдела?";
            string message = string.Empty;

            if (textBox_AddNewNameDepartment.Text != "" & SelectDepartmentforRenamecomboBox.SelectedItem != null)
            {
                if (MessageBox.Show(upfatemessage, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    message = editingDepartments.UpdateDepartments(textBox_AddNewNameDepartment.Text, SelectDepartmentforRenamecomboBox.SelectedItem.ToString());
                    if(message.Contains("спецсимволы"))
                    {

                        label_UpdateDepartment.ForeColor = Color.Red;
                        label_UpdateDepartment.Text = message;
                        

                    }
                    else
                    {
                        this.Hide();
                        EditingDepartmentsForm editingDepartmentsForm = new EditingDepartmentsForm();
                        editingDepartmentsForm.label_UpdateDepartment.ForeColor = Color.Green;
                        editingDepartmentsForm.label_UpdateDepartment.Text = message;
                        editingDepartmentsForm.Show();
                    }
                }
            }
            else
            {
                label_UpdateDepartment.ForeColor = Color.Red;
                label_UpdateDepartment.Text = "Выберите отдел из выпадающиего списка!";
            }


        }

        private void CloseApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Employee_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PPS ukrposhta = (PPS)Application.OpenForms[0];
            ukrposhta.Show();
        }
    }
}
