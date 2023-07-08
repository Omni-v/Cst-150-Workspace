namespace TemperatureConversion
{
    public partial class TempForm : Form
    {
        public TempForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Prompt = new Label();
            UserInput = new TextBox();
            Output = new Label();
            this.outputBox = new TextBox();
            this.ConvertButton = new Button();
            SuspendLayout();
            // 
            // Prompt
            // 
            Prompt.BackColor = SystemColors.ControlLightLight;
            Prompt.BorderStyle = BorderStyle.FixedSingle;
            Prompt.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Prompt.Location = new Point(79, 81);
            Prompt.Name = "Prompt";
            Prompt.Size = new Size(205, 23);
            Prompt.TabIndex = 0;
            Prompt.Text = "Type current weather in fahrenheit. ";
            // 
            // UserInput
            // 
            UserInput.Location = new Point(309, 81);
            UserInput.Name = "UserInput";
            UserInput.Size = new Size(100, 23);
            UserInput.TabIndex = 1;
            // 
            // Output
            // 
            Output.BackColor = SystemColors.ControlLightLight;
            Output.BorderStyle = BorderStyle.FixedSingle;
            Output.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Output.Location = new Point(79, 119);
            Output.Name = "Output";
            Output.Size = new Size(205, 23);
            Output.TabIndex = 2;
            Output.Text = "Current temp converted to Celcius";
            // 
            // outputBox
            // 
            this.outputBox.Location = new Point(309, 119);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new Size(100, 23);
            this.outputBox.TabIndex = 3;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new Point(324, 166);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new Size(75, 23);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += this.ConvertButton_Click;
            // 
            // TempForm
            // 
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(556, 261);
            Controls.Add(this.ConvertButton);
            Controls.Add(this.outputBox);
            Controls.Add(Output);
            Controls.Add(UserInput);
            Controls.Add(Prompt);
            Name = "TempForm";
            Text = "TempForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            /*create a calculator for converting fahrenheit to celcius*/
            double fahrenheit = double.Parse(UserInput.Text);
            double celcius = (fahrenheit - 32) * 5 / 9;
            outputBox.Text = celcius.ToString();

        }
    }
}