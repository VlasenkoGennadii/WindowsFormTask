
namespace Ukrposhta
{
    partial class EditingDepartmentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Departments = new System.Windows.Forms.DataGridView();
            this.addnewdepartment_label = new System.Windows.Forms.Label();
            this.newnamedepartment_label = new System.Windows.Forms.Label();
            this.textBox_AddDepartment = new System.Windows.Forms.TextBox();
            this.AddNewDepartment_Button = new System.Windows.Forms.Button();
            this.departments_label = new System.Windows.Forms.Label();
            this.deletedepartment_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteDepartment_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_AddNewNameDepartment = new System.Windows.Forms.TextBox();
            this.UpdateDepartment_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectDepartmentforRenamecomboBox = new System.Windows.Forms.ComboBox();
            this.label_error_AddDepertment = new System.Windows.Forms.Label();
            this.label_deleteDepartment = new System.Windows.Forms.Label();
            this.label_UpdateDepartment = new System.Windows.Forms.Label();
            this.comboBox_SelectDeleteDepartment = new System.Windows.Forms.ComboBox();
            this.Back_Employee_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Departments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Departments
            // 
            this.dataGridView_Departments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Departments.Location = new System.Drawing.Point(109, 38);
            this.dataGridView_Departments.Name = "dataGridView_Departments";
            this.dataGridView_Departments.Size = new System.Drawing.Size(142, 400);
            this.dataGridView_Departments.TabIndex = 0;
            // 
            // addnewdepartment_label
            // 
            this.addnewdepartment_label.AutoSize = true;
            this.addnewdepartment_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addnewdepartment_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addnewdepartment_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addnewdepartment_label.Location = new System.Drawing.Point(303, 38);
            this.addnewdepartment_label.Name = "addnewdepartment_label";
            this.addnewdepartment_label.Size = new System.Drawing.Size(124, 13);
            this.addnewdepartment_label.TabIndex = 1;
            this.addnewdepartment_label.Text = "Добавить новый отдел";
            // 
            // newnamedepartment_label
            // 
            this.newnamedepartment_label.AutoSize = true;
            this.newnamedepartment_label.Location = new System.Drawing.Point(303, 64);
            this.newnamedepartment_label.Name = "newnamedepartment_label";
            this.newnamedepartment_label.Size = new System.Drawing.Size(141, 13);
            this.newnamedepartment_label.TabIndex = 2;
            this.newnamedepartment_label.Text = "Введите название отдела:\r\n";
            // 
            // textBox_AddDepartment
            // 
            this.textBox_AddDepartment.Location = new System.Drawing.Point(450, 56);
            this.textBox_AddDepartment.Multiline = true;
            this.textBox_AddDepartment.Name = "textBox_AddDepartment";
            this.textBox_AddDepartment.Size = new System.Drawing.Size(157, 25);
            this.textBox_AddDepartment.TabIndex = 3;
            // 
            // AddNewDepartment_Button
            // 
            this.AddNewDepartment_Button.Location = new System.Drawing.Point(630, 58);
            this.AddNewDepartment_Button.Name = "AddNewDepartment_Button";
            this.AddNewDepartment_Button.Size = new System.Drawing.Size(120, 25);
            this.AddNewDepartment_Button.TabIndex = 4;
            this.AddNewDepartment_Button.Text = "Применить";
            this.AddNewDepartment_Button.UseVisualStyleBackColor = true;
            this.AddNewDepartment_Button.Click += new System.EventHandler(this.AddNewDepartment_button);
            // 
            // departments_label
            // 
            this.departments_label.AutoSize = true;
            this.departments_label.Location = new System.Drawing.Point(177, 12);
            this.departments_label.Name = "departments_label";
            this.departments_label.Size = new System.Drawing.Size(46, 13);
            this.departments_label.TabIndex = 5;
            this.departments_label.Text = "Отделы";
            // 
            // deletedepartment_label
            // 
            this.deletedepartment_label.AutoSize = true;
            this.deletedepartment_label.ForeColor = System.Drawing.Color.Red;
            this.deletedepartment_label.Location = new System.Drawing.Point(308, 129);
            this.deletedepartment_label.Name = "deletedepartment_label";
            this.deletedepartment_label.Size = new System.Drawing.Size(82, 13);
            this.deletedepartment_label.TabIndex = 6;
            this.deletedepartment_label.Text = "Удалить отдел";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите отдел который хотите удалить: ";
            // 
            // DeleteDepartment_Button
            // 
            this.DeleteDepartment_Button.Location = new System.Drawing.Point(680, 149);
            this.DeleteDepartment_Button.Name = "DeleteDepartment_Button";
            this.DeleteDepartment_Button.Size = new System.Drawing.Size(117, 23);
            this.DeleteDepartment_Button.TabIndex = 9;
            this.DeleteDepartment_Button.Text = "Применить";
            this.DeleteDepartment_Button.UseVisualStyleBackColor = true;
            this.DeleteDepartment_Button.Click += new System.EventHandler(this.DeleteDepartment_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(306, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Чтобы изменить данные в таблице Departments:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Введите новое название для отдела:";
            // 
            // textBox_AddNewNameDepartment
            // 
            this.textBox_AddNewNameDepartment.Location = new System.Drawing.Point(504, 242);
            this.textBox_AddNewNameDepartment.Multiline = true;
            this.textBox_AddNewNameDepartment.Name = "textBox_AddNewNameDepartment";
            this.textBox_AddNewNameDepartment.Size = new System.Drawing.Size(146, 20);
            this.textBox_AddNewNameDepartment.TabIndex = 12;
            // 
            // UpdateDepartment_Button
            // 
            this.UpdateDepartment_Button.Location = new System.Drawing.Point(732, 272);
            this.UpdateDepartment_Button.Name = "UpdateDepartment_Button";
            this.UpdateDepartment_Button.Size = new System.Drawing.Size(117, 23);
            this.UpdateDepartment_Button.TabIndex = 13;
            this.UpdateDepartment_Button.Text = "Применить";
            this.UpdateDepartment_Button.UseVisualStyleBackColor = true;
            this.UpdateDepartment_Button.Click += new System.EventHandler(this.UpdateDepartment_ButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Выберите отдел который хотите переименовать:";
            // 
            // SelectDepartmentforRenamecomboBox
            // 
            this.SelectDepartmentforRenamecomboBox.FormattingEnabled = true;
            this.SelectDepartmentforRenamecomboBox.Location = new System.Drawing.Point(570, 274);
            this.SelectDepartmentforRenamecomboBox.Name = "SelectDepartmentforRenamecomboBox";
            this.SelectDepartmentforRenamecomboBox.Size = new System.Drawing.Size(146, 21);
            this.SelectDepartmentforRenamecomboBox.TabIndex = 15;
            // 
            // label_error_AddDepertment
            // 
            this.label_error_AddDepertment.AutoSize = true;
            this.label_error_AddDepertment.Location = new System.Drawing.Point(450, 88);
            this.label_error_AddDepertment.Name = "label_error_AddDepertment";
            this.label_error_AddDepertment.Size = new System.Drawing.Size(0, 13);
            this.label_error_AddDepertment.TabIndex = 17;
            // 
            // label_deleteDepartment
            // 
            this.label_deleteDepartment.AutoSize = true;
            this.label_deleteDepartment.Location = new System.Drawing.Point(544, 177);
            this.label_deleteDepartment.Name = "label_deleteDepartment";
            this.label_deleteDepartment.Size = new System.Drawing.Size(0, 13);
            this.label_deleteDepartment.TabIndex = 18;
            // 
            // label_UpdateDepartment
            // 
            this.label_UpdateDepartment.AutoSize = true;
            this.label_UpdateDepartment.Location = new System.Drawing.Point(344, 310);
            this.label_UpdateDepartment.Name = "label_UpdateDepartment";
            this.label_UpdateDepartment.Size = new System.Drawing.Size(0, 13);
            this.label_UpdateDepartment.TabIndex = 19;
            // 
            // comboBox_SelectDeleteDepartment
            // 
            this.comboBox_SelectDeleteDepartment.FormattingEnabled = true;
            this.comboBox_SelectDeleteDepartment.Location = new System.Drawing.Point(541, 149);
            this.comboBox_SelectDeleteDepartment.Name = "comboBox_SelectDeleteDepartment";
            this.comboBox_SelectDeleteDepartment.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SelectDeleteDepartment.TabIndex = 20;
            // 
            // Back_Employee_button
            // 
            this.Back_Employee_button.Location = new System.Drawing.Point(12, 38);
            this.Back_Employee_button.Name = "Back_Employee_button";
            this.Back_Employee_button.Size = new System.Drawing.Size(75, 38);
            this.Back_Employee_button.TabIndex = 33;
            this.Back_Employee_button.Text = "Назад";
            this.Back_Employee_button.UseVisualStyleBackColor = true;
            this.Back_Employee_button.Click += new System.EventHandler(this.Back_Employee_button_Click);
            // 
            // EditingDepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.Back_Employee_button);
            this.Controls.Add(this.comboBox_SelectDeleteDepartment);
            this.Controls.Add(this.label_UpdateDepartment);
            this.Controls.Add(this.label_deleteDepartment);
            this.Controls.Add(this.label_error_AddDepertment);
            this.Controls.Add(this.SelectDepartmentforRenamecomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UpdateDepartment_Button);
            this.Controls.Add(this.textBox_AddNewNameDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteDepartment_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletedepartment_label);
            this.Controls.Add(this.departments_label);
            this.Controls.Add(this.AddNewDepartment_Button);
            this.Controls.Add(this.textBox_AddDepartment);
            this.Controls.Add(this.newnamedepartment_label);
            this.Controls.Add(this.addnewdepartment_label);
            this.Controls.Add(this.dataGridView_Departments);
            this.Name = "EditingDepartmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Departments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Departments;
        private System.Windows.Forms.Label addnewdepartment_label;
        private System.Windows.Forms.Label newnamedepartment_label;
        private System.Windows.Forms.TextBox textBox_AddDepartment;
        private System.Windows.Forms.Button AddNewDepartment_Button;
        private System.Windows.Forms.Label departments_label;
        private System.Windows.Forms.Label deletedepartment_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteDepartment_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_AddNewNameDepartment;
        private System.Windows.Forms.Button UpdateDepartment_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SelectDepartmentforRenamecomboBox;
        private System.Windows.Forms.Label label_error_AddDepertment;
        private System.Windows.Forms.Label label_deleteDepartment;
        private System.Windows.Forms.Label label_UpdateDepartment;
        private System.Windows.Forms.ComboBox comboBox_SelectDeleteDepartment;
        private System.Windows.Forms.Button Back_Employee_button;
    }
}