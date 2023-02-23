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
            lTop = new Label();
            bEmployees = new Button();
            bUpdate = new Button();
            bSalary = new Button();
            SuspendLayout();
            // 
            // lTop
            // 
            lTop.AutoSize = true;
            lTop.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lTop.Location = new Point(138, 9);
            lTop.Name = "lTop";
            lTop.Size = new Size(193, 25);
            lTop.TabIndex = 0;
            lTop.Text = "UkrPoshta вас вітає !";
            // 
            // bEmployees
            // 
            bEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bEmployees.Location = new Point(156, 197);
            bEmployees.Name = "bEmployees";
            bEmployees.Size = new Size(175, 60);
            bEmployees.TabIndex = 1;
            bEmployees.Text = "Пошук";
            bEmployees.UseVisualStyleBackColor = true;
            bEmployees.Click += bEmployees_Click;
            // 
            // bUpdate
            // 
            bUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bUpdate.Location = new Point(156, 289);
            bUpdate.Name = "bUpdate";
            bUpdate.Size = new Size(175, 60);
            bUpdate.TabIndex = 2;
            bUpdate.Text = "Редагування";
            bUpdate.UseVisualStyleBackColor = true;
            bUpdate.Click += bUpdate_Click;
            // 
            // bSalary
            // 
            bSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bSalary.Location = new Point(156, 379);
            bSalary.Name = "bSalary";
            bSalary.Size = new Size(175, 60);
            bSalary.TabIndex = 3;
            bSalary.Text = "Зарплатна звітність";
            bSalary.UseVisualStyleBackColor = true;
            bSalary.Click += bSalary_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 592);
            Controls.Add(bSalary);
            Controls.Add(bUpdate);
            Controls.Add(bEmployees);
            Controls.Add(lTop);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UkrPoshta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lTop;
        private Button bEmployees;
        private Button bUpdate;
        private Button bSalary;
    }
}