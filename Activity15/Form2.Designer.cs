using System;
using System.Drawing;
using System.Windows.Forms;

namespace Activity15
{
    public partial class Form2 : Form
    {
        private Label lblMessage;
        private Label lblLuckyNumber;

        public Form2(int year)
        {
            InitializeComponent();
            CalculateLuckyNumber(year);
        }

        private void CalculateLuckyNumber(int year)
        {
            int luckyNumber = (year * new Random().Next(1, 11)) % 100;
            lblMessage.Text = $"Your lucky number for the year {year} is:";
            lblLuckyNumber.Text = luckyNumber.ToString();
        }

        #region Windows Form Designer generated code

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

        private void InitializeComponent()
        {
            lblMessage = new Label();
            lblLuckyNumber = new Label();
            SuspendLayout();

            // lblMessage
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(90, 58);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 17);
            lblMessage.TabIndex = 0;
            lblMessage.TextAlign = ContentAlignment.BottomCenter;

            // lblLuckyNumber
            lblLuckyNumber.AutoSize = true;
            lblLuckyNumber.Location = new Point(160, 128);
            lblLuckyNumber.Name = "lblLuckyNumber";
            lblLuckyNumber.Size = new Size(0, 17);
            lblLuckyNumber.TabIndex = 1;

            // Form2
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(372, 216);
            Controls.Add(lblLuckyNumber);
            Controls.Add(lblMessage);
            Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Your Lucky Number";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
