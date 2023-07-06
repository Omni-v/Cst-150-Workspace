namespace latinTranslator
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
            promptLabel = new Label();
            emptyBox = new Label();
            leftButton = new Button();
            middleButton = new Button();
            rightButton = new Button();
            SuspendLayout();
            // 
            // promptLabel
            // 
            promptLabel.AutoSize = true;
            promptLabel.Location = new Point(262, 160);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(297, 15);
            promptLabel.TabIndex = 0;
            promptLabel.Text = "Click one of the butttons to translate that word to latin.";
            // 
            // emptyBox
            // 
            emptyBox.BorderStyle = BorderStyle.FixedSingle;
            emptyBox.Location = new Point(299, 175);
            emptyBox.Name = "emptyBox";
            emptyBox.Size = new Size(200, 19);
            emptyBox.TabIndex = 1;
            emptyBox.TextAlign = ContentAlignment.MiddleCenter;
            emptyBox.Click += label2_Click;
            // 
            // leftButton
            // 
            leftButton.Location = new Point(275, 208);
            leftButton.Name = "leftButton";
            leftButton.Size = new Size(75, 23);
            leftButton.TabIndex = 2;
            leftButton.Text = "Left";
            leftButton.UseVisualStyleBackColor = true;
            leftButton.Click += leftButton_Click;
            // 
            // middleButton
            // 
            middleButton.Location = new Point(356, 208);
            middleButton.Name = "middleButton";
            middleButton.Size = new Size(75, 23);
            middleButton.TabIndex = 3;
            middleButton.Text = "Middle";
            middleButton.UseVisualStyleBackColor = true;
            middleButton.Click += middleButton_Click;
            // 
            // rightButton
            // 
            rightButton.Location = new Point(437, 208);
            rightButton.Name = "rightButton";
            rightButton.Size = new Size(75, 23);
            rightButton.TabIndex = 4;
            rightButton.Text = "Right";
            rightButton.UseVisualStyleBackColor = true;
            rightButton.Click += rightButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rightButton);
            Controls.Add(middleButton);
            Controls.Add(leftButton);
            Controls.Add(emptyBox);
            Controls.Add(promptLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label promptLabel;
        private Label emptyBox;
        private Button leftButton;
        private Button middleButton;
        private Button rightButton;
    }
}