namespace ArrayListSample
{
    partial class NameListUI
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
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.namesListBox = new System.Windows.Forms.ListBox();
            this.showAllNameButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addCountLabel = new System.Windows.Forms.Label();
            this.reseatButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(206, 23);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Count:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(34, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(160, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // namesListBox
            // 
            this.namesListBox.FormattingEnabled = true;
            this.namesListBox.Location = new System.Drawing.Point(72, 168);
            this.namesListBox.Name = "namesListBox";
            this.namesListBox.Size = new System.Drawing.Size(196, 121);
            this.namesListBox.TabIndex = 3;
            // 
            // showAllNameButton
            // 
            this.showAllNameButton.Location = new System.Drawing.Point(225, 139);
            this.showAllNameButton.Name = "showAllNameButton";
            this.showAllNameButton.Size = new System.Drawing.Size(99, 23);
            this.showAllNameButton.TabIndex = 2;
            this.showAllNameButton.Text = "Show All Name";
            this.showAllNameButton.UseVisualStyleBackColor = true;
            this.showAllNameButton.Click += new System.EventHandler(this.showAllNameButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addCountLabel);
            this.groupBox1.Controls.Add(this.reseatButton);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Location = new System.Drawing.Point(28, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 124);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Name";
            // 
            // addCountLabel
            // 
            this.addCountLabel.AutoSize = true;
            this.addCountLabel.Location = new System.Drawing.Point(117, 80);
            this.addCountLabel.Name = "addCountLabel";
            this.addCountLabel.Size = new System.Drawing.Size(0, 13);
            this.addCountLabel.TabIndex = 4;
            // 
            // reseatButton
            // 
            this.reseatButton.Location = new System.Drawing.Point(206, 80);
            this.reseatButton.Name = "reseatButton";
            this.reseatButton.Size = new System.Drawing.Size(75, 23);
            this.reseatButton.TabIndex = 3;
            this.reseatButton.Text = "Reseat";
            this.reseatButton.UseVisualStyleBackColor = true;
            this.reseatButton.Click += new System.EventHandler(this.reseatButton_Click);
            // 
            // NameListUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.namesListBox);
            this.Controls.Add(this.showAllNameButton);
            this.Name = "NameListUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NameListUI";
            this.Load += new System.EventHandler(this.NameListUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ListBox namesListBox;
        private System.Windows.Forms.Button showAllNameButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label addCountLabel;
        private System.Windows.Forms.Button reseatButton;
    }
}

