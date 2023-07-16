namespace Time_Calculator
{
    public partial class Time_CalculatorForm : Form
    {
        public Time_CalculatorForm()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click_1(object sender, EventArgs e)
        {
            //convert the number of seconds to days, hours, minutes, and seconds from the secondsTextBox and create an exception if the user enters a non-numeric value
            try
            {
                //declare variables
                double seconds, minutes, hours, days;

                //get the number of seconds from the user
                seconds = double.Parse(SecondsTextBox.Text);

                //calculate the number of minutes, hours, and days
                minutes = seconds / 60;
                hours = seconds / 3600;
                days = seconds / 86400;

                //display the number of minutes, hours, and days
                MinutesTextBox.Text = minutes.ToString("n2");
                HoursTextBox.Text = hours.ToString("n2");
                DaysTextBox.Text = days.ToString("n2");
            }
            catch
            {
                //display an error message if the user enters a non-numeric value
                MessageBox.Show("Please enter a numeric value.");
            }

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //clear the text boxes
            SecondsTextBox.Text = "";
            MinutesTextBox.Text = "";
            HoursTextBox.Text = "";
            DaysTextBox.Text = "";

        }
    }
}
