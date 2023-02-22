namespace UkrPoshta
{
    partial class EmployeesForm
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.bSearch = new System.Windows.Forms.Button();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.tbSearchLastName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pcClear = new System.Windows.Forms.PictureBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.bBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClear)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 115);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowTemplate.Height = 25;
            this.dgvEmployees.Size = new System.Drawing.Size(1141, 481);
            this.dgvEmployees.TabIndex = 0;
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(1026, 52);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(127, 30);
            this.bSearch.TabIndex = 1;
            this.bSearch.Text = "Пошук";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tbSearchName
            // 
            this.tbSearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSearchName.Location = new System.Drawing.Point(126, 53);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(246, 29);
            this.tbSearchName.TabIndex = 2;
            // 
            // tbSearchLastName
            // 
            this.tbSearchLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSearchLastName.Location = new System.Drawing.Point(380, 53);
            this.tbSearchLastName.Name = "tbSearchLastName";
            this.tbSearchLastName.Size = new System.Drawing.Size(246, 29);
            this.tbSearchLastName.TabIndex = 3;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lName.Location = new System.Drawing.Point(126, 15);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(35, 20);
            this.lName.TabIndex = 6;
            this.lName.Text = "Ім\'я";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(380, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Прізвище";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(632, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Посада";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(796, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Відділ";
            // 
            // pcClear
            // 
            this.pcClear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcClear.Image = global::UkrPoshta.Properties.Resources._3792081_broom_halloween_magic_witch_icon;
            this.pcClear.Location = new System.Drawing.Point(981, 52);
            this.pcClear.Name = "pcClear";
            this.pcClear.Size = new System.Drawing.Size(30, 30);
            this.pcClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcClear.TabIndex = 10;
            this.pcClear.TabStop = false;
            this.pcClear.Click += new System.EventHandler(this.pcClear_Click);
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(632, 53);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(158, 29);
            this.cbPosition.TabIndex = 11;
            // 
            // cbDepartment
            // 
            this.cbDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(796, 53);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(179, 29);
            this.cbDepartment.TabIndex = 12;
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(12, 52);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(75, 30);
            this.bBack.TabIndex = 13;
            this.bBack.Text = "Назад";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 608);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.pcClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tbSearchLastName);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.dgvEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvEmployees;
        private Button bSearch;
        private TextBox tbSearchName;
        private TextBox tbSearchLastName;
        private Label lName;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pcClear;
        private ComboBox cbPosition;
        private ComboBox cbDepartment;
        private Button bBack;
    }
}