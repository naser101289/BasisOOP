namespace SalaryCalculatorApp
{
    partial class SalaryCalculateUI
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.medicalAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.houseRentTextBox = new System.Windows.Forms.TextBox();
            this.basicTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(148, 29);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(207, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // medicalAllowanceTextBox
            // 
            this.medicalAllowanceTextBox.Location = new System.Drawing.Point(148, 107);
            this.medicalAllowanceTextBox.Name = "medicalAllowanceTextBox";
            this.medicalAllowanceTextBox.Size = new System.Drawing.Size(207, 20);
            this.medicalAllowanceTextBox.TabIndex = 1;
            // 
            // houseRentTextBox
            // 
            this.houseRentTextBox.Location = new System.Drawing.Point(148, 81);
            this.houseRentTextBox.Name = "houseRentTextBox";
            this.houseRentTextBox.Size = new System.Drawing.Size(207, 20);
            this.houseRentTextBox.TabIndex = 2;
            // 
            // basicTextBox
            // 
            this.basicTextBox.Location = new System.Drawing.Point(148, 55);
            this.basicTextBox.Name = "basicTextBox";
            this.basicTextBox.Size = new System.Drawing.Size(207, 20);
            this.basicTextBox.TabIndex = 3;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(148, 155);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(207, 23);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show Me Salary";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Basic Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "House Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Medical Allowance";
            // 
            // SalaryCalculateUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 188);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.basicTextBox);
            this.Controls.Add(this.houseRentTextBox);
            this.Controls.Add(this.medicalAllowanceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "SalaryCalculateUI";
            this.Text = "SalaryCalculateUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox medicalAllowanceTextBox;
        private System.Windows.Forms.TextBox houseRentTextBox;
        private System.Windows.Forms.TextBox basicTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

