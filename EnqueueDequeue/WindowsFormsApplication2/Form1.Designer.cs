namespace WindowsFormsApplication2
{
    partial class CustomerComplainApp
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
            this.enqueueGroupBox = new System.Windows.Forms.GroupBox();
            this.ecomplainLabel = new System.Windows.Forms.Label();
            this.enameLabel = new System.Windows.Forms.Label();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.ecomplainTextBox = new System.Windows.Forms.TextBox();
            this.enameTextBox = new System.Windows.Forms.TextBox();
            this.dequeueGroupBox = new System.Windows.Forms.GroupBox();
            this.dcomplainLabel = new System.Windows.Forms.Label();
            this.dnameLabel = new System.Windows.Forms.Label();
            this.serialNoLabel = new System.Windows.Forms.Label();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.dcomplainTextBox = new System.Windows.Forms.TextBox();
            this.dnameTextBox = new System.Windows.Forms.TextBox();
            this.serialNoTextBox = new System.Windows.Forms.TextBox();
            this.waitingQueueGroupBox = new System.Windows.Forms.GroupBox();
            this.waitingQueueListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enqueueGroupBox.SuspendLayout();
            this.dequeueGroupBox.SuspendLayout();
            this.waitingQueueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enqueueGroupBox
            // 
            this.enqueueGroupBox.Controls.Add(this.ecomplainLabel);
            this.enqueueGroupBox.Controls.Add(this.enameLabel);
            this.enqueueGroupBox.Controls.Add(this.enqueueButton);
            this.enqueueGroupBox.Controls.Add(this.ecomplainTextBox);
            this.enqueueGroupBox.Controls.Add(this.enameTextBox);
            this.enqueueGroupBox.Location = new System.Drawing.Point(12, 12);
            this.enqueueGroupBox.Name = "enqueueGroupBox";
            this.enqueueGroupBox.Size = new System.Drawing.Size(325, 201);
            this.enqueueGroupBox.TabIndex = 0;
            this.enqueueGroupBox.TabStop = false;
            this.enqueueGroupBox.Text = "Enqueue";
            // 
            // ecomplainLabel
            // 
            this.ecomplainLabel.AutoSize = true;
            this.ecomplainLabel.Location = new System.Drawing.Point(6, 81);
            this.ecomplainLabel.Name = "ecomplainLabel";
            this.ecomplainLabel.Size = new System.Drawing.Size(50, 13);
            this.ecomplainLabel.TabIndex = 6;
            this.ecomplainLabel.Text = "Complain";
            // 
            // enameLabel
            // 
            this.enameLabel.AutoSize = true;
            this.enameLabel.Location = new System.Drawing.Point(6, 38);
            this.enameLabel.Name = "enameLabel";
            this.enameLabel.Size = new System.Drawing.Size(35, 13);
            this.enameLabel.TabIndex = 5;
            this.enameLabel.Text = "Name";
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(83, 160);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueueButton.TabIndex = 4;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // ecomplainTextBox
            // 
            this.ecomplainTextBox.Location = new System.Drawing.Point(67, 78);
            this.ecomplainTextBox.Multiline = true;
            this.ecomplainTextBox.Name = "ecomplainTextBox";
            this.ecomplainTextBox.Size = new System.Drawing.Size(237, 59);
            this.ecomplainTextBox.TabIndex = 2;
            // 
            // enameTextBox
            // 
            this.enameTextBox.Location = new System.Drawing.Point(67, 38);
            this.enameTextBox.Name = "enameTextBox";
            this.enameTextBox.Size = new System.Drawing.Size(171, 20);
            this.enameTextBox.TabIndex = 1;
            // 
            // dequeueGroupBox
            // 
            this.dequeueGroupBox.Controls.Add(this.dcomplainLabel);
            this.dequeueGroupBox.Controls.Add(this.dnameLabel);
            this.dequeueGroupBox.Controls.Add(this.serialNoLabel);
            this.dequeueGroupBox.Controls.Add(this.dequeueButton);
            this.dequeueGroupBox.Controls.Add(this.dcomplainTextBox);
            this.dequeueGroupBox.Controls.Add(this.dnameTextBox);
            this.dequeueGroupBox.Controls.Add(this.serialNoTextBox);
            this.dequeueGroupBox.Location = new System.Drawing.Point(351, 12);
            this.dequeueGroupBox.Name = "dequeueGroupBox";
            this.dequeueGroupBox.Size = new System.Drawing.Size(353, 201);
            this.dequeueGroupBox.TabIndex = 1;
            this.dequeueGroupBox.TabStop = false;
            this.dequeueGroupBox.Text = "Dequeue";
            // 
            // dcomplainLabel
            // 
            this.dcomplainLabel.AutoSize = true;
            this.dcomplainLabel.Location = new System.Drawing.Point(7, 124);
            this.dcomplainLabel.Name = "dcomplainLabel";
            this.dcomplainLabel.Size = new System.Drawing.Size(50, 13);
            this.dcomplainLabel.TabIndex = 6;
            this.dcomplainLabel.Text = "Complain";
            // 
            // dnameLabel
            // 
            this.dnameLabel.AutoSize = true;
            this.dnameLabel.Location = new System.Drawing.Point(7, 81);
            this.dnameLabel.Name = "dnameLabel";
            this.dnameLabel.Size = new System.Drawing.Size(35, 13);
            this.dnameLabel.TabIndex = 5;
            this.dnameLabel.Text = "Name";
            // 
            // serialNoLabel
            // 
            this.serialNoLabel.AutoSize = true;
            this.serialNoLabel.Location = new System.Drawing.Point(7, 41);
            this.serialNoLabel.Name = "serialNoLabel";
            this.serialNoLabel.Size = new System.Drawing.Size(53, 13);
            this.serialNoLabel.TabIndex = 4;
            this.serialNoLabel.Text = "Serial No.";
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(262, 33);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(75, 23);
            this.dequeueButton.TabIndex = 3;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // dcomplainTextBox
            // 
            this.dcomplainTextBox.Location = new System.Drawing.Point(80, 121);
            this.dcomplainTextBox.Multiline = true;
            this.dcomplainTextBox.Name = "dcomplainTextBox";
            this.dcomplainTextBox.Size = new System.Drawing.Size(257, 62);
            this.dcomplainTextBox.TabIndex = 2;
            // 
            // dnameTextBox
            // 
            this.dnameTextBox.Location = new System.Drawing.Point(80, 78);
            this.dnameTextBox.Name = "dnameTextBox";
            this.dnameTextBox.Size = new System.Drawing.Size(187, 20);
            this.dnameTextBox.TabIndex = 1;
            // 
            // serialNoTextBox
            // 
            this.serialNoTextBox.Location = new System.Drawing.Point(80, 35);
            this.serialNoTextBox.Name = "serialNoTextBox";
            this.serialNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.serialNoTextBox.TabIndex = 0;
            // 
            // waitingQueueGroupBox
            // 
            this.waitingQueueGroupBox.Controls.Add(this.waitingQueueListView);
            this.waitingQueueGroupBox.Location = new System.Drawing.Point(12, 237);
            this.waitingQueueGroupBox.Name = "waitingQueueGroupBox";
            this.waitingQueueGroupBox.Size = new System.Drawing.Size(692, 202);
            this.waitingQueueGroupBox.TabIndex = 2;
            this.waitingQueueGroupBox.TabStop = false;
            this.waitingQueueGroupBox.Text = "Waiting Queue";
            // 
            // waitingQueueListView
            // 
            this.waitingQueueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.waitingQueueListView.FullRowSelect = true;
            this.waitingQueueListView.GridLines = true;
            this.waitingQueueListView.Location = new System.Drawing.Point(0, 19);
            this.waitingQueueListView.MultiSelect = false;
            this.waitingQueueListView.Name = "waitingQueueListView";
            this.waitingQueueListView.Size = new System.Drawing.Size(692, 183);
            this.waitingQueueListView.TabIndex = 0;
            this.waitingQueueListView.UseCompatibleStateImageBehavior = false;
            this.waitingQueueListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial No.";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 161;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Complain";
            this.columnHeader3.Width = 465;
            // 
            // CustomerComplainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 451);
            this.Controls.Add(this.waitingQueueGroupBox);
            this.Controls.Add(this.dequeueGroupBox);
            this.Controls.Add(this.enqueueGroupBox);
            this.Name = "CustomerComplainApp";
            this.Text = "Customer Complain Application";
            this.enqueueGroupBox.ResumeLayout(false);
            this.enqueueGroupBox.PerformLayout();
            this.dequeueGroupBox.ResumeLayout(false);
            this.dequeueGroupBox.PerformLayout();
            this.waitingQueueGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox enqueueGroupBox;
        private System.Windows.Forms.Label ecomplainLabel;
        private System.Windows.Forms.Label enameLabel;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.TextBox ecomplainTextBox;
        private System.Windows.Forms.TextBox enameTextBox;
        private System.Windows.Forms.GroupBox dequeueGroupBox;
        private System.Windows.Forms.Label dcomplainLabel;
        private System.Windows.Forms.Label dnameLabel;
        private System.Windows.Forms.Label serialNoLabel;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.TextBox dcomplainTextBox;
        private System.Windows.Forms.TextBox dnameTextBox;
        private System.Windows.Forms.TextBox serialNoTextBox;
        private System.Windows.Forms.GroupBox waitingQueueGroupBox;
        private System.Windows.Forms.ListView waitingQueueListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

