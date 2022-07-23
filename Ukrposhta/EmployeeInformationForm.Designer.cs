
namespace Ukrposhta
{
    partial class EmployeeInformationForm
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
            this.dataGridView_EmployeeInformation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_DeleteEmployee = new System.Windows.Forms.Button();
            this.label_ChangeName = new System.Windows.Forms.Label();
            this.FirstName_textbox = new System.Windows.Forms.TextBox();
            this.label_ChangeLastName = new System.Windows.Forms.Label();
            this.LastName_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MiddleName_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Phone_textbox = new System.Windows.Forms.TextBox();
            this.label_ChangeAddress = new System.Windows.Forms.Label();
            this.Adress_textbox = new System.Windows.Forms.TextBox();
            this.label_Position = new System.Windows.Forms.Label();
            this.comboBox_SelectPosition = new System.Windows.Forms.ComboBox();
            this.label_Bonus = new System.Windows.Forms.Label();
            this.comboBox_SelectBonus = new System.Windows.Forms.ComboBox();
            this.button_ChangeEmployee = new System.Windows.Forms.Button();
            this.label_Update = new System.Windows.Forms.Label();
            this.Back_Employee_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_EmployeeInformation
            // 
            this.dataGridView_EmployeeInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EmployeeInformation.Location = new System.Drawing.Point(112, 38);
            this.dataGridView_EmployeeInformation.Name = "dataGridView_EmployeeInformation";
            this.dataGridView_EmployeeInformation.Size = new System.Drawing.Size(676, 66);
            this.dataGridView_EmployeeInformation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(109, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Удалить этого сотрудника: ";
            // 
            // button_DeleteEmployee
            // 
            this.button_DeleteEmployee.Location = new System.Drawing.Point(263, 117);
            this.button_DeleteEmployee.Name = "button_DeleteEmployee";
            this.button_DeleteEmployee.Size = new System.Drawing.Size(75, 25);
            this.button_DeleteEmployee.TabIndex = 2;
            this.button_DeleteEmployee.Text = "Применить";
            this.button_DeleteEmployee.UseVisualStyleBackColor = true;
            this.button_DeleteEmployee.Click += new System.EventHandler(this.button_DeleteEmployee_Click);
            // 
            // label_ChangeName
            // 
            this.label_ChangeName.AutoSize = true;
            this.label_ChangeName.Location = new System.Drawing.Point(109, 174);
            this.label_ChangeName.Name = "label_ChangeName";
            this.label_ChangeName.Size = new System.Drawing.Size(110, 13);
            this.label_ChangeName.TabIndex = 3;
            this.label_ChangeName.Text = "Редактировать имя:";
            // 
            // FirstName_textbox
            // 
            this.FirstName_textbox.Location = new System.Drawing.Point(261, 171);
            this.FirstName_textbox.Name = "FirstName_textbox";
            this.FirstName_textbox.Size = new System.Drawing.Size(130, 20);
            this.FirstName_textbox.TabIndex = 4;
            // 
            // label_ChangeLastName
            // 
            this.label_ChangeLastName.AutoSize = true;
            this.label_ChangeLastName.Location = new System.Drawing.Point(109, 210);
            this.label_ChangeLastName.Name = "label_ChangeLastName";
            this.label_ChangeLastName.Size = new System.Drawing.Size(138, 13);
            this.label_ChangeLastName.TabIndex = 5;
            this.label_ChangeLastName.Text = "Редактировать фамилию:";
            // 
            // LastName_textbox
            // 
            this.LastName_textbox.Location = new System.Drawing.Point(261, 210);
            this.LastName_textbox.Name = "LastName_textbox";
            this.LastName_textbox.Size = new System.Drawing.Size(130, 20);
            this.LastName_textbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Редактировать отчество:";
            // 
            // MiddleName_textbox
            // 
            this.MiddleName_textbox.Location = new System.Drawing.Point(261, 247);
            this.MiddleName_textbox.Name = "MiddleName_textbox";
            this.MiddleName_textbox.Size = new System.Drawing.Size(130, 20);
            this.MiddleName_textbox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Редактировать телефон:";
            // 
            // Phone_textbox
            // 
            this.Phone_textbox.Location = new System.Drawing.Point(261, 290);
            this.Phone_textbox.Name = "Phone_textbox";
            this.Phone_textbox.Size = new System.Drawing.Size(130, 20);
            this.Phone_textbox.TabIndex = 10;
            // 
            // label_ChangeAddress
            // 
            this.label_ChangeAddress.AutoSize = true;
            this.label_ChangeAddress.Location = new System.Drawing.Point(109, 327);
            this.label_ChangeAddress.Name = "label_ChangeAddress";
            this.label_ChangeAddress.Size = new System.Drawing.Size(120, 13);
            this.label_ChangeAddress.TabIndex = 11;
            this.label_ChangeAddress.Text = "Редактировать адрес:";
            // 
            // Adress_textbox
            // 
            this.Adress_textbox.Location = new System.Drawing.Point(261, 324);
            this.Adress_textbox.Name = "Adress_textbox";
            this.Adress_textbox.Size = new System.Drawing.Size(130, 20);
            this.Adress_textbox.TabIndex = 12;
            // 
            // label_Position
            // 
            this.label_Position.AutoSize = true;
            this.label_Position.Location = new System.Drawing.Point(109, 361);
            this.label_Position.Name = "label_Position";
            this.label_Position.Size = new System.Drawing.Size(119, 13);
            this.label_Position.TabIndex = 13;
            this.label_Position.Text = "Изменить должность:";
            // 
            // comboBox_SelectPosition
            // 
            this.comboBox_SelectPosition.FormattingEnabled = true;
            this.comboBox_SelectPosition.Location = new System.Drawing.Point(261, 358);
            this.comboBox_SelectPosition.Name = "comboBox_SelectPosition";
            this.comboBox_SelectPosition.Size = new System.Drawing.Size(130, 21);
            this.comboBox_SelectPosition.TabIndex = 14;
            // 
            // label_Bonus
            // 
            this.label_Bonus.AutoSize = true;
            this.label_Bonus.Location = new System.Drawing.Point(109, 393);
            this.label_Bonus.Name = "label_Bonus";
            this.label_Bonus.Size = new System.Drawing.Size(93, 13);
            this.label_Bonus.TabIndex = 15;
            this.label_Bonus.Text = "Изменить бонус:";
            // 
            // comboBox_SelectBonus
            // 
            this.comboBox_SelectBonus.FormattingEnabled = true;
            this.comboBox_SelectBonus.Location = new System.Drawing.Point(261, 390);
            this.comboBox_SelectBonus.Name = "comboBox_SelectBonus";
            this.comboBox_SelectBonus.Size = new System.Drawing.Size(130, 21);
            this.comboBox_SelectBonus.TabIndex = 16;
            // 
            // button_ChangeEmployee
            // 
            this.button_ChangeEmployee.Location = new System.Drawing.Point(420, 390);
            this.button_ChangeEmployee.Name = "button_ChangeEmployee";
            this.button_ChangeEmployee.Size = new System.Drawing.Size(75, 25);
            this.button_ChangeEmployee.TabIndex = 17;
            this.button_ChangeEmployee.Text = "Применить";
            this.button_ChangeEmployee.UseVisualStyleBackColor = true;
            this.button_ChangeEmployee.Click += new System.EventHandler(this.button_ChangeEmployee_Click);
            // 
            // label_Update
            // 
            this.label_Update.AutoSize = true;
            this.label_Update.Location = new System.Drawing.Point(417, 269);
            this.label_Update.Name = "label_Update";
            this.label_Update.Size = new System.Drawing.Size(0, 13);
            this.label_Update.TabIndex = 18;
            // 
            // Back_Employee_button
            // 
            this.Back_Employee_button.Location = new System.Drawing.Point(13, 38);
            this.Back_Employee_button.Name = "Back_Employee_button";
            this.Back_Employee_button.Size = new System.Drawing.Size(75, 38);
            this.Back_Employee_button.TabIndex = 32;
            this.Back_Employee_button.Text = "Назад";
            this.Back_Employee_button.UseVisualStyleBackColor = true;
            this.Back_Employee_button.Click += new System.EventHandler(this.Back_Employee_button_Click);
            // 
            // EmployeeInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_Employee_button);
            this.Controls.Add(this.label_Update);
            this.Controls.Add(this.button_ChangeEmployee);
            this.Controls.Add(this.comboBox_SelectBonus);
            this.Controls.Add(this.label_Bonus);
            this.Controls.Add(this.comboBox_SelectPosition);
            this.Controls.Add(this.label_Position);
            this.Controls.Add(this.Adress_textbox);
            this.Controls.Add(this.label_ChangeAddress);
            this.Controls.Add(this.Phone_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MiddleName_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastName_textbox);
            this.Controls.Add(this.label_ChangeLastName);
            this.Controls.Add(this.FirstName_textbox);
            this.Controls.Add(this.label_ChangeName);
            this.Controls.Add(this.button_DeleteEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_EmployeeInformation);
            this.Name = "EmployeeInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_EmployeeInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_DeleteEmployee;
        private System.Windows.Forms.Label label_ChangeName;
        private System.Windows.Forms.TextBox FirstName_textbox;
        private System.Windows.Forms.Label label_ChangeLastName;
        private System.Windows.Forms.TextBox LastName_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MiddleName_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Phone_textbox;
        private System.Windows.Forms.Label label_ChangeAddress;
        private System.Windows.Forms.TextBox Adress_textbox;
        private System.Windows.Forms.Label label_Position;
        private System.Windows.Forms.ComboBox comboBox_SelectPosition;
        private System.Windows.Forms.Label label_Bonus;
        private System.Windows.Forms.ComboBox comboBox_SelectBonus;
        private System.Windows.Forms.Button button_ChangeEmployee;
        private System.Windows.Forms.Label label_Update;
        private System.Windows.Forms.Button Back_Employee_button;
    }
}