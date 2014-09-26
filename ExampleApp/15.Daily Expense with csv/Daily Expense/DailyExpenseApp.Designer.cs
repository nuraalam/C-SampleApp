namespace Daily_Expense
{
    partial class DailyExpenseApp
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
            this.saveButton = new System.Windows.Forms.Button();
            this.entryCatagoryComboBox = new System.Windows.Forms.ComboBox();
            this.particularTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.viewSummaryShowButton = new System.Windows.Forms.Button();
            this.maximumExpenseTextBox = new System.Windows.Forms.TextBox();
            this.totalExpenseTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.viewCatagoryWiseShowButton = new System.Windows.Forms.Button();
            this.viewTotalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewCatagoryWiseListBox = new System.Windows.Forms.ListBox();
            this.viewCatagoryComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.entryCatagoryComboBox);
            this.groupBox1.Controls.Add(this.particularTextBox);
            this.groupBox1.Controls.Add(this.amountTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Expense Entry";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(174, 135);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // entryCatagoryComboBox
            // 
            this.entryCatagoryComboBox.FormattingEnabled = true;
            this.entryCatagoryComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.entryCatagoryComboBox.Location = new System.Drawing.Point(99, 53);
            this.entryCatagoryComboBox.Name = "entryCatagoryComboBox";
            this.entryCatagoryComboBox.Size = new System.Drawing.Size(150, 21);
            this.entryCatagoryComboBox.TabIndex = 7;
            // 
            // particularTextBox
            // 
            this.particularTextBox.Location = new System.Drawing.Point(99, 81);
            this.particularTextBox.Multiline = true;
            this.particularTextBox.Name = "particularTextBox";
            this.particularTextBox.Size = new System.Drawing.Size(150, 48);
            this.particularTextBox.TabIndex = 6;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(99, 19);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(150, 20);
            this.amountTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Particular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Catagory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viewSummaryShowButton);
            this.groupBox2.Controls.Add(this.maximumExpenseTextBox);
            this.groupBox2.Controls.Add(this.totalExpenseTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 119);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Summary";
            // 
            // viewSummaryShowButton
            // 
            this.viewSummaryShowButton.Location = new System.Drawing.Point(174, 19);
            this.viewSummaryShowButton.Name = "viewSummaryShowButton";
            this.viewSummaryShowButton.Size = new System.Drawing.Size(75, 23);
            this.viewSummaryShowButton.TabIndex = 8;
            this.viewSummaryShowButton.Text = "Show";
            this.viewSummaryShowButton.UseVisualStyleBackColor = true;
            this.viewSummaryShowButton.Click += new System.EventHandler(this.viewSummaryShowButton_Click);
            // 
            // maximumExpenseTextBox
            // 
            this.maximumExpenseTextBox.Location = new System.Drawing.Point(99, 88);
            this.maximumExpenseTextBox.Name = "maximumExpenseTextBox";
            this.maximumExpenseTextBox.Size = new System.Drawing.Size(150, 20);
            this.maximumExpenseTextBox.TabIndex = 7;
            // 
            // totalExpenseTextBox
            // 
            this.totalExpenseTextBox.Location = new System.Drawing.Point(99, 51);
            this.totalExpenseTextBox.Name = "totalExpenseTextBox";
            this.totalExpenseTextBox.Size = new System.Drawing.Size(150, 20);
            this.totalExpenseTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Expense";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Maximum Expense";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.viewCatagoryWiseShowButton);
            this.groupBox3.Controls.Add(this.viewTotalTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.viewCatagoryWiseListBox);
            this.groupBox3.Controls.Add(this.viewCatagoryComboBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(304, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 289);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Catagorywise Expense";
            
            // 
            // viewCatagoryWiseShowButton
            // 
            this.viewCatagoryWiseShowButton.Location = new System.Drawing.Point(220, 79);
            this.viewCatagoryWiseShowButton.Name = "viewCatagoryWiseShowButton";
            this.viewCatagoryWiseShowButton.Size = new System.Drawing.Size(75, 23);
            this.viewCatagoryWiseShowButton.TabIndex = 11;
            this.viewCatagoryWiseShowButton.Text = "Show";
            this.viewCatagoryWiseShowButton.UseVisualStyleBackColor = true;
            this.viewCatagoryWiseShowButton.Click += new System.EventHandler(this.viewCatagoryWiseShowButton_Click);
            // 
            // viewTotalTextBox
            // 
            this.viewTotalTextBox.Location = new System.Drawing.Point(195, 259);
            this.viewTotalTextBox.Name = "viewTotalTextBox";
            this.viewTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.viewTotalTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Catagory";
            // 
            // viewCatagoryWiseListBox
            // 
            this.viewCatagoryWiseListBox.FormattingEnabled = true;
            this.viewCatagoryWiseListBox.Location = new System.Drawing.Point(84, 108);
            this.viewCatagoryWiseListBox.Name = "viewCatagoryWiseListBox";
            this.viewCatagoryWiseListBox.Size = new System.Drawing.Size(211, 134);
            this.viewCatagoryWiseListBox.TabIndex = 8;
            // 
            // viewCatagoryComboBox
            // 
            this.viewCatagoryComboBox.FormattingEnabled = true;
            this.viewCatagoryComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.viewCatagoryComboBox.Location = new System.Drawing.Point(124, 48);
            this.viewCatagoryComboBox.Name = "viewCatagoryComboBox";
            this.viewCatagoryComboBox.Size = new System.Drawing.Size(171, 21);
            this.viewCatagoryComboBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total";
            // 
            // DailyExpenseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 322);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DailyExpenseApp";
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
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox entryCatagoryComboBox;
        private System.Windows.Forms.TextBox particularTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button viewSummaryShowButton;
        private System.Windows.Forms.TextBox maximumExpenseTextBox;
        private System.Windows.Forms.TextBox totalExpenseTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button viewCatagoryWiseShowButton;
        private System.Windows.Forms.TextBox viewTotalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox viewCatagoryWiseListBox;
        private System.Windows.Forms.ComboBox viewCatagoryComboBox;
        private System.Windows.Forms.Label label7;
    }
}

