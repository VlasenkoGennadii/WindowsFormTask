using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukrposhta.Menu;

namespace Ukrposhta
{
    public partial class EditingPositionsForm : Form
    {
        DatabaseConnection databaseConnection;
        EditingPositions editingPositions;
        EditingDepartments editingDepartments;
        EditingPositionsForm positionsForm;
        
        public EditingPositionsForm()
        {
            InitializeComponent();
            editingDepartments = new EditingDepartments();
            databaseConnection = new DatabaseConnection();
            editingPositions = new EditingPositions();
            databaseConnection.ConnectionAdapter(editingPositions.ShowAllPositions());
            dataGridView_Positions.DataSource = databaseConnection.dataTable;
            dataGridView_Positions.AllowUserToAddRows = false;
            foreach (var department in editingDepartments.ShowAllDepartments())
            {
                comboBox_SelectDepartmentForNewPosition.Items.Add(department.DepartmentName);
                
            }
            foreach (var position in editingPositions.ShowAllPositions("Select Position from Positions"))
            {
                comboBox_SelectPositionForDelete.Items.Add(position.Position);
                comboBox_UpdatePostion.Items.Add(position.Position);
                comboBox_NewSalaryForPosition.Items.Add(position.Position);
            }
            FormClosing += CloseApplication;
        }
        private void Back_Position_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PPS ukrposhta = (PPS)Application.OpenForms[0];
            ukrposhta.Show();


        }
        private void AddNewPosition_Button_Click(object sender, EventArgs e)
        {
            positionsForm = new EditingPositionsForm();
            if (textBox_AddNewPosition.Text != "" & textBox_AddSalaryForNewPosition.Text != "" & comboBox_SelectDepartmentForNewPosition.SelectedItem != null)
            {
                int id = editingPositions.GivePositionId(comboBox_SelectDepartmentForNewPosition.SelectedItem.ToString());
                try
                {
                    string message = editingPositions.AddNewPosition(textBox_AddNewPosition.Text, Convert.ToDecimal(textBox_AddSalaryForNewPosition.Text), id);
                    

                    if (message.Contains("спецсимволы"))
                    {

                        label_AddNewPosition.ForeColor = Color.OrangeRed;
                        label_AddNewPosition.Text = message;

                    }
                    else
                    {
                        
                        this.Hide();
                        EditingPositionsForm editingPositionsForm = new EditingPositionsForm();
                        editingPositionsForm.label_AddNewPosition.ForeColor = Color.Green;
                        editingPositionsForm.label_AddNewPosition.Text = message;
                        editingPositionsForm.Show();
                    }


                }
                catch
                {
                    this.Hide();
                    positionsForm.label_AddNewPosition.ForeColor = Color.OrangeRed;
                    positionsForm.label_AddNewPosition.Text = "В поле зарплаты указаны спецсимволы!";
                    positionsForm.Show();

                }


            }
            else
            {
                
                label_AddNewPosition.ForeColor = Color.OrangeRed;
                label_AddNewPosition.Text = "Введите все данные!";
            }



        }
        private void DeletePosition_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_SelectPositionForDelete.SelectedItem != null)
                {
                    string deletemessage = $"При удалении этой должности вы потеряете информацию о сотрудниках. Удалить эту позицию?";
                    if (MessageBox.Show(deletemessage, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        editingPositions.DeletePosition(comboBox_SelectPositionForDelete.SelectedItem.ToString());
                        this.Hide();
                        positionsForm = new EditingPositionsForm();
                        positionsForm.label_DeletePositon.ForeColor = Color.DarkGreen;
                        positionsForm.label_DeletePositon.Text = "Операция прошла успешно!";
                        positionsForm.Show();
                        //positionsForm = new EditingPositionsForm();
                        //positionsForm.Close();


                    }
                    else
                    {
                        label_DeletePositon.ForeColor = Color.OrangeRed;
                        label_DeletePositon.Text = "Введите id чтобы удалить сотрудника!";
                    }

                }
            }
            catch
            {
                label_DeletePositon.ForeColor = Color.Red;
                label_DeletePositon.Text = "Вы ввели некоректные данные!";
            }
            
           
        }
        private void UpdatePosition_Button_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            try
            {
                if (textBox_ChangePosition.Text != "" & comboBox_UpdatePostion.SelectedItem != null)
                {
                    message = editingPositions.UpdatePosition(textBox_ChangePosition.Text, comboBox_UpdatePostion.SelectedItem.ToString());
                }
                else
                {
                    label_ChangePosition.ForeColor = Color.OrangeRed;
                    label_ChangePosition.Text = "Введите новую зарплату и id!";
                }
                if (message.Contains("специальные"))
                {
                    positionsForm.label_ChangePosition.ForeColor = Color.Red;
                    positionsForm.label_ChangePosition.Text = message;

                }
                else
                {
                    this.Hide();
                    EditingPositionsForm editingPositions = new EditingPositionsForm();
                    editingPositions.label_ChangePosition.ForeColor = Color.Green;
                    editingPositions.label_ChangePosition.Text = message;
                    editingPositions.Show();
                }

            }
            catch
            {
                label_ChangePosition.ForeColor = Color.Red;
                label_ChangePosition.Text = "Вы ввели некоректные данные!";

            }
            
            //positionsForm = new EditingPositionsForm();
            
            //positionsForm.Show();
            //positionsForm = new EditingPositionsForm();
            //positionsForm.Close();



        }
        private void UpdateSalary_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_AddnewSalary.Text != "" & comboBox_NewSalaryForPosition.SelectedItem != null)
                {
                    editingPositions.UpdateSalary(Convert.ToDecimal(textBox_AddnewSalary.Text), comboBox_NewSalaryForPosition.SelectedItem.ToString());
                    this.Hide();
                    
                    positionsForm = new EditingPositionsForm();
                    positionsForm.label_ChangeSalaryPosition.ForeColor = Color.DarkGreen;
                    positionsForm.label_ChangeSalaryPosition.Text = "Операция прошла успешно!";
                    positionsForm.Show();
                    //positionsForm = new EditingPositionsForm();
                    //positionsForm.Close();

                }
                else
                {
                    label_ChangeSalaryPosition.ForeColor = Color.Orange;
                    label_ChangeSalaryPosition.Text = "Заполните все поля!";
                }

            }
            catch
            {
                label_ChangeSalaryPosition.ForeColor = Color.Red;
                label_ChangeSalaryPosition.Text = "Вы ввели некоректные данные!";

            }
            

        }
        private void CloseApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
