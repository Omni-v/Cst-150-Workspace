namespace latinTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            emptyBox.Text = "sinister";
        }

        private void middleButton_Click(object sender, EventArgs e)
        {
            emptyBox.Text = "medium";
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            emptyBox.Text = "dexter";
        }
    }
}