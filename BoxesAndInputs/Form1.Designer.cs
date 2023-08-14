namespace BoxesAndInputs
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
            rbDesktop = new RadioButton();
            rbLaptop = new RadioButton();
            rbTablet = new RadioButton();
            chkMouse = new CheckBox();
            chkHeadphones = new CheckBox();
            chkKeyboard = new CheckBox();
            ComputerTypeTextBox = new TextBox();
            AccessoriesTextBox = new TextBox();
            lbSoftware = new ListBox();
            textBox1 = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // rbDesktop
            // 
            rbDesktop.AutoSize = true;
            rbDesktop.Location = new Point(54, 102);
            rbDesktop.Name = "rbDesktop";
            rbDesktop.Size = new Size(96, 26);
            rbDesktop.TabIndex = 0;
            rbDesktop.TabStop = true;
            rbDesktop.Text = "Desktop";
            rbDesktop.UseVisualStyleBackColor = true;
            // 
            // rbLaptop
            // 
            rbLaptop.AutoSize = true;
            rbLaptop.Location = new Point(54, 134);
            rbLaptop.Name = "rbLaptop";
            rbLaptop.Size = new Size(86, 26);
            rbLaptop.TabIndex = 1;
            rbLaptop.TabStop = true;
            rbLaptop.Text = "Laptop";
            rbLaptop.UseVisualStyleBackColor = true;
            // 
            // rbTablet
            // 
            rbTablet.AutoSize = true;
            rbTablet.Location = new Point(54, 166);
            rbTablet.Name = "rbTablet";
            rbTablet.Size = new Size(79, 26);
            rbTablet.TabIndex = 2;
            rbTablet.TabStop = true;
            rbTablet.Text = "Tablet";
            rbTablet.UseVisualStyleBackColor = true;
            // 
            // chkMouse
            // 
            chkMouse.AutoSize = true;
            chkMouse.Location = new Point(54, 245);
            chkMouse.Name = "chkMouse";
            chkMouse.Size = new Size(84, 26);
            chkMouse.TabIndex = 3;
            chkMouse.Text = "Mouse";
            chkMouse.UseVisualStyleBackColor = true;
            // 
            // chkHeadphones
            // 
            chkHeadphones.AutoSize = true;
            chkHeadphones.Location = new Point(54, 309);
            chkHeadphones.Name = "chkHeadphones";
            chkHeadphones.Size = new Size(129, 26);
            chkHeadphones.TabIndex = 4;
            chkHeadphones.Text = "Headphones";
            chkHeadphones.UseVisualStyleBackColor = true;
            // 
            // chkKeyboard
            // 
            chkKeyboard.AutoSize = true;
            chkKeyboard.Location = new Point(54, 277);
            chkKeyboard.Name = "chkKeyboard";
            chkKeyboard.Size = new Size(109, 26);
            chkKeyboard.TabIndex = 5;
            chkKeyboard.Text = "Keyboard";
            chkKeyboard.UseVisualStyleBackColor = true;
            // 
            // ComputerTypeTextBox
            // 
            ComputerTypeTextBox.Location = new Point(54, 58);
            ComputerTypeTextBox.Name = "ComputerTypeTextBox";
            ComputerTypeTextBox.Size = new Size(501, 29);
            ComputerTypeTextBox.TabIndex = 6;
            ComputerTypeTextBox.Text = "Please indicate what type of computer you wish to purchase";
            // 
            // AccessoriesTextBox
            // 
            AccessoriesTextBox.Location = new Point(54, 210);
            AccessoriesTextBox.Name = "AccessoriesTextBox";
            AccessoriesTextBox.Size = new Size(453, 29);
            AccessoriesTextBox.TabIndex = 7;
            AccessoriesTextBox.Text = "Please indicate what accessories you wish to purchase";
            // 
            // lbSoftware
            // 
            lbSoftware.FormattingEnabled = true;
            lbSoftware.ItemHeight = 22;
            lbSoftware.Items.AddRange(new object[] { "Microsoft Office", "Adobe Suite", "McAfee Antivirus " });
            lbSoftware.Location = new Point(54, 376);
            lbSoftware.Name = "lbSoftware";
            lbSoftware.Size = new Size(247, 92);
            lbSoftware.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 341);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(625, 29);
            textBox1.TabIndex = 9;
            textBox1.Text = "Please indicate which software packages you wish to add onto the computer";
            // 
            // btnSubmit
            // 
            btnSubmit.ForeColor = Color.ForestGreen;
            btnSubmit.Location = new Point(282, 487);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(188, 43);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit order";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(808, 672);
            Controls.Add(btnSubmit);
            Controls.Add(textBox1);
            Controls.Add(lbSoftware);
            Controls.Add(AccessoriesTextBox);
            Controls.Add(ComputerTypeTextBox);
            Controls.Add(chkKeyboard);
            Controls.Add(chkHeadphones);
            Controls.Add(chkMouse);
            Controls.Add(rbTablet);
            Controls.Add(rbLaptop);
            Controls.Add(rbDesktop);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Create your computer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbDesktop;
        private RadioButton rbLaptop;
        private RadioButton rbTablet;
        private CheckBox chkMouse;
        private CheckBox chkHeadphones;
        private CheckBox chkKeyboard;
        private TextBox ComputerTypeTextBox;
        private TextBox AccessoriesTextBox;
        private ListBox lbSoftware;
        private TextBox textBox1;
        private Button btnSubmit;
    }
}