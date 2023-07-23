using System.Diagnostics.Eventing.Reader;

namespace Activity5
{
    public partial class nameOrganizerApp : Form
    {
        public nameOrganizerApp()
        {
            InitializeComponent();
        }

        private void startOrganization_Click(object sender, EventArgs e)
        {
            //use the open file dialog to read the file and return the contents of the file with lowercase letters and display it in the organizationDisplay if the lowercase box is checked//
            if (LowerCaseLettersControl.Checked)
            {
                //open file dialog//
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFile.Title = "Open File";
                openFile.ShowDialog();

                //read the file//
                StreamReader reader = new StreamReader(openFile.FileName);
                string fileContents = reader.ReadToEnd();
                reader.Close();

                //display the file contents in the organizationDisplay//
                organizationDisplay.Text = fileContents.ToLower();
            }
            //if the firstAndLast box is checked open the file dialog and organize the names in a list from A-Z//
            if (firstAndLastControl.Checked)
            {
                //open file dialog//
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFile.Title = "Open File";
                openFile.ShowDialog();

                //read the file//
                StreamReader reader = new StreamReader(openFile.FileName);
                string fileContents = reader.ReadToEnd();
                reader.Close();

                //organize the names in a list from A-Z//
                string[] names = fileContents.Split('\n');
                Array.Sort(names);

                //display the first item in the list//
                organizationDisplay.Text = names[1];
                //display the last item in the list//
                organizationDisplay.Text += names[names.Length - 1];

            }
            //find the longest name in the list after opening the file dialog and display it in the organizationDisplay//
            if (longestWordControl.Checked)
            {
                //open file dialog//
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFile.Title = "Open File";
                openFile.ShowDialog();

                //read the file//
                StreamReader reader = new StreamReader(openFile.FileName);
                string fileContents = reader.ReadToEnd();
                reader.Close();

                //organize the names in a list from A-Z//
                string[] names = fileContents.Split('\n');
                Array.Sort(names);

                //find the longest name in the list//
                string longestName = "";
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i].Length > longestName.Length)
                    {
                        longestName = names[i];
                    }
                }
                //display the longest name in the organizationDisplay//
                organizationDisplay.Text = longestName;
            }
            //find the word with the most vowels in the list after opening the file dialog and display it in the organizationDisplay//
            if (longestVowelInput.Checked)
            {
                //open file dialog//
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFile.Title = "Open File";
                openFile.ShowDialog();

                //read the file//
                StreamReader reader = new StreamReader(openFile.FileName);
                string fileContents = reader.ReadToEnd();
                reader.Close();

                //organize the names in a list from A-Z//
                string[] names = fileContents.Split('\n');
                Array.Sort(names);

                //find the word with the most vowels in the list//
                string mostVowels = "";
                int mostVowelsCount = 0;
                for (int i = 0; i < names.Length; i++)
                {
                    int vowelCount = 0;
                    for (int j = 0; j < names[i].Length; j++)
                    {
                        if (names[i][j] == 'a' || names[i][j] == 'e' || names[i][j] == 'i' || names[i][j] == 'o' || names[i][j] == 'u')
                        {
                            vowelCount++;
                        }
                    }
                    if (vowelCount > mostVowelsCount)
                    {
                        mostVowelsCount = vowelCount;
                        mostVowels = names[i];
                    }
                }
                //display the word with the most vowels in the organizationDisplay//
                organizationDisplay.Text = mostVowels;
            }








        }
    }
}











