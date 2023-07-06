namespace pictureBox
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
            cssTimeline = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cssTimeline).BeginInit();
            SuspendLayout();
            // 
            // cssTimeline
            // 
            cssTimeline.Image = (Image)resources.GetObject("cssTimeline.Image");
            cssTimeline.Location = new Point(24, 3);
            cssTimeline.Name = "cssTimeline";
            cssTimeline.Size = new Size(499, 380);
            cssTimeline.SizeMode = PictureBoxSizeMode.Zoom;
            cssTimeline.TabIndex = 0;
            cssTimeline.TabStop = false;
            cssTimeline.Click += cssTimeline_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cssTimeline);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cssTimeline).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cssTimeline;
    }
}