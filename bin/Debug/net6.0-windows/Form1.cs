namespace calorieCalculator
{
    public partial class CaloricCalculatorForm : Form
    {
        public CaloricCalculatorForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            algorithimGroup = new GroupBox();
            ResultFatLabel = new Label();
            ResultLabel = new Label();
            carbsInCalories = new Label();
            fatInCaloriesLabel = new Label();
            convertToCalories = new Button();
            carbsInGramsInput = new TextBox();
            carbsInGramsLabel = new Label();
            fatInGramsTextBox = new TextBox();
            fatInGramsLabel = new Label();
            algorithimGroup.SuspendLayout();
            SuspendLayout();
            // 
            // algorithimGroup
            // 
            algorithimGroup.BackColor = Color.Ivory;
            algorithimGroup.Controls.Add(ResultFatLabel);
            algorithimGroup.Controls.Add(ResultLabel);
            algorithimGroup.Controls.Add(carbsInCalories);
            algorithimGroup.Controls.Add(fatInCaloriesLabel);
            algorithimGroup.Controls.Add(convertToCalories);
            algorithimGroup.Controls.Add(carbsInGramsInput);
            algorithimGroup.Controls.Add(carbsInGramsLabel);
            algorithimGroup.Controls.Add(fatInGramsTextBox);
            algorithimGroup.Controls.Add(fatInGramsLabel);
            algorithimGroup.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            algorithimGroup.Location = new Point(94, 108);
            algorithimGroup.Name = "algorithimGroup";
            algorithimGroup.Size = new Size(495, 332);
            algorithimGroup.TabIndex = 0;
            algorithimGroup.TabStop = false;
            algorithimGroup.Text = "Diet Calculator";
            // 
            // ResultFatLabel
            // 
            ResultFatLabel.AutoSize = true;
            ResultFatLabel.Location = new Point(147, 230);
            ResultFatLabel.Name = "ResultFatLabel";
            ResultFatLabel.Size = new Size(27, 19);
            ResultFatLabel.TabIndex = 8;
            ResultFatLabel.Text = "\"\"";
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(147, 202);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(27, 19);
            ResultLabel.TabIndex = 7;
            ResultLabel.Text = "\"\"";
            ResultLabel.Click += ResultLabel_Click;
            // 
            // carbsInCalories
            // 
            carbsInCalories.AutoSize = true;
            carbsInCalories.Location = new Point(205, 248);
            carbsInCalories.Name = "carbsInCalories";
            carbsInCalories.Size = new Size(0, 19);
            carbsInCalories.TabIndex = 6;
            // 
            // fatInCaloriesLabel
            // 
            fatInCaloriesLabel.AutoSize = true;
            fatInCaloriesLabel.Location = new Point(205, 202);
            fatInCaloriesLabel.Name = "fatInCaloriesLabel";
            fatInCaloriesLabel.Size = new Size(0, 19);
            fatInCaloriesLabel.TabIndex = 5;
            // 
            // convertToCalories
            // 
            convertToCalories.Location = new Point(147, 137);
            convertToCalories.Name = "convertToCalories";
            convertToCalories.Size = new Size(182, 41);
            convertToCalories.TabIndex = 4;
            convertToCalories.Text = "Convert to calories";
            convertToCalories.UseVisualStyleBackColor = true;
            convertToCalories.Click += convertToCalories_Click;
            // 
            // carbsInGramsInput
            // 
            carbsInGramsInput.Location = new Point(377, 79);
            carbsInGramsInput.Name = "carbsInGramsInput";
            carbsInGramsInput.Size = new Size(100, 26);
            carbsInGramsInput.TabIndex = 3;
            carbsInGramsInput.TextChanged += textBox1_TextChanged;
            // 
            // carbsInGramsLabel
            // 
            carbsInGramsLabel.AutoSize = true;
            carbsInGramsLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            carbsInGramsLabel.Location = new Point(6, 83);
            carbsInGramsLabel.Name = "carbsInGramsLabel";
            carbsInGramsLabel.Size = new Size(374, 17);
            carbsInGramsLabel.TabIndex = 2;
            carbsInGramsLabel.Text = "Record the amount of carbohydrates in grams please -->";
            // 
            // fatInGramsTextBox
            // 
            fatInGramsTextBox.Location = new Point(320, 37);
            fatInGramsTextBox.Name = "fatInGramsTextBox";
            fatInGramsTextBox.Size = new Size(100, 26);
            fatInGramsTextBox.TabIndex = 1;
            fatInGramsTextBox.TextChanged += fatInGramsTextBox_TextChanged;
            // 
            // fatInGramsLabel
            // 
            fatInGramsLabel.AutoSize = true;
            fatInGramsLabel.BorderStyle = BorderStyle.FixedSingle;
            fatInGramsLabel.Location = new Point(6, 37);
            fatInGramsLabel.Name = "fatInGramsLabel";
            fatInGramsLabel.Size = new Size(308, 21);
            fatInGramsLabel.TabIndex = 0;
            fatInGramsLabel.Text = "Record the amount of fat in grams please -->";
            // 
            // CaloricCalculatorForm
            // 
            BackColor = Color.RosyBrown;
            ClientSize = new Size(653, 583);
            Controls.Add(algorithimGroup);
            Name = "CaloricCalculatorForm";
            Text = "Caloric intake calculator";
            algorithimGroup.ResumeLayout(false);
            algorithimGroup.PerformLayout();
            ResumeLayout(false);
        }

        private void fatInGramsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void convertToCalories_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(fatInGramsTextBox.Text, out double fatInGrams))
                {
                    MessageBox.Show("Please enter a valid number for fat in grams");
                    return;
                }
                if (!double.TryParse(carbsInGramsInput.Text, out double carbsInGrams))
                {
                    MessageBox.Show("Please enter a valid number for carbs in grams");
                    return;
                }
                double fatInCalories = fatInGrams * 9;
                double carbsInCalories = carbsInGrams * 4;

                ResultFatLabel.Text = $"Fat in calories: {fatInCalories}";
                ResultLabel.Text = $"Carbs in calories: {carbsInCalories}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}