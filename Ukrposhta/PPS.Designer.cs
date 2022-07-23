
namespace Ukrposhta
{
    partial class PPS
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_MainMenu = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеДолжностейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.выплатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectDepartment = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_SelectDepartmentMainMaenu = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MainMenu)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_MainMenu
            // 
            this.dataGridView_MainMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_MainMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MainMenu.Location = new System.Drawing.Point(96, 27);
            this.dataGridView_MainMenu.Name = "dataGridView_MainMenu";
            this.dataGridView_MainMenu.Size = new System.Drawing.Size(764, 327);
            this.dataGridView_MainMenu.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.редактированиеДолжностейToolStripMenuItem,
            this.toolStripMenuItem4,
            this.выплатыToolStripMenuItem,
            this.отчетToolStripMenuItem});
            this.helloToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.helloToolStripMenuItem.Text = "Меню";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(233, 22);
            this.toolStripMenuItem2.Text = "Редактирование отделов ";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.EditingDepartments_Menu);
            // 
            // редактированиеДолжностейToolStripMenuItem
            // 
            this.редактированиеДолжностейToolStripMenuItem.Name = "редактированиеДолжностейToolStripMenuItem";
            this.редактированиеДолжностейToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.редактированиеДолжностейToolStripMenuItem.Text = "Редактирование должностей";
            this.редактированиеДолжностейToolStripMenuItem.Click += new System.EventHandler(this.EditingPositions_Menu);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(233, 22);
            this.toolStripMenuItem4.Text = "Добавление сотрудника ";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.AddEmployee_Menu);
            // 
            // выплатыToolStripMenuItem
            // 
            this.выплатыToolStripMenuItem.Name = "выплатыToolStripMenuItem";
            this.выплатыToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.выплатыToolStripMenuItem.Text = "Выплаты";
            this.выплатыToolStripMenuItem.Click += new System.EventHandler(this.Payouts_Menu);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.отчетToolStripMenuItem.Text = "Отчет";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.ReportTextFile_butto);
            // 
            // SelectDepartment
            // 
            this.SelectDepartment.FormattingEnabled = true;
            this.SelectDepartment.Location = new System.Drawing.Point(866, 27);
            this.SelectDepartment.Name = "SelectDepartment";
            this.SelectDepartment.Size = new System.Drawing.Size(100, 184);
            this.SelectDepartment.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(866, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SelectedDepartments);
            // 
            // label_SelectDepartmentMainMaenu
            // 
            this.label_SelectDepartmentMainMaenu.AutoSize = true;
            this.label_SelectDepartmentMainMaenu.ForeColor = System.Drawing.Color.Red;
            this.label_SelectDepartmentMainMaenu.Location = new System.Drawing.Point(831, 260);
            this.label_SelectDepartmentMainMaenu.Name = "label_SelectDepartmentMainMaenu";
            this.label_SelectDepartmentMainMaenu.Size = new System.Drawing.Size(0, 13);
            this.label_SelectDepartmentMainMaenu.TabIndex = 4;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(866, 255);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(100, 42);
            this.update_button.TabIndex = 5;
            this.update_button.Text = "Обновить данные";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // Ukrposhta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(980, 452);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.label_SelectDepartmentMainMaenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SelectDepartment);
            this.Controls.Add(this.dataGridView_MainMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ukrposhta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PPS";
            this.Load += new System.EventHandler(this.Ukr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MainMenu)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_MainMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem выплатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox SelectDepartment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem редактированиеДолжностейToolStripMenuItem;
        private System.Windows.Forms.Label label_SelectDepartmentMainMaenu;
        private System.Windows.Forms.Button update_button;
    }
}

