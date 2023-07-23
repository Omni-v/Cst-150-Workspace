namespace Activity5
{
    partial class nameOrganizerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nameOrganizerApp));
            groupBox1 = new GroupBox();
            startOrganization = new Button();
            organizationDisplay = new Label();
            organizationalInstructions = new Label();
            longestVowelInput = new CheckBox();
            longestWordControl = new CheckBox();
            firstAndLastControl = new CheckBox();
            LowerCaseLettersControl = new CheckBox();
            appInstructions = new Label();
            Title = new TextBox();
            OpenFileToOrganizationApp = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(startOrganization);
            groupBox1.Controls.Add(organizationDisplay);
            groupBox1.Controls.Add(organizationalInstructions);
            groupBox1.Controls.Add(longestVowelInput);
            groupBox1.Controls.Add(longestWordControl);
            groupBox1.Controls.Add(firstAndLastControl);
            groupBox1.Controls.Add(LowerCaseLettersControl);
            groupBox1.Controls.Add(appInstructions);
            groupBox1.Location = new Point(12, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(659, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // startOrganization
            // 
            startOrganization.BackColor = Color.White;
            startOrganization.BackgroundImageLayout = ImageLayout.None;
            startOrganization.ForeColor = SystemColors.ActiveCaptionText;
            startOrganization.Location = new Point(17, 177);
            startOrganization.Name = "startOrganization";
            startOrganization.Size = new Size(159, 30);
            startOrganization.TabIndex = 7;
            startOrganization.Text = "Organize the file.";
            startOrganization.UseVisualStyleBackColor = false;
            startOrganization.Click += startOrganization_Click;
            // 
            // organizationDisplay
            // 
            organizationDisplay.BackColor = Color.GhostWhite;
            organizationDisplay.BorderStyle = BorderStyle.FixedSingle;
            organizationDisplay.ForeColor = SystemColors.ControlText;
            organizationDisplay.Location = new Point(398, 20);
            organizationDisplay.Name = "organizationDisplay";
            organizationDisplay.Size = new Size(253, 126);
            organizationDisplay.TabIndex = 6;
            organizationDisplay.Text = "\"\"";
            // 
            // organizationalInstructions
            // 
            organizationalInstructions.BackColor = Color.BlueViolet;
            organizationalInstructions.BorderStyle = BorderStyle.Fixed3D;
            organizationalInstructions.FlatStyle = FlatStyle.Flat;
            organizationalInstructions.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            organizationalInstructions.ForeColor = Color.White;
            organizationalInstructions.Location = new Point(17, 19);
            organizationalInstructions.Name = "organizationalInstructions";
            organizationalInstructions.Size = new Size(269, 41);
            organizationalInstructions.TabIndex = 5;
            organizationalInstructions.Text = "How do you wish to organize your file? You may choose more than one option. \r\n\r\n";
            organizationalInstructions.TextAlign = ContentAlignment.TopCenter;
            // 
            // longestVowelInput
            // 
            longestVowelInput.AutoSize = true;
            longestVowelInput.BackColor = Color.White;
            longestVowelInput.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            longestVowelInput.ForeColor = Color.DarkViolet;
            longestVowelInput.Location = new Point(17, 152);
            longestVowelInput.Name = "longestVowelInput";
            longestVowelInput.Size = new Size(216, 19);
            longestVowelInput.TabIndex = 4;
            longestVowelInput.Text = "Find the word with the most vowels";
            longestVowelInput.UseVisualStyleBackColor = false;
            // 
            // longestWordControl
            // 
            longestWordControl.AutoSize = true;
            longestWordControl.BackColor = Color.White;
            longestWordControl.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            longestWordControl.ForeColor = Color.DarkViolet;
            longestWordControl.Location = new Point(17, 127);
            longestWordControl.Name = "longestWordControl";
            longestWordControl.Size = new Size(149, 19);
            longestWordControl.TabIndex = 3;
            longestWordControl.Text = "Find the longest word. ";
            longestWordControl.UseVisualStyleBackColor = false;
            // 
            // firstAndLastControl
            // 
            firstAndLastControl.AutoSize = true;
            firstAndLastControl.BackColor = Color.White;
            firstAndLastControl.ForeColor = Color.DarkViolet;
            firstAndLastControl.Location = new Point(17, 102);
            firstAndLastControl.Name = "firstAndLastControl";
            firstAndLastControl.Size = new Size(272, 19);
            firstAndLastControl.TabIndex = 2;
            firstAndLastControl.Text = "Find the first word and last word alphabetically";
            firstAndLastControl.UseVisualStyleBackColor = false;
            // 
            // LowerCaseLettersControl
            // 
            LowerCaseLettersControl.AutoSize = true;
            LowerCaseLettersControl.BackColor = Color.White;
            LowerCaseLettersControl.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LowerCaseLettersControl.ForeColor = Color.BlueViolet;
            LowerCaseLettersControl.Location = new Point(17, 77);
            LowerCaseLettersControl.Name = "LowerCaseLettersControl";
            LowerCaseLettersControl.Size = new Size(138, 19);
            LowerCaseLettersControl.TabIndex = 1;
            LowerCaseLettersControl.Text = "All lower-case letters";
            LowerCaseLettersControl.UseVisualStyleBackColor = false;
            // 
            // appInstructions
            // 
            appInstructions.BackColor = Color.BlueViolet;
            appInstructions.BorderStyle = BorderStyle.Fixed3D;
            appInstructions.FlatStyle = FlatStyle.Flat;
            appInstructions.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            appInstructions.ForeColor = Color.White;
            appInstructions.Location = new Point(384, 152);
            appInstructions.Name = "appInstructions";
            appInstructions.Size = new Size(269, 63);
            appInstructions.TabIndex = 0;
            appInstructions.Text = "check the box that fits your organization preference // click the organize file button // open the desired file // End\r\n\r\n";
            appInstructions.TextAlign = ContentAlignment.TopCenter;
            // 
            // Title
            // 
            Title.Location = new Point(169, 2);
            Title.Name = "Title";
            Title.Size = new Size(373, 23);
            Title.TabIndex = 1;
            Title.Text = "CST-150//GCU//Owen Lindsey // Professor Smithers, Mark";
            // 
            // OpenFileToOrganizationApp
            // 
            OpenFileToOrganizationApp.FileName = "Names";
            OpenFileToOrganizationApp.InitialDirectory = "\"C:\\Cst-150-Workspace\\Activity5\\InputFolder\"";
            // 
            // nameOrganizerApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(675, 450);
            Controls.Add(Title);
            Controls.Add(groupBox1);
            Name = "nameOrganizerApp";
            Text = "Please import your file to be organized";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Title;
        private Label appInstructions;
        private CheckBox longestVowelInput;
        private CheckBox longestWord;
        private CheckBox firstAndLastControl;
        private CheckBox LowerCaseLettersControl;
        private Label organizationalInstructions;
        private OpenFileDialog OpenFileToOrganizationApp;
        private Label organizationDisplay;
        private Button startOrganization;
        private CheckBox longestWordControl;
    }
}