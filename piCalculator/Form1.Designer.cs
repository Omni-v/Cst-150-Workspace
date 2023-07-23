namespace piCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            classGroupControl = new GroupBox();
            finalSolutionOutput = new Label();
            refelectionOutput = new Label();
            userInputForTerms = new TextBox();
            Calculate = new Button();
            inputInstruction = new Label();
            textBox1 = new TextBox();
            classGroupControl.SuspendLayout();
            SuspendLayout();
            // 
            // classGroupControl
            // 
            classGroupControl.BackColor = Color.Transparent;
            classGroupControl.Controls.Add(finalSolutionOutput);
            classGroupControl.Controls.Add(refelectionOutput);
            classGroupControl.Controls.Add(userInputForTerms);
            classGroupControl.Controls.Add(Calculate);
            classGroupControl.Controls.Add(inputInstruction);
            classGroupControl.ForeColor = Color.Transparent;
            classGroupControl.Location = new Point(200, 121);
            classGroupControl.Name = "classGroupControl";
            classGroupControl.Size = new Size(352, 241);
            classGroupControl.TabIndex = 0;
            classGroupControl.TabStop = false;
            // 
            // finalSolutionOutput
            // 
            finalSolutionOutput.BackColor = Color.Moccasin;
            finalSolutionOutput.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            finalSolutionOutput.ForeColor = Color.Olive;
            finalSolutionOutput.Location = new Point(112, 202);
            finalSolutionOutput.Name = "finalSolutionOutput";
            finalSolutionOutput.Size = new Size(174, 23);
            finalSolutionOutput.TabIndex = 11;
            finalSolutionOutput.TextAlign = ContentAlignment.TopCenter;
            // 
            // refelectionOutput
            // 
            refelectionOutput.BackColor = Color.Moccasin;
            refelectionOutput.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            refelectionOutput.ForeColor = Color.Olive;
            refelectionOutput.Location = new Point(50, 150);
            refelectionOutput.Name = "refelectionOutput";
            refelectionOutput.Size = new Size(280, 23);
            refelectionOutput.TabIndex = 10;
            refelectionOutput.TextAlign = ContentAlignment.TopCenter;
            // 
            // userInputForTerms
            // 
            userInputForTerms.Location = new Point(216, 65);
            userInputForTerms.Name = "userInputForTerms";
            userInputForTerms.Size = new Size(100, 23);
            userInputForTerms.TabIndex = 9;
            // 
            // Calculate
            // 
            Calculate.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Calculate.ForeColor = Color.Black;
            Calculate.Location = new Point(123, 106);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(142, 23);
            Calculate.TabIndex = 8;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // inputInstruction
            // 
            inputInstruction.BackColor = Color.Moccasin;
            inputInstruction.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            inputInstruction.ForeColor = Color.Olive;
            inputInstruction.Location = new Point(0, 65);
            inputInstruction.Name = "inputInstruction";
            inputInstruction.Size = new Size(174, 23);
            inputInstruction.TabIndex = 5;
            inputInstruction.Text = "Please enter # of terms:";
            inputInstruction.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(352, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "CST-150 // GCU // Owen Lindsey // Professor Smithers, Mark";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(681, 450);
            Controls.Add(classGroupControl);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Pi Approximation Aplication";
            classGroupControl.ResumeLayout(false);
            classGroupControl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox classGroupControl;
        private TextBox textBox1;
        private Button Calculate;
        private Label label1;
        private Label inputInstruction;
        private Label label2;
        private TextBox userInputForTerms;
        private Label finalSolutionOutput;
        private Label refelectionOutput;
    }
}