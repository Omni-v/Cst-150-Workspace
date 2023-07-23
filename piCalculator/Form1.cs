namespace piCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Calculate_Click(object sender, EventArgs e)
        {
            int n;
            double piVal = 4, num = 4, den = 3;
            n = Convert.ToInt32(userInputForTerms.Text);
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    piVal -= num / den;
                }
                else
                {
                    piVal += num / den;
                }
                den += 2;
            }
            refelectionOutput.Text = "Approximate value of pi after " + n + " terms";
            finalSolutionOutput.Text = "= " + piVal;
        }
    }
}