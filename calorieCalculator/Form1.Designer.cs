namespace calorieCalculator
{
    partial class CaloricCalculatorForm
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


        #endregion

        private GroupBox algorithimGroup;
        private Label carbsInGramsLabel;
        private TextBox fatInGramsTextBox;
        private Label fatInGramsLabel;
        private TextBox carbsInGramsInput;
        private Button convertToCalories;
        private Label carbsInCalories;
        private Label fatInCaloriesLabel;
        private Label ResultLabel;
        private Label ResultFatLabel;
    }
}