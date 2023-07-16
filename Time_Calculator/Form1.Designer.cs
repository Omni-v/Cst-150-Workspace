namespace Time_Calculator
{
    partial class Time_CalculatorForm

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Time_CalculatorForm));
            CalculatorGroupBox = new GroupBox();
            ResetButton = new Button();
            ConvertButton = new Button();
            DaysTextBox = new TextBox();
            HoursTextBox = new TextBox();
            MinutesTextBox = new TextBox();
            SecondsTextBox = new TextBox();
            DaysLabel = new Label();
            HoursLabel = new Label();
            MinutesLabel = new Label();
            SecondsLabel = new Label();
            CalculatorGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CalculatorGroupBox
            // 
            CalculatorGroupBox.BackColor = SystemColors.Info;
            CalculatorGroupBox.Controls.Add(ResetButton);
            CalculatorGroupBox.Controls.Add(ConvertButton);
            CalculatorGroupBox.Controls.Add(DaysTextBox);
            CalculatorGroupBox.Controls.Add(HoursTextBox);
            CalculatorGroupBox.Controls.Add(MinutesTextBox);
            CalculatorGroupBox.Controls.Add(SecondsTextBox);
            CalculatorGroupBox.Controls.Add(DaysLabel);
            CalculatorGroupBox.Controls.Add(HoursLabel);
            CalculatorGroupBox.Controls.Add(MinutesLabel);
            CalculatorGroupBox.Controls.Add(SecondsLabel);
            CalculatorGroupBox.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CalculatorGroupBox.Location = new Point(182, 63);
            CalculatorGroupBox.Name = "CalculatorGroupBox";
            CalculatorGroupBox.Size = new Size(324, 188);
            CalculatorGroupBox.TabIndex = 0;
            CalculatorGroupBox.TabStop = false;
            CalculatorGroupBox.Text = "This will convert seconds to minutes, hours, and days";
            // 
            // ResetButton
            // 
            ResetButton.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ResetButton.Location = new Point(224, 133);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(79, 29);
            ResetButton.TabIndex = 9;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // ConvertButton
            // 
            ConvertButton.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ConvertButton.Location = new Point(224, 39);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(79, 29);
            ConvertButton.TabIndex = 8;
            ConvertButton.Text = "Convert";
            ConvertButton.UseVisualStyleBackColor = true;
            ConvertButton.Click += ConvertButton_Click_1;
            // 
            // DaysTextBox
            // 
            DaysTextBox.BorderStyle = BorderStyle.FixedSingle;
            DaysTextBox.Location = new Point(124, 134);
            DaysTextBox.Name = "DaysTextBox";
            DaysTextBox.Size = new Size(72, 27);
            DaysTextBox.TabIndex = 7;
            // 
            // HoursTextBox
            // 
            HoursTextBox.BorderStyle = BorderStyle.FixedSingle;
            HoursTextBox.Location = new Point(124, 103);
            HoursTextBox.Name = "HoursTextBox";
            HoursTextBox.Size = new Size(72, 27);
            HoursTextBox.TabIndex = 6;
            // 
            // MinutesTextBox
            // 
            MinutesTextBox.BorderStyle = BorderStyle.FixedSingle;
            MinutesTextBox.Location = new Point(124, 74);
            MinutesTextBox.Name = "MinutesTextBox";
            MinutesTextBox.Size = new Size(72, 27);
            MinutesTextBox.TabIndex = 5;
            // 
            // SecondsTextBox
            // 
            SecondsTextBox.BorderStyle = BorderStyle.FixedSingle;
            SecondsTextBox.Location = new Point(124, 45);
            SecondsTextBox.Name = "SecondsTextBox";
            SecondsTextBox.Size = new Size(72, 27);
            SecondsTextBox.TabIndex = 4;
            SecondsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DaysLabel
            // 
            DaysLabel.AutoSize = true;
            DaysLabel.BackColor = SystemColors.ControlLightLight;
            DaysLabel.ForeColor = SystemColors.ActiveCaptionText;
            DaysLabel.Location = new Point(64, 137);
            DaysLabel.Name = "DaysLabel";
            DaysLabel.Size = new Size(54, 20);
            DaysLabel.TabIndex = 3;
            DaysLabel.Text = "Days :";
            // 
            // HoursLabel
            // 
            HoursLabel.AutoSize = true;
            HoursLabel.BackColor = SystemColors.ControlLightLight;
            HoursLabel.ForeColor = SystemColors.ActiveCaptionText;
            HoursLabel.Location = new Point(56, 106);
            HoursLabel.Name = "HoursLabel";
            HoursLabel.Size = new Size(62, 20);
            HoursLabel.TabIndex = 2;
            HoursLabel.Text = "Hours :";
            // 
            // MinutesLabel
            // 
            MinutesLabel.AutoSize = true;
            MinutesLabel.BackColor = SystemColors.ControlLightLight;
            MinutesLabel.ForeColor = SystemColors.ActiveCaptionText;
            MinutesLabel.Location = new Point(41, 77);
            MinutesLabel.Name = "MinutesLabel";
            MinutesLabel.Size = new Size(77, 20);
            MinutesLabel.TabIndex = 1;
            MinutesLabel.Text = "Minutes :";
            // 
            // SecondsLabel
            // 
            SecondsLabel.AutoSize = true;
            SecondsLabel.BackColor = SystemColors.ControlLightLight;
            SecondsLabel.ForeColor = SystemColors.ActiveCaptionText;
            SecondsLabel.Location = new Point(6, 48);
            SecondsLabel.Name = "SecondsLabel";
            SecondsLabel.Size = new Size(115, 20);
            SecondsLabel.TabIndex = 0;
            SecondsLabel.Text = "Input Seconds:";
            // 
            // Time_CalculatorForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(675, 450);
            Controls.Add(CalculatorGroupBox);
            Name = "Time_CalculatorForm";
            Text = "Calculator";
            CalculatorGroupBox.ResumeLayout(false);
            CalculatorGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CalculatorGroupBox;
        private Label DaysLabel;
        private Label HoursLabel;
        private Label MinutesLabel;
        private Label SecondsLabel;
        private TextBox MinutesTextBox;
        private TextBox SecondsTextBox;
        private TextBox HoursTextBox;
        private Button ResetButton;
        private Button ConvertButton;
        private TextBox DaysTextBox;
    }
}