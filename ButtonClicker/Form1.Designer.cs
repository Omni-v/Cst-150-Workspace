namespace buttonClicker
{
    partial class buttonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buttonForm));
            solutionLabel = new Label();
            promptBox = new TextBox();
            addButton = new Button();
            subtractButton = new Button();
            multiplyButton = new Button();
            divideButton = new Button();
            resetButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // solutionLabel
            // 
            solutionLabel.BackColor = SystemColors.ActiveCaption;
            solutionLabel.BorderStyle = BorderStyle.FixedSingle;
            solutionLabel.Location = new Point(154, 101);
            solutionLabel.Name = "solutionLabel";
            solutionLabel.Size = new Size(100, 23);
            solutionLabel.TabIndex = 0;
            solutionLabel.Text = "\"\"";
            // 
            // promptBox
            // 
            promptBox.Location = new Point(105, 75);
            promptBox.Name = "promptBox";
            promptBox.Size = new Size(196, 23);
            promptBox.TabIndex = 1;
            promptBox.Text = "Click the buttons for a surprise";
            // 
            // addButton
            // 
            addButton.Location = new Point(82, 127);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 2;
            addButton.Text = "add +1";
            addButton.UseVisualStyleBackColor = true;
           
            // 
            // subtractButton
            // 
            subtractButton.Location = new Point(163, 127);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(75, 23);
            subtractButton.TabIndex = 3;
            subtractButton.Text = "subtract -1";
            subtractButton.UseVisualStyleBackColor = true;
            // 
            // multiplyButton
            // 
            multiplyButton.Location = new Point(244, 127);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(82, 23);
            multiplyButton.TabIndex = 4;
            multiplyButton.Text = "multiply * 2";
            multiplyButton.UseVisualStyleBackColor = true;
            // 
            // divideButton
            // 
            divideButton.Location = new Point(153, 156);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(101, 23);
            divideButton.TabIndex = 5;
            divideButton.Text = "divide by 2";
            divideButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(163, 185);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 6;
            resetButton.Text = "reset";
            resetButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-3, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(430, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // buttonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(427, 292);
            Controls.Add(resetButton);
            Controls.Add(divideButton);
            Controls.Add(multiplyButton);
            Controls.Add(subtractButton);
            Controls.Add(addButton);
            Controls.Add(promptBox);
            Controls.Add(solutionLabel);
            Controls.Add(pictureBox1);
            Name = "buttonForm";
            Text = "Click Me!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label solutionLabel;
        private TextBox promptBox;
        private Button addButton;
        private Button subtractButton;
        private Button multiplyButton;
        private Button divideButton;
        private Button resetButton;
        private PictureBox pictureBox1;
    }
}