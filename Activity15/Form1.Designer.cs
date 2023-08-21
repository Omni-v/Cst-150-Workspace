using System;
using System.Windows.Forms;
using System.Drawing;

namespace Activity15
{
    public partial class LuckyNumberForm : Form
    {
        public LuckyNumberForm()
        {
            InitializeComponent();
            PopulateYears();
            goButton.Click += GoButton_Click;
        }

        private void PopulateYears()
        {
            for (int i = DateTime.Now.Year; i >= 1900; i--)
            {
                cbxYears.Items.Add(i);
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (cbxYears.SelectedItem != null)
            {
                int selectedYear = int.Parse(cbxYears.SelectedItem.ToString());
                Form2 form2 = new Form2(selectedYear);
                form2.Show();
            }
            else
            {
                MessageBox.Show("Please select a year before proceeding.");
            }
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cbxYears = new ComboBox();
            goButton = new Button();
            txtPrompt = new TextBox();

            SuspendLayout();

            // cbxYears
            cbxYears.FormattingEnabled = true;
            cbxYears.Location = new Point(95, 92);
            cbxYears.Name = "cbxYears";
            cbxYears.Size = new Size(121, 27);
            cbxYears.TabIndex = 0;

            // goButton
            goButton.Location = new Point(118, 125);
            goButton.Name = "goButton";
            goButton.Size = new Size(75, 23);
            goButton.TabIndex = 1;
            goButton.Text = "Go";
            goButton.UseVisualStyleBackColor = true;

            // txtPrompt
            txtPrompt.Location = new Point(4, 60);
            txtPrompt.Name = "txtPrompt";
            txtPrompt.Size = new Size(299, 26);
            txtPrompt.TabIndex = 2;
            txtPrompt.Text = "select a year to recieve a random number. ";
            txtPrompt.TextAlign = HorizontalAlignment.Center;

            // LuckyNumberForm
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(309, 259);
            Controls.Add(txtPrompt);
            Controls.Add(goButton);
            Controls.Add(cbxYears);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "LuckyNumberForm";
            Text = "Random Number Generator";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxYears;
        private Button goButton;
        private TextBox txtPrompt;
    }
}
