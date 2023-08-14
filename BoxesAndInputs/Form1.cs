namespace BoxesAndInputs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string computerType = "";
            if (rbDesktop.Checked) computerType = "Desktop";
            if (rbLaptop.Checked) computerType = "Laptop";
            if (rbTablet.Checked) computerType = "Tablet";

            List<string> accessories = new List<string>();
            if (chkMouse.Checked) accessories.Add("Mouse");
            if (chkKeyboard.Checked) accessories.Add("Keyboard");
            if (chkHeadphones.Checked) accessories.Add("Headphones");

            string software = lbSoftware.SelectedItem?.ToString() ?? "None";

            string outputText = $"Selected Computer: {computerType}\n" +
                                $"Accessories: {string.Join(", ", accessories)}\n" +
                                $"Software: {software}";

            

            // Write to an output file
            string outputPath = @"C:\CST-150-new-folder\BoxesAndInputs\orderOutput.txt";
            File.WriteAllText(outputPath, outputText);
        }

    }
}