namespace UkrPoshta
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lTop = new System.Windows.Forms.Label();
            this.bEmployees = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bSalary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lTop
            // 
            this.lTop.AutoSize = true;
            this.lTop.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lTop.Location = new System.Drawing.Point(138, 9);
            this.lTop.Name = "lTop";
            this.lTop.Size = new System.Drawing.Size(193, 25);
            this.lTop.TabIndex = 0;
            this.lTop.Text = "UkrPoshta вас вітає !";
            // 
            // bEmployees
            // 
            this.bEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bEmployees.Location = new System.Drawing.Point(156, 197);
            this.bEmployees.Name = "bEmployees";
            this.bEmployees.Size = new System.Drawing.Size(175, 60);
            this.bEmployees.TabIndex = 1;
            this.bEmployees.Text = "Пошук";
            this.bEmployees.UseVisualStyleBackColor = true;
            this.bEmployees.Click += new System.EventHandler(this.bEmployees_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bUpdate.Location = new System.Drawing.Point(156, 289);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(175, 60);
            this.bUpdate.TabIndex = 2;
            this.bUpdate.Text = "Редагування";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bSalary
            // 
            this.bSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bSalary.Location = new System.Drawing.Point(156, 379);
            this.bSalary.Name = "bSalary";
            this.bSalary.Size = new System.Drawing.Size(175, 60);
            this.bSalary.TabIndex = 3;
            this.bSalary.Text = "Зарплатна звітність";
            this.bSalary.UseVisualStyleBackColor = true;
            this.bSalary.Click += new System.EventHandler(this.bSalary_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 592);
            this.Controls.Add(this.bSalary);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bEmployees);
            this.Controls.Add(this.lTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lTop;
        private Button bEmployees;
        private Button bUpdate;
        private Button bSalary;
    }
}