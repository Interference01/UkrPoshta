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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lTop
            // 
            this.lTop.AutoSize = true;
            this.lTop.Location = new System.Drawing.Point(12, 9);
            this.lTop.Name = "lTop";
            this.lTop.Size = new System.Drawing.Size(117, 15);
            this.lTop.TabIndex = 0;
            this.lTop.Text = "UkrPoshta вас вітає !";
            // 
            // bEmployees
            // 
            this.bEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bEmployees.Location = new System.Drawing.Point(101, 148);
            this.bEmployees.Name = "bEmployees";
            this.bEmployees.Size = new System.Drawing.Size(175, 60);
            this.bEmployees.TabIndex = 1;
            this.bEmployees.Text = "Робітники";
            this.bEmployees.UseVisualStyleBackColor = true;
            this.bEmployees.Click += new System.EventHandler(this.bEmployees_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 592);
            this.Controls.Add(this.button2);
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
        private Button button2;
    }
}