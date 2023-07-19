namespace Milestone
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryApplication));
            addOneToInventory = new Button();
            resetApplication = new Button();
            Image = new PictureBox();
            clearStock = new Button();
            CurrentStock = new Button();
            itemsInStockDisplay = new Label();
            sellItems = new Button();
            Title = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Image).BeginInit();
            SuspendLayout();
            // 
            // addOneToInventory
            // 
            addOneToInventory.BackColor = Color.Silver;
            addOneToInventory.FlatStyle = FlatStyle.Flat;
            addOneToInventory.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addOneToInventory.ForeColor = Color.Transparent;
            addOneToInventory.Location = new Point(122, 513);
            addOneToInventory.Margin = new Padding(4);
            addOneToInventory.Name = "addOneToInventory";
            addOneToInventory.Size = new Size(351, 60);
            addOneToInventory.TabIndex = 2;
            addOneToInventory.Text = "Add 1 to the current inventory.\r\n";
            addOneToInventory.UseVisualStyleBackColor = false;
            addOneToInventory.Click += addOneToInventory_Click;
            // 
            // resetApplication
            // 
            resetApplication.BackColor = Color.Silver;
            resetApplication.FlatStyle = FlatStyle.Flat;
            resetApplication.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            resetApplication.ForeColor = Color.Transparent;
            resetApplication.Location = new Point(122, 379);
            resetApplication.Margin = new Padding(4);
            resetApplication.Name = "resetApplication";
            resetApplication.Size = new Size(351, 60);
            resetApplication.TabIndex = 6;
            resetApplication.Text = "reset inventory to default values. ";
            resetApplication.UseVisualStyleBackColor = false;
            resetApplication.Click += resetApplication_Click;
            // 
            // Image
            // 
            Image.BackgroundImage = (Image)resources.GetObject("Image.BackgroundImage");
            Image.BackgroundImageLayout = ImageLayout.Zoom;
            Image.Location = new Point(-120, -54);
            Image.Margin = new Padding(4);
            Image.Name = "Image";
            Image.Size = new Size(1461, 760);
            Image.SizeMode = PictureBoxSizeMode.Zoom;
            Image.TabIndex = 7;
            Image.TabStop = false;
            // 
            // clearStock
            // 
            clearStock.BackColor = Color.LightGray;
            clearStock.FlatStyle = FlatStyle.Flat;
            clearStock.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            clearStock.ForeColor = Color.Transparent;
            clearStock.Location = new Point(122, 446);
            clearStock.Name = "clearStock";
            clearStock.Size = new Size(351, 60);
            clearStock.TabIndex = 8;
            clearStock.Text = "Set current stock to zero. ";
            clearStock.UseVisualStyleBackColor = false;
            clearStock.Click += clearStock_Click;
            // 
            // CurrentStock
            // 
            CurrentStock.BackColor = Color.Silver;
            CurrentStock.BackgroundImageLayout = ImageLayout.Zoom;
            CurrentStock.FlatStyle = FlatStyle.Flat;
            CurrentStock.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentStock.ForeColor = Color.Transparent;
            CurrentStock.Location = new Point(122, 254);
            CurrentStock.Name = "CurrentStock";
            CurrentStock.Size = new Size(351, 56);
            CurrentStock.TabIndex = 11;
            CurrentStock.Text = "Check current inventory. ";
            CurrentStock.UseVisualStyleBackColor = false;
            CurrentStock.Click += CurrentStock_Click;
            // 
            // itemsInStockDisplay
            // 
            itemsInStockDisplay.BackColor = SystemColors.Desktop;
            itemsInStockDisplay.Location = new Point(122, 117);
            itemsInStockDisplay.Name = "itemsInStockDisplay";
            itemsInStockDisplay.Size = new Size(351, 124);
            itemsInStockDisplay.TabIndex = 12;
            itemsInStockDisplay.Text = "\"\"";
            // 
            // sellItems
            // 
            sellItems.BackColor = Color.Silver;
            sellItems.FlatStyle = FlatStyle.Flat;
            sellItems.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            sellItems.ForeColor = Color.Transparent;
            sellItems.Location = new Point(122, 316);
            sellItems.Name = "sellItems";
            sellItems.Size = new Size(351, 56);
            sellItems.TabIndex = 13;
            sellItems.Text = "Sell one of each soda. ";
            sellItems.UseVisualStyleBackColor = false;
            sellItems.Click += sellItems_Click;
            // 
            // Title
            // 
            Title.BackColor = SystemColors.HighlightText;
            Title.Dock = DockStyle.Top;
            Title.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.ShortcutsEnabled = false;
            Title.Size = new Size(672, 28);
            Title.TabIndex = 14;
            Title.Text = "Owen Lindsey///\r\nProfessor Smithers, Mark///\r\n\r\nMilestone project///\r\n\r\nCST-120///\r\nGCU";
            // 
            // InventoryApplication
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(672, 641);
            Controls.Add(Title);
            Controls.Add(sellItems);
            Controls.Add(itemsInStockDisplay);
            Controls.Add(CurrentStock);
            Controls.Add(clearStock);
            Controls.Add(resetApplication);
            Controls.Add(addOneToInventory);
            Controls.Add(Image);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.LimeGreen;
            Margin = new Padding(4);
            Name = "InventoryApplication";
            Text = "Inventory Manager";
            ((System.ComponentModel.ISupportInitialize)Image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addOneToInventory;
        private Button resetApplication;
        private PictureBox Image;
        private Button clearStock;
        private Button CurrentStock;
        private Label itemsInStockDisplay;
        private Button sellItems;
        private TextBox Title;
    }
}
