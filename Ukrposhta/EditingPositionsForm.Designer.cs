
namespace Ukrposhta
{
    partial class EditingPositionsForm
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
            System.Windows.Forms.Label addnewdepartment_label;
            this.dataGridView_Positions = new System.Windows.Forms.DataGridView();
            this.DeletePosition_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deletedepartment_label = new System.Windows.Forms.Label();
            this.AddNewPosition_Button = new System.Windows.Forms.Button();
            this.textBox_AddNewPosition = new System.Windows.Forms.TextBox();
            this.newnamedepartment_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ChangePosition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdatePosition_Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Введите = new System.Windows.Forms.Label();
            this.textBox_AddnewSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateSalary_Button = new System.Windows.Forms.Button();
            this.Back_Position_button = new System.Windows.Forms.Button();
            this.label_AddNewPosition = new System.Windows.Forms.Label();
            this.label_DeletePositon = new System.Windows.Forms.Label();
            this.label_ChangePosition = new System.Windows.Forms.Label();
            this.label_ChangeSalaryPosition = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_AddSalaryForNewPosition = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_SelectDepartmentForNewPosition = new System.Windows.Forms.ComboBox();
            this.comboBox_SelectPositionForDelete = new System.Windows.Forms.ComboBox();
            this.comboBox_UpdatePostion = new System.Windows.Forms.ComboBox();
            this.comboBox_NewSalaryForPosition = new System.Windows.Forms.ComboBox();
            addnewdepartment_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Positions)).BeginInit();
            this.SuspendLayout();
            // 
            // addnewdepartment_label
            // 
            addnewdepartment_label.AutoSize = true;
            addnewdepartment_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addnewdepartment_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addnewdepartment_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            addnewdepartment_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            addnewdepartment_label.Location = new System.Drawing.Point(272, 38);
            addnewdepartment_label.Name = "addnewdepartment_label";
            addnewdepartment_label.Size = new System.Drawing.Size(177, 13);
            addnewdepartment_label.TabIndex = 10;
            addnewdepartment_label.Text = "Добавить новую должность ";
            // 
            // dataGridView_Positions
            // 
            this.dataGridView_Positions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Positions.Location = new System.Drawing.Point(100, 38);
            this.dataGridView_Positions.Name = "dataGridView_Positions";
            this.dataGridView_Positions.Size = new System.Drawing.Size(144, 449);
            this.dataGridView_Positions.TabIndex = 1;
            // 
            // DeletePosition_Button
            // 
            this.DeletePosition_Button.Location = new System.Drawing.Point(665, 190);
            this.DeletePosition_Button.Name = "DeletePosition_Button";
            this.DeletePosition_Button.Size = new System.Drawing.Size(117, 25);
            this.DeletePosition_Button.TabIndex = 17;
            this.DeletePosition_Button.Text = "Применить";
            this.DeletePosition_Button.UseVisualStyleBackColor = true;
            this.DeletePosition_Button.Click += new System.EventHandler(this.DeletePosition_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Выберите должность которую хотите удалить: ";
            // 
            // deletedepartment_label
            // 
            this.deletedepartment_label.AutoSize = true;
            this.deletedepartment_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletedepartment_label.ForeColor = System.Drawing.Color.Red;
            this.deletedepartment_label.Location = new System.Drawing.Point(272, 169);
            this.deletedepartment_label.Name = "deletedepartment_label";
            this.deletedepartment_label.Size = new System.Drawing.Size(125, 13);
            this.deletedepartment_label.TabIndex = 14;
            this.deletedepartment_label.Text = "Удалить должность";
            // 
            // AddNewPosition_Button
            // 
            this.AddNewPosition_Button.Location = new System.Drawing.Point(694, 114);
            this.AddNewPosition_Button.Name = "AddNewPosition_Button";
            this.AddNewPosition_Button.Size = new System.Drawing.Size(120, 25);
            this.AddNewPosition_Button.TabIndex = 13;
            this.AddNewPosition_Button.Text = "Применить";
            this.AddNewPosition_Button.UseVisualStyleBackColor = true;
            this.AddNewPosition_Button.Click += new System.EventHandler(this.AddNewPosition_Button_Click);
            // 
            // textBox_AddNewPosition
            // 
            this.textBox_AddNewPosition.Location = new System.Drawing.Point(444, 57);
            this.textBox_AddNewPosition.Multiline = true;
            this.textBox_AddNewPosition.Name = "textBox_AddNewPosition";
            this.textBox_AddNewPosition.Size = new System.Drawing.Size(157, 25);
            this.textBox_AddNewPosition.TabIndex = 12;
            // 
            // newnamedepartment_label
            // 
            this.newnamedepartment_label.AutoSize = true;
            this.newnamedepartment_label.Location = new System.Drawing.Point(272, 64);
            this.newnamedepartment_label.Name = "newnamedepartment_label";
            this.newnamedepartment_label.Size = new System.Drawing.Size(161, 13);
            this.newnamedepartment_label.TabIndex = 11;
            this.newnamedepartment_label.Text = "Введите название должности:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(275, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Изменить название должности:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Введите новое название должности:";
            // 
            // textBox_ChangePosition
            // 
            this.textBox_ChangePosition.Location = new System.Drawing.Point(475, 290);
            this.textBox_ChangePosition.Multiline = true;
            this.textBox_ChangePosition.Name = "textBox_ChangePosition";
            this.textBox_ChangePosition.Size = new System.Drawing.Size(123, 25);
            this.textBox_ChangePosition.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Для какой должности применить новое название:";
            // 
            // UpdatePosition_Button
            // 
            this.UpdatePosition_Button.Location = new System.Drawing.Point(676, 336);
            this.UpdatePosition_Button.Name = "UpdatePosition_Button";
            this.UpdatePosition_Button.Size = new System.Drawing.Size(117, 25);
            this.UpdatePosition_Button.TabIndex = 23;
            this.UpdatePosition_Button.Text = "Применить";
            this.UpdatePosition_Button.UseVisualStyleBackColor = true;
            this.UpdatePosition_Button.Click += new System.EventHandler(this.UpdatePosition_Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(272, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Изменить зарплату сотрудника:";
            // 
            // Введите
            // 
            this.Введите.AutoSize = true;
            this.Введите.Location = new System.Drawing.Point(272, 444);
            this.Введите.Name = "Введите";
            this.Введите.Size = new System.Drawing.Size(135, 13);
            this.Введите.TabIndex = 25;
            this.Введите.Text = "Введите новую зарплату:";
            // 
            // textBox_AddnewSalary
            // 
            this.textBox_AddnewSalary.Location = new System.Drawing.Point(413, 432);
            this.textBox_AddnewSalary.Multiline = true;
            this.textBox_AddnewSalary.Name = "textBox_AddnewSalary";
            this.textBox_AddnewSalary.Size = new System.Drawing.Size(100, 25);
            this.textBox_AddnewSalary.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(326, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Выберите для какой должности вы хотите изменить зарплату:\r\n";
            // 
            // UpdateSalary_Button
            // 
            this.UpdateSalary_Button.Location = new System.Drawing.Point(745, 470);
            this.UpdateSalary_Button.Name = "UpdateSalary_Button";
            this.UpdateSalary_Button.Size = new System.Drawing.Size(98, 25);
            this.UpdateSalary_Button.TabIndex = 29;
            this.UpdateSalary_Button.Text = "Применить";
            this.UpdateSalary_Button.UseVisualStyleBackColor = true;
            this.UpdateSalary_Button.Click += new System.EventHandler(this.UpdateSalary_Button_Click);
            // 
            // Back_Position_button
            // 
            this.Back_Position_button.Location = new System.Drawing.Point(13, 38);
            this.Back_Position_button.Name = "Back_Position_button";
            this.Back_Position_button.Size = new System.Drawing.Size(75, 38);
            this.Back_Position_button.TabIndex = 30;
            this.Back_Position_button.Text = "Назад";
            this.Back_Position_button.UseVisualStyleBackColor = true;
            this.Back_Position_button.Click += new System.EventHandler(this.Back_Position_button_Click);
            // 
            // label_AddNewPosition
            // 
            this.label_AddNewPosition.AutoSize = true;
            this.label_AddNewPosition.Location = new System.Drawing.Point(483, 92);
            this.label_AddNewPosition.Name = "label_AddNewPosition";
            this.label_AddNewPosition.Size = new System.Drawing.Size(0, 13);
            this.label_AddNewPosition.TabIndex = 31;
            // 
            // label_DeletePositon
            // 
            this.label_DeletePositon.AutoSize = true;
            this.label_DeletePositon.Location = new System.Drawing.Point(526, 223);
            this.label_DeletePositon.Name = "label_DeletePositon";
            this.label_DeletePositon.Size = new System.Drawing.Size(0, 13);
            this.label_DeletePositon.TabIndex = 32;
            // 
            // label_ChangePosition
            // 
            this.label_ChangePosition.AutoSize = true;
            this.label_ChangePosition.Location = new System.Drawing.Point(475, 372);
            this.label_ChangePosition.Name = "label_ChangePosition";
            this.label_ChangePosition.Size = new System.Drawing.Size(0, 13);
            this.label_ChangePosition.TabIndex = 33;
            // 
            // label_ChangeSalaryPosition
            // 
            this.label_ChangeSalaryPosition.AutoSize = true;
            this.label_ChangeSalaryPosition.Location = new System.Drawing.Point(604, 444);
            this.label_ChangeSalaryPosition.Name = "label_ChangeSalaryPosition";
            this.label_ChangeSalaryPosition.Size = new System.Drawing.Size(0, 13);
            this.label_ChangeSalaryPosition.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Введите зарплату:";
            // 
            // textBox_AddSalaryForNewPosition
            // 
            this.textBox_AddSalaryForNewPosition.Location = new System.Drawing.Point(382, 88);
            this.textBox_AddSalaryForNewPosition.Name = "textBox_AddSalaryForNewPosition";
            this.textBox_AddSalaryForNewPosition.Size = new System.Drawing.Size(76, 20);
            this.textBox_AddSalaryForNewPosition.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(272, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Виберите к каком отделу относится эта должность:";
            // 
            // comboBox_SelectDepartmentForNewPosition
            // 
            this.comboBox_SelectDepartmentForNewPosition.FormattingEnabled = true;
            this.comboBox_SelectDepartmentForNewPosition.Location = new System.Drawing.Point(553, 117);
            this.comboBox_SelectDepartmentForNewPosition.Name = "comboBox_SelectDepartmentForNewPosition";
            this.comboBox_SelectDepartmentForNewPosition.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SelectDepartmentForNewPosition.TabIndex = 38;
            // 
            // comboBox_SelectPositionForDelete
            // 
            this.comboBox_SelectPositionForDelete.FormattingEnabled = true;
            this.comboBox_SelectPositionForDelete.Location = new System.Drawing.Point(515, 194);
            this.comboBox_SelectPositionForDelete.Name = "comboBox_SelectPositionForDelete";
            this.comboBox_SelectPositionForDelete.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SelectPositionForDelete.TabIndex = 39;
            // 
            // comboBox_UpdatePostion
            // 
            this.comboBox_UpdatePostion.FormattingEnabled = true;
            this.comboBox_UpdatePostion.Location = new System.Drawing.Point(538, 339);
            this.comboBox_UpdatePostion.Name = "comboBox_UpdatePostion";
            this.comboBox_UpdatePostion.Size = new System.Drawing.Size(121, 21);
            this.comboBox_UpdatePostion.TabIndex = 40;
            // 
            // comboBox_NewSalaryForPosition
            // 
            this.comboBox_NewSalaryForPosition.FormattingEnabled = true;
            this.comboBox_NewSalaryForPosition.Location = new System.Drawing.Point(607, 471);
            this.comboBox_NewSalaryForPosition.Name = "comboBox_NewSalaryForPosition";
            this.comboBox_NewSalaryForPosition.Size = new System.Drawing.Size(121, 21);
            this.comboBox_NewSalaryForPosition.TabIndex = 41;
            // 
            // EditingPositionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 565);
            this.Controls.Add(this.comboBox_NewSalaryForPosition);
            this.Controls.Add(this.comboBox_UpdatePostion);
            this.Controls.Add(this.comboBox_SelectPositionForDelete);
            this.Controls.Add(this.comboBox_SelectDepartmentForNewPosition);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_AddSalaryForNewPosition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_ChangeSalaryPosition);
            this.Controls.Add(this.label_ChangePosition);
            this.Controls.Add(this.label_DeletePositon);
            this.Controls.Add(this.label_AddNewPosition);
            this.Controls.Add(this.Back_Position_button);
            this.Controls.Add(this.UpdateSalary_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_AddnewSalary);
            this.Controls.Add(this.Введите);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpdatePosition_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ChangePosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeletePosition_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletedepartment_label);
            this.Controls.Add(this.AddNewPosition_Button);
            this.Controls.Add(this.textBox_AddNewPosition);
            this.Controls.Add(this.newnamedepartment_label);
            this.Controls.Add(addnewdepartment_label);
            this.Controls.Add(this.dataGridView_Positions);
            this.Name = "EditingPositionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditingPositions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Positions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Positions;
        private System.Windows.Forms.Button DeletePosition_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label deletedepartment_label;
        private System.Windows.Forms.Button AddNewPosition_Button;
        private System.Windows.Forms.TextBox textBox_AddNewPosition;
        private System.Windows.Forms.Label newnamedepartment_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ChangePosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdatePosition_Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Введите;
        private System.Windows.Forms.TextBox textBox_AddnewSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button UpdateSalary_Button;
        private System.Windows.Forms.Button Back_Position_button;
        private System.Windows.Forms.Label label_AddNewPosition;
        private System.Windows.Forms.Label label_DeletePositon;
        private System.Windows.Forms.Label label_ChangePosition;
        private System.Windows.Forms.Label label_ChangeSalaryPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_AddSalaryForNewPosition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_SelectDepartmentForNewPosition;
        private System.Windows.Forms.ComboBox comboBox_SelectPositionForDelete;
        private System.Windows.Forms.ComboBox comboBox_UpdatePostion;
        private System.Windows.Forms.ComboBox comboBox_NewSalaryForPosition;
    }
}