
namespace Ukrposhta
{
    partial class PayoutsForm
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
            this.dataGridView_Payonuts = new System.Windows.Forms.DataGridView();
            this.Back_Payouts_button = new System.Windows.Forms.Button();
            this.comboBox_SelectDepartment = new System.Windows.Forms.ComboBox();
            this.button_ShowDepartmentPayouts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Payonuts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Payonuts
            // 
            this.dataGridView_Payonuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Payonuts.Location = new System.Drawing.Point(120, 38);
            this.dataGridView_Payonuts.Name = "dataGridView_Payonuts";
            this.dataGridView_Payonuts.Size = new System.Drawing.Size(140, 71);
            this.dataGridView_Payonuts.TabIndex = 0;
            // 
            // Back_Payouts_button
            // 
            this.Back_Payouts_button.Location = new System.Drawing.Point(13, 38);
            this.Back_Payouts_button.Name = "Back_Payouts_button";
            this.Back_Payouts_button.Size = new System.Drawing.Size(75, 38);
            this.Back_Payouts_button.TabIndex = 31;
            this.Back_Payouts_button.Text = "Назад";
            this.Back_Payouts_button.UseVisualStyleBackColor = true;
            this.Back_Payouts_button.Click += new System.EventHandler(this.Back_Payouts_button_Click);
            // 
            // comboBox_SelectDepartment
            // 
            this.comboBox_SelectDepartment.FormattingEnabled = true;
            this.comboBox_SelectDepartment.Items.AddRange(new object[] {
            "All Departments"});
            this.comboBox_SelectDepartment.Location = new System.Drawing.Point(276, 38);
            this.comboBox_SelectDepartment.Name = "comboBox_SelectDepartment";
            this.comboBox_SelectDepartment.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SelectDepartment.TabIndex = 32;
            // 
            // button_ShowDepartmentPayouts
            // 
            this.button_ShowDepartmentPayouts.Location = new System.Drawing.Point(415, 38);
            this.button_ShowDepartmentPayouts.Name = "button_ShowDepartmentPayouts";
            this.button_ShowDepartmentPayouts.Size = new System.Drawing.Size(122, 23);
            this.button_ShowDepartmentPayouts.TabIndex = 33;
            this.button_ShowDepartmentPayouts.Text = "Применить";
            this.button_ShowDepartmentPayouts.UseVisualStyleBackColor = true;
            this.button_ShowDepartmentPayouts.Click += new System.EventHandler(this.ShowSelectedDepartmentPayouts);
            // 
            // PayoutsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ShowDepartmentPayouts);
            this.Controls.Add(this.comboBox_SelectDepartment);
            this.Controls.Add(this.Back_Payouts_button);
            this.Controls.Add(this.dataGridView_Payonuts);
            this.Name = "PayoutsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payouts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Payonuts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Payonuts;
        private System.Windows.Forms.Button Back_Payouts_button;
        private System.Windows.Forms.ComboBox comboBox_SelectDepartment;
        private System.Windows.Forms.Button button_ShowDepartmentPayouts;
    }
}