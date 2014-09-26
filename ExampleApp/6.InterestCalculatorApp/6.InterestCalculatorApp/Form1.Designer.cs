namespace _6.InterestCalculatorApp
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
            this.calculationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bankNameComboBox = new System.Windows.Forms.ComboBox();
            this.yearOfInterestTextBox = new System.Windows.Forms.TextBox();
            this.balanceAfterInterestTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outputLebel = new System.Windows.Forms.Label();
            this.initialBalanceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculationButton
            // 
            this.calculationButton.Location = new System.Drawing.Point(83, 132);
            this.calculationButton.Name = "calculationButton";
            this.calculationButton.Size = new System.Drawing.Size(75, 23);
            this.calculationButton.TabIndex = 0;
            this.calculationButton.Text = "Calculation";
            this.calculationButton.UseVisualStyleBackColor = true;
            this.calculationButton.Click += new System.EventHandler(this.calculationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year of Interest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Balance After Interest";
            // 
            // bankNameComboBox
            // 
            this.bankNameComboBox.FormattingEnabled = true;
            this.bankNameComboBox.Items.AddRange(new object[] {
            "HSBC",
            "BRAK",
            "UCB"});
            this.bankNameComboBox.Location = new System.Drawing.Point(107, 33);
            this.bankNameComboBox.Name = "bankNameComboBox";
            this.bankNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.bankNameComboBox.TabIndex = 4;
            // 
            // yearOfInterestTextBox
            // 
            this.yearOfInterestTextBox.Location = new System.Drawing.Point(107, 60);
            this.yearOfInterestTextBox.Name = "yearOfInterestTextBox";
            this.yearOfInterestTextBox.Size = new System.Drawing.Size(69, 20);
            this.yearOfInterestTextBox.TabIndex = 5;
            // 
            // balanceAfterInterestTextBox
            // 
            this.balanceAfterInterestTextBox.Location = new System.Drawing.Point(145, 172);
            this.balanceAfterInterestTextBox.Name = "balanceAfterInterestTextBox";
            this.balanceAfterInterestTextBox.Size = new System.Drawing.Size(100, 20);
            this.balanceAfterInterestTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Interest=";
            // 
            // outputLebel
            // 
            this.outputLebel.AutoSize = true;
            this.outputLebel.Location = new System.Drawing.Point(104, 229);
            this.outputLebel.Name = "outputLebel";
            this.outputLebel.Size = new System.Drawing.Size(39, 13);
            this.outputLebel.TabIndex = 8;
            this.outputLebel.Text = "Output";
            // 
            // initialBalanceTextBox
            // 
            this.initialBalanceTextBox.Location = new System.Drawing.Point(107, 97);
            this.initialBalanceTextBox.Name = "initialBalanceTextBox";
            this.initialBalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.initialBalanceTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Initial Balance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.initialBalanceTextBox);
            this.Controls.Add(this.outputLebel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.balanceAfterInterestTextBox);
            this.Controls.Add(this.yearOfInterestTextBox);
            this.Controls.Add(this.bankNameComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculationButton);
            this.Name = "Form1";
            this.Text = "Interest Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bankNameComboBox;
        private System.Windows.Forms.TextBox yearOfInterestTextBox;
        private System.Windows.Forms.TextBox balanceAfterInterestTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outputLebel;
        private System.Windows.Forms.TextBox initialBalanceTextBox;
        private System.Windows.Forms.Label label5;
    }
}

