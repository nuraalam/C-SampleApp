namespace _5.ListView_and_listBox_Practice
{
    partial class ListViewandListBoxApp
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
            this.showListBox = new System.Windows.Forms.ListBox();
            this.showlistView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameAddButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact Number";
            // 
            // showListBox
            // 
            this.showListBox.FormattingEnabled = true;
            this.showListBox.Location = new System.Drawing.Point(12, 174);
            this.showListBox.Name = "showListBox";
            this.showListBox.Size = new System.Drawing.Size(120, 95);
            this.showListBox.TabIndex = 2;
            this.showListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Enable);
            // 
            // showlistView
            // 
            this.showlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.contactNumberColumnHeader});
            this.showlistView.GridLines = true;
            this.showlistView.Location = new System.Drawing.Point(138, 172);
            this.showlistView.Name = "showlistView";
            this.showlistView.Size = new System.Drawing.Size(211, 142);
            this.showlistView.TabIndex = 3;
            this.showlistView.UseCompatibleStateImageBehavior = false;
            this.showlistView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 76;
            // 
            // contactNumberColumnHeader
            // 
            this.contactNumberColumnHeader.Text = "Contact Number";
            this.contactNumberColumnHeader.Width = 131;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(27, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Location = new System.Drawing.Point(197, 57);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(129, 20);
            this.contactNumberTextBox.TabIndex = 5;
            // 
            // nameAddButton
            // 
            this.nameAddButton.Location = new System.Drawing.Point(251, 83);
            this.nameAddButton.Name = "nameAddButton";
            this.nameAddButton.Size = new System.Drawing.Size(75, 23);
            this.nameAddButton.TabIndex = 6;
            this.nameAddButton.Text = "Add";
            this.nameAddButton.UseVisualStyleBackColor = true;
            this.nameAddButton.Click += new System.EventHandler(this.nameAddButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(27, 291);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 8;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // ListViewandListBoxApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 352);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.nameAddButton);
            this.Controls.Add(this.contactNumberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.showlistView);
            this.Controls.Add(this.showListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListViewandListBoxApp";
            this.Text = "ListView and ListBox Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox showListBox;
        private System.Windows.Forms.ListView showlistView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader contactNumberColumnHeader;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.Button nameAddButton;
        private System.Windows.Forms.Button showButton;
    }
}

