namespace Interest_calculation
{
    partial class InterestcalculatorUI
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
            this.banknameLabel = new System.Windows.Forms.Label();
            this.bankNameComboBox = new System.Windows.Forms.ComboBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.calculateInterestButton = new System.Windows.Forms.Button();
            this.interestLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // banknameLabel
            // 
            this.banknameLabel.AutoSize = true;
            this.banknameLabel.Location = new System.Drawing.Point(52, 56);
            this.banknameLabel.Name = "banknameLabel";
            this.banknameLabel.Size = new System.Drawing.Size(70, 13);
            this.banknameLabel.TabIndex = 0;
            this.banknameLabel.Text = "Bank\'s Name";
            // 
            // bankNameComboBox
            // 
            this.bankNameComboBox.FormattingEnabled = true;
            this.bankNameComboBox.Items.AddRange(new object[] {
            "BRAC",
            "DBBL",
            "HSBC"});
            this.bankNameComboBox.Location = new System.Drawing.Point(144, 53);
            this.bankNameComboBox.Name = "bankNameComboBox";
            this.bankNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.bankNameComboBox.TabIndex = 1;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(69, 136);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(67, 13);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "Time(in year)";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(72, 183);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(46, 13);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.Text = "Balance";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(165, 129);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeTextBox.TabIndex = 4;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(165, 180);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.balanceTextBox.TabIndex = 5;
            // 
            // calculateInterestButton
            // 
            this.calculateInterestButton.Location = new System.Drawing.Point(204, 282);
            this.calculateInterestButton.Name = "calculateInterestButton";
            this.calculateInterestButton.Size = new System.Drawing.Size(172, 23);
            this.calculateInterestButton.TabIndex = 6;
            this.calculateInterestButton.Text = "Calculate Interest";
            this.calculateInterestButton.UseVisualStyleBackColor = true;
            this.calculateInterestButton.Click += new System.EventHandler(this.calculateInterestButton_Click);
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Location = new System.Drawing.Point(86, 358);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(48, 13);
            this.interestLabel.TabIndex = 7;
            this.interestLabel.Text = "Interest=";
            // 
            // InterestcalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 400);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.calculateInterestButton);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.bankNameComboBox);
            this.Controls.Add(this.banknameLabel);
            this.Name = "InterestcalculatorUI";
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label banknameLabel;
        private System.Windows.Forms.ComboBox bankNameComboBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Button calculateInterestButton;
        private System.Windows.Forms.Label interestLabel;
    }
}

