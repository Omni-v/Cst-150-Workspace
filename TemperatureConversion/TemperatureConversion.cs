using System.Drawing.Text;

namespace TemperatureConversion
{
    public partial class temperatureConversionApp : Form
    {
        public temperatureConversionApp()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(temperatureConversionApp));
            inputInstrucitons = new Label();
            FahrenheitInput = new TextBox();
            CelciusOutputInformation = new Label();
            celciusInformation = new TextBox();
            FahrenheitToCelcius = new Button();
            title = new TextBox();
            resetCalculation = new Button();
            SuspendLayout();
            // 
            // inputInstrucitons
            // 
            inputInstrucitons.BackColor = SystemColors.ControlLightLight;
            inputInstrucitons.BorderStyle = BorderStyle.FixedSingle;
            inputInstrucitons.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            inputInstrucitons.Location = new Point(79, 81);
            inputInstrucitons.Name = "inputInstrucitons";
            inputInstrucitons.Size = new Size(205, 23);
            inputInstrucitons.TabIndex = 0;
            inputInstrucitons.Text = "Type current weather in fahrenheit. ";
            // 
            // FahrenheitInput
            // 
            FahrenheitInput.Location = new Point(309, 81);
            FahrenheitInput.Name = "FahrenheitInput";
            FahrenheitInput.Size = new Size(100, 23);
            FahrenheitInput.TabIndex = 1;
            // 
            // CelciusOutputInformation
            // 
            CelciusOutputInformation.BackColor = SystemColors.ControlLightLight;
            CelciusOutputInformation.BorderStyle = BorderStyle.FixedSingle;
            CelciusOutputInformation.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CelciusOutputInformation.Location = new Point(79, 119);
            CelciusOutputInformation.Name = "CelciusOutputInformation";
            CelciusOutputInformation.Size = new Size(205, 23);
            CelciusOutputInformation.TabIndex = 2;
            CelciusOutputInformation.Text = "Current temp converted to Celcius";
            // 
            // celciusInformation
            // 
            celciusInformation.Location = new Point(309, 119);
            celciusInformation.Name = "celciusInformation";
            celciusInformation.Size = new Size(100, 23);
            celciusInformation.TabIndex = 3;
            // 
            // FahrenheitToCelcius
            // 
            FahrenheitToCelcius.Location = new Point(279, 166);
            FahrenheitToCelcius.Name = "FahrenheitToCelcius";
            FahrenheitToCelcius.Size = new Size(75, 23);
            FahrenheitToCelcius.TabIndex = 4;
            FahrenheitToCelcius.Text = "Convert";
            FahrenheitToCelcius.UseVisualStyleBackColor = true;
            FahrenheitToCelcius.Click += FahrenheitToCelcius_Click;
            // 
            // title
            // 
            title.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(79, 12);
            title.Name = "title";
            title.Size = new Size(329, 22);
            title.TabIndex = 5;
            title.Text = "CST-15-// GCU // Owen Lindsey // Professor Smithers Mark";
            // 
            // resetCalculation
            // 
            resetCalculation.Location = new Point(360, 166);
            resetCalculation.Name = "resetCalculation";
            resetCalculation.Size = new Size(75, 23);
            resetCalculation.TabIndex = 6;
            resetCalculation.Text = "Reset";
            resetCalculation.UseVisualStyleBackColor = true;
            resetCalculation.Click += resetCalculation_Click;
            // 
            // temperatureConversionApp
            // 
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(556, 261);
            Controls.Add(resetCalculation);
            Controls.Add(title);
            Controls.Add(FahrenheitToCelcius);
            Controls.Add(celciusInformation);
            Controls.Add(CelciusOutputInformation);
            Controls.Add(FahrenheitInput);
            Controls.Add(inputInstrucitons);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "temperatureConversionApp";
            Text = "Temperature Conversion Application";
            ResumeLayout(false);
            PerformLayout();
        }

        private void FahrenheitToCelcius_Click(object sender, EventArgs e)
        {
            //use exception handling to catch anything other than numbers and return an error while converting temperature from celcius to fahrenheit
            try
            {
                //convert fahrenheit to celcius
                double fahrenheit = double.Parse(FahrenheitInput.Text);
                double celcius = (fahrenheit - 32) * 5 / 9;
                celciusInformation.Text = celcius.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number.");
            }


        }
        //when reset button is clicked, clear the text boxes


        private void resetCalculation_Click(object sender, EventArgs e)
        {
            FahrenheitInput.Text = "";
            celciusInformation.Text = "";

        }
    }
}
