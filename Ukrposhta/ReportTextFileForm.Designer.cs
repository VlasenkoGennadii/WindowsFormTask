
namespace Ukrposhta
{
    partial class ReportTextFileForm
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
            this.Back_Payouts_button = new System.Windows.Forms.Button();
            this.dataGridView_ReportText = new System.Windows.Forms.DataGridView();
            this.button_MakeTextFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label_Text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReportText)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_Payouts_button
            // 
            this.Back_Payouts_button.Location = new System.Drawing.Point(13, 38);
            this.Back_Payouts_button.Name = "Back_Payouts_button";
            this.Back_Payouts_button.Size = new System.Drawing.Size(75, 38);
            this.Back_Payouts_button.TabIndex = 32;
            this.Back_Payouts_button.Text = "Назад";
            this.Back_Payouts_button.UseVisualStyleBackColor = true;
            this.Back_Payouts_button.Click += new System.EventHandler(this.Back_Payouts_button_Click);
            // 
            // dataGridView_ReportText
            // 
            this.dataGridView_ReportText.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReportText.Location = new System.Drawing.Point(108, 38);
            this.dataGridView_ReportText.Name = "dataGridView_ReportText";
            this.dataGridView_ReportText.Size = new System.Drawing.Size(586, 400);
            this.dataGridView_ReportText.TabIndex = 33;
            // 
            // button_MakeTextFile
            // 
            this.button_MakeTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MakeTextFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_MakeTextFile.Location = new System.Drawing.Point(13, 97);
            this.button_MakeTextFile.Name = "button_MakeTextFile";
            this.button_MakeTextFile.Size = new System.Drawing.Size(75, 38);
            this.button_MakeTextFile.TabIndex = 34;
            this.button_MakeTextFile.Text = "Сделать выписку";
            this.button_MakeTextFile.UseVisualStyleBackColor = true;
            this.button_MakeTextFile.Click += new System.EventHandler(this.button_MakeTextFile_Click);
            // 
            // label_Text
            // 
            this.label_Text.AutoSize = true;
            this.label_Text.Location = new System.Drawing.Point(333, 9);
            this.label_Text.Name = "label_Text";
            this.label_Text.Size = new System.Drawing.Size(0, 13);
            this.label_Text.TabIndex = 35;
            // 
            // ReportTextFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Text);
            this.Controls.Add(this.button_MakeTextFile);
            this.Controls.Add(this.dataGridView_ReportText);
            this.Controls.Add(this.Back_Payouts_button);
            this.Name = "ReportTextFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportTextFileForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReportText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_Payouts_button;
        private System.Windows.Forms.DataGridView dataGridView_ReportText;
        private System.Windows.Forms.Button button_MakeTextFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label_Text;
    }
}