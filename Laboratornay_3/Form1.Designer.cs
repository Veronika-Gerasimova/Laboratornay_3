namespace Laboratornay_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fraction1 = new TextBox();
            fraction2 = new TextBox();
            comboBox1 = new ComboBox();
            resultLabel = new TextBox();
            resultTwo = new Label();
            resultThree = new Label();
            SuspendLayout();
            // 
            // fraction1
            // 
            fraction1.Location = new Point(91, 12);
            fraction1.Name = "fraction1";
            fraction1.Size = new Size(102, 23);
            fraction1.TabIndex = 0;
            fraction1.TextChanged += fraction1_TextChanged;
            fraction1.KeyDown += fraction1_KeyDown;
            // 
            // fraction2
            // 
            fraction2.Location = new Point(91, 63);
            fraction2.Name = "fraction2";
            fraction2.Size = new Size(102, 23);
            fraction2.TabIndex = 1;
            fraction2.TextChanged += fraction2_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "+", "-", "*", "/" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(25, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(57, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "+";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // resultLabel
            // 
            resultLabel.Location = new Point(25, 104);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(168, 23);
            resultLabel.TabIndex = 3;
            resultLabel.Text = "Результат";
            // 
            // resultTwo
            // 
            resultTwo.AutoSize = true;
            resultTwo.Location = new Point(25, 144);
            resultTwo.Name = "resultTwo";
            resultTwo.Size = new Size(164, 15);
            resultTwo.TabIndex = 4;
            resultTwo.Text = "Результат сравнения дробей";
            // 
            // resultThree
            // 
            resultThree.AutoSize = true;
            resultThree.Location = new Point(25, 177);
            resultThree.Name = "resultThree";
            resultThree.Size = new Size(235, 15);
            resultThree.TabIndex = 5;
            resultThree.Text = "Результат сравнения дробей через Equals";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 214);
            Controls.Add(resultThree);
            Controls.Add(resultTwo);
            Controls.Add(resultLabel);
            Controls.Add(comboBox1);
            Controls.Add(fraction2);
            Controls.Add(fraction1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fraction1;
        private TextBox fraction2;
        private ComboBox comboBox1;
        private TextBox resultLabel;
        private Label resultTwo;
        private Label resultThree;
    }
}
