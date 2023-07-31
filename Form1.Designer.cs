namespace buttonClicker
{
    partial class InventoryApplication
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        /// 
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

        private GroupBox informationGroup;
        private Label ItemIdNumberLabel;
        private Label TypeLabel;
        private Label QuantityLabel;
        private TextBox IdNumberTextBox;
        private TextBox TypeTextBox;
        private TextBox QuantityTextBox;
        private TextBox PriceTextBox;
        private Label priceLabel;
        private Label NameTag;
        private TextBox NameTextBox;
        private Button ExitFormButton;
        private Button addToInventory;



    }
}
