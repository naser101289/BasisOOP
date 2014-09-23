namespace DailyExpenses
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxParticular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTotalExpense = new System.Windows.Forms.TextBox();
            this.textBoxMaximumExpense = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxCategorwise = new System.Windows.Forms.ComboBox();
            this.buttonShowCategory = new System.Windows.Forms.Button();
            this.listViewShowDetails = new System.Windows.Forms.ListView();
            this.Total = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Expenses Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Particular";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(101, 38);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 4;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Convenyance",
            "Grocery",
            "Misc"});
            this.comboBoxCategory.Location = new System.Drawing.Point(101, 68);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 5;
            // 
            // textBoxParticular
            // 
            this.textBoxParticular.Location = new System.Drawing.Point(102, 98);
            this.textBoxParticular.Multiline = true;
            this.textBoxParticular.Name = "textBoxParticular";
            this.textBoxParticular.Size = new System.Drawing.Size(221, 91);
            this.textBoxParticular.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "View Summary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Expense";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Maximum Expense";
            // 
            // textBoxTotalExpense
            // 
            this.textBoxTotalExpense.Location = new System.Drawing.Point(144, 331);
            this.textBoxTotalExpense.Name = "textBoxTotalExpense";
            this.textBoxTotalExpense.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalExpense.TabIndex = 10;
            // 
            // textBoxMaximumExpense
            // 
            this.textBoxMaximumExpense.Location = new System.Drawing.Point(144, 363);
            this.textBoxMaximumExpense.Name = "textBoxMaximumExpense";
            this.textBoxMaximumExpense.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaximumExpense.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(247, 198);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(247, 274);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 13;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(583, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "View Categorywise Expense";
            // 
            // comboBoxCategorwise
            // 
            this.comboBoxCategorwise.FormattingEnabled = true;
            this.comboBoxCategorwise.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Convenyance",
            "Grocery",
            "Misc"});
            this.comboBoxCategorwise.Location = new System.Drawing.Point(586, 39);
            this.comboBoxCategorwise.Name = "comboBoxCategorwise";
            this.comboBoxCategorwise.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategorwise.TabIndex = 15;
            // 
            // buttonShowCategory
            // 
            this.buttonShowCategory.Location = new System.Drawing.Point(832, 66);
            this.buttonShowCategory.Name = "buttonShowCategory";
            this.buttonShowCategory.Size = new System.Drawing.Size(75, 23);
            this.buttonShowCategory.TabIndex = 16;
            this.buttonShowCategory.Text = "Show";
            this.buttonShowCategory.UseVisualStyleBackColor = true;
            this.buttonShowCategory.Click += new System.EventHandler(this.buttonShowCategory_Click);
            // 
            // listViewShowDetails
            // 
            this.listViewShowDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewShowDetails.Location = new System.Drawing.Point(586, 103);
            this.listViewShowDetails.Name = "listViewShowDetails";
            this.listViewShowDetails.Size = new System.Drawing.Size(321, 183);
            this.listViewShowDetails.TabIndex = 17;
            this.listViewShowDetails.UseCompatibleStateImageBehavior = false;
            this.listViewShowDetails.View = System.Windows.Forms.View.Details;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(586, 333);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(35, 13);
            this.Total.TabIndex = 18;
            this.Total.Text = "label9";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(670, 330);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(237, 20);
            this.textBoxTotal.TabIndex = 19;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Amount";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Category";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Particular";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 479);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.listViewShowDetails);
            this.Controls.Add(this.buttonShowCategory);
            this.Controls.Add(this.comboBoxCategorwise);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxMaximumExpense);
            this.Controls.Add(this.textBoxTotalExpense);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxParticular);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxParticular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTotalExpense;
        private System.Windows.Forms.TextBox textBoxMaximumExpense;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCategorwise;
        private System.Windows.Forms.Button buttonShowCategory;
        private System.Windows.Forms.ListView listViewShowDetails;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

