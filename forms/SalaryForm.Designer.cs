namespace UkrPoshta.forms
{
    partial class SalaryForm
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
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bSaveTXT = new System.Windows.Forms.Button();
            this.bOpenFolder = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalary
            // 
            this.dgvSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalary.Location = new System.Drawing.Point(22, 98);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.ReadOnly = true;
            this.dgvSalary.RowTemplate.Height = 25;
            this.dgvSalary.Size = new System.Drawing.Size(1094, 542);
            this.dgvSalary.TabIndex = 0;
            // 
            // cbDepartment
            // 
            this.cbDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(140, 49);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(236, 29);
            this.cbDepartment.TabIndex = 14;
            this.cbDepartment.SelectionChangeCommitted += new System.EventHandler(this.cbDepartment_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(140, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Відділ";
            // 
            // bSaveTXT
            // 
            this.bSaveTXT.Location = new System.Drawing.Point(853, 33);
            this.bSaveTXT.Name = "bSaveTXT";
            this.bSaveTXT.Size = new System.Drawing.Size(119, 45);
            this.bSaveTXT.TabIndex = 16;
            this.bSaveTXT.Text = "Зберегти у .txt файл";
            this.bSaveTXT.UseVisualStyleBackColor = true;
            this.bSaveTXT.Click += new System.EventHandler(this.bSaveTXT_Click);
            // 
            // bOpenFolder
            // 
            this.bOpenFolder.Location = new System.Drawing.Point(997, 33);
            this.bOpenFolder.Name = "bOpenFolder";
            this.bOpenFolder.Size = new System.Drawing.Size(119, 45);
            this.bOpenFolder.TabIndex = 17;
            this.bOpenFolder.Text = "Відкрити папку";
            this.bOpenFolder.UseVisualStyleBackColor = true;
            this.bOpenFolder.Click += new System.EventHandler(this.bOpenFolder_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(22, 49);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(102, 29);
            this.bBack.TabIndex = 18;
            this.bBack.Text = "Назад";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 652);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bOpenFolder);
            this.Controls.Add(this.bSaveTXT);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvSalary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SalaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalaryForm";
            this.Load += new System.EventHandler(this.SalaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvSalary;
        private ComboBox cbDepartment;
        private Label label3;
        private Button bSaveTXT;
        private Button bOpenFolder;
        private Button bBack;
    }
}