namespace DailyExpenseApplication
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.particularTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maximumExpenseTextBox = new System.Windows.Forms.TextBox();
            this.totalExpenseTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.detailListView = new System.Windows.Forms.ListView();
            this.sshowButton = new System.Windows.Forms.Button();
            this.scategoryComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.particularTextBox);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.amountTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Expense Entry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Particular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(208, 190);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // particularTextBox
            // 
            this.particularTextBox.Location = new System.Drawing.Point(80, 88);
            this.particularTextBox.Multiline = true;
            this.particularTextBox.Name = "particularTextBox";
            this.particularTextBox.Size = new System.Drawing.Size(203, 78);
            this.particularTextBox.TabIndex = 2;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Gocery",
            "Misc"});
            this.categoryComboBox.Location = new System.Drawing.Point(80, 61);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(203, 21);
            this.categoryComboBox.TabIndex = 1;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(80, 35);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(203, 20);
            this.amountTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.maximumExpenseTextBox);
            this.groupBox2.Controls.Add(this.totalExpenseTextBox);
            this.groupBox2.Controls.Add(this.showButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Summary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Maximum Expense";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Expense";
            // 
            // maximumExpenseTextBox
            // 
            this.maximumExpenseTextBox.Location = new System.Drawing.Point(110, 154);
            this.maximumExpenseTextBox.Name = "maximumExpenseTextBox";
            this.maximumExpenseTextBox.Size = new System.Drawing.Size(203, 20);
            this.maximumExpenseTextBox.TabIndex = 6;
            // 
            // totalExpenseTextBox
            // 
            this.totalExpenseTextBox.Location = new System.Drawing.Point(110, 104);
            this.totalExpenseTextBox.Name = "totalExpenseTextBox";
            this.totalExpenseTextBox.Size = new System.Drawing.Size(203, 20);
            this.totalExpenseTextBox.TabIndex = 5;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(208, 32);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.totalTextBox);
            this.groupBox3.Controls.Add(this.detailListView);
            this.groupBox3.Controls.Add(this.sshowButton);
            this.groupBox3.Controls.Add(this.scategoryComboBox);
            this.groupBox3.Location = new System.Drawing.Point(408, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 500);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Categorywise Expense";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Category";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(127, 427);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(203, 20);
            this.totalTextBox.TabIndex = 6;
            // 
            // detailListView
            // 
            this.detailListView.FullRowSelect = true;
            this.detailListView.GridLines = true;
            this.detailListView.Location = new System.Drawing.Point(6, 171);
            this.detailListView.MultiSelect = false;
            this.detailListView.Name = "detailListView";
            this.detailListView.Size = new System.Drawing.Size(417, 223);
            this.detailListView.TabIndex = 5;
            this.detailListView.UseCompatibleStateImageBehavior = false;
            // 
            // sshowButton
            // 
            this.sshowButton.Location = new System.Drawing.Point(255, 86);
            this.sshowButton.Name = "sshowButton";
            this.sshowButton.Size = new System.Drawing.Size(75, 23);
            this.sshowButton.TabIndex = 4;
            this.sshowButton.Text = "show";
            this.sshowButton.UseVisualStyleBackColor = true;
            this.sshowButton.Click += new System.EventHandler(this.sshowButton_Click);
            // 
            // scategoryComboBox
            // 
            this.scategoryComboBox.FormattingEnabled = true;
            this.scategoryComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Gocery",
            "Misc"});
            this.scategoryComboBox.Location = new System.Drawing.Point(127, 35);
            this.scategoryComboBox.Name = "scategoryComboBox";
            this.scategoryComboBox.Size = new System.Drawing.Size(203, 21);
            this.scategoryComboBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 524);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Daily Expense";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox particularTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maximumExpenseTextBox;
        private System.Windows.Forms.TextBox totalExpenseTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.ListView detailListView;
        private System.Windows.Forms.Button sshowButton;
        private System.Windows.Forms.ComboBox scategoryComboBox;
    }
}

