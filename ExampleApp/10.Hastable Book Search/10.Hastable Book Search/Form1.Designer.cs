namespace _10.Hastable_Book_Search
{
    partial class BookSearch
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
            this.addIsbnTextBox = new System.Windows.Forms.TextBox();
            this.addDetailsTextBox = new System.Windows.Forms.TextBox();
            this.findIsbnTextBox = new System.Windows.Forms.TextBox();
            this.findDetailsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Details";
            // 
            // addIsbnTextBox
            // 
            this.addIsbnTextBox.Location = new System.Drawing.Point(92, 25);
            this.addIsbnTextBox.Name = "addIsbnTextBox";
            this.addIsbnTextBox.Size = new System.Drawing.Size(100, 20);
            this.addIsbnTextBox.TabIndex = 4;
            // 
            // addDetailsTextBox
            // 
            this.addDetailsTextBox.Location = new System.Drawing.Point(92, 63);
            this.addDetailsTextBox.Name = "addDetailsTextBox";
            this.addDetailsTextBox.Size = new System.Drawing.Size(100, 20);
            this.addDetailsTextBox.TabIndex = 5;
            // 
            // findIsbnTextBox
            // 
            this.findIsbnTextBox.Location = new System.Drawing.Point(92, 166);
            this.findIsbnTextBox.Name = "findIsbnTextBox";
            this.findIsbnTextBox.Size = new System.Drawing.Size(100, 20);
            this.findIsbnTextBox.TabIndex = 6;
            // 
            // findDetailsTextBox
            // 
            this.findDetailsTextBox.Location = new System.Drawing.Point(92, 211);
            this.findDetailsTextBox.Name = "findDetailsTextBox";
            this.findDetailsTextBox.Size = new System.Drawing.Size(100, 20);
            this.findDetailsTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adding Book";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Searching Book";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(220, 44);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(220, 186);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 11;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // BookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 261);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.findDetailsTextBox);
            this.Controls.Add(this.findIsbnTextBox);
            this.Controls.Add(this.addDetailsTextBox);
            this.Controls.Add(this.addIsbnTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookSearch";
            this.Text = "Book Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addIsbnTextBox;
        private System.Windows.Forms.TextBox addDetailsTextBox;
        private System.Windows.Forms.TextBox findIsbnTextBox;
        private System.Windows.Forms.TextBox findDetailsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button findButton;
    }
}

