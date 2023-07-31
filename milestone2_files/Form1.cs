using Milestone;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;


namespace buttonClicker;



public partial class InventoryApplication : Form
{

    private  InventoryManager inventoryManager;

    public InventoryApplication()
    {
        InitializeComponent();
        this.inventoryManager = new InventoryManager();
    }
  private void addToInventory_Click(object sender, EventArgs e)
    {
        try
        {
            var newItem = this.inventoryManager.AddItem(IdNumberTextBox.Text, NameTextBox.Text, PriceTextBox.Text,
                QuantityTextBox.Text, TypeTextBox.Text);

            MessageBox.Show("Item added to inventory");

            IdNumberTextBox.Clear();
            NameTextBox.Clear();
            PriceTextBox.Clear();
            QuantityTextBox.Clear();
            TypeTextBox.Clear();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void InitializeComponent()
    {
        informationGroup = new GroupBox();
        ExitFormButton = new Button();
        addToInventory = new Button();
        ItemIdNumberLabel = new Label();
        TypeLabel = new Label();
        QuantityLabel = new Label();
        IdNumberTextBox = new TextBox();
        TypeTextBox = new TextBox();
        QuantityTextBox = new TextBox();
        PriceTextBox = new TextBox();
        priceLabel = new Label();
        NameTag = new Label();
        NameTextBox = new TextBox();
        informationGroup.SuspendLayout();
        SuspendLayout();
        // 
        // informationGroup
        // 
        informationGroup.BackColor = Color.White;
        informationGroup.Controls.Add(ExitFormButton);
        informationGroup.Controls.Add(addToInventory);
        informationGroup.Controls.Add(ItemIdNumberLabel);
        informationGroup.Controls.Add(TypeLabel);
        informationGroup.Controls.Add(QuantityLabel);
        informationGroup.Controls.Add(IdNumberTextBox);
        informationGroup.Controls.Add(TypeTextBox);
        informationGroup.Controls.Add(QuantityTextBox);
        informationGroup.Controls.Add(PriceTextBox);
        informationGroup.Controls.Add(priceLabel);
        informationGroup.Controls.Add(NameTag);
        informationGroup.Controls.Add(NameTextBox);
        informationGroup.Location = new Point(98, 118);
        informationGroup.Name = "informationGroup";
        informationGroup.Size = new Size(413, 452);
        informationGroup.TabIndex = 0;
        informationGroup.TabStop = false;
        informationGroup.Text = "Required Information";
        // 
        // ExitFormButton
        // 
        ExitFormButton.BackColor = Color.IndianRed;
        ExitFormButton.Location = new Point(290, 350);
        ExitFormButton.Name = "ExitFormButton";
        ExitFormButton.Size = new Size(75, 42);
        ExitFormButton.TabIndex = 11;
        ExitFormButton.Text = "Exit";
        ExitFormButton.UseVisualStyleBackColor = false;
        // 
        // addToInventory
        // 
        addToInventory.BackColor = Color.SeaGreen;
        addToInventory.Location = new Point(264, 175);
        addToInventory.Name = "addToInventory";
        addToInventory.Size = new Size(133, 156);
        addToInventory.TabIndex = 10;
        addToInventory.Text = "Add Item to the inventory";
        addToInventory.UseVisualStyleBackColor = false;
        addToInventory.Click += addToInventory_Click;
        // 
        // ItemIdNumberLabel
        // 
        ItemIdNumberLabel.AutoSize = true;
        ItemIdNumberLabel.Location = new Point(70, 63);
        ItemIdNumberLabel.Name = "ItemIdNumberLabel";
        ItemIdNumberLabel.Size = new Size(101, 28);
        ItemIdNumberLabel.TabIndex = 9;
        ItemIdNumberLabel.Text = "Item ID#";
        // 
        // TypeLabel
        // 
        TypeLabel.AutoSize = true;
        TypeLabel.Location = new Point(0, 303);
        TypeLabel.Name = "TypeLabel";
        TypeLabel.Size = new Size(60, 28);
        TypeLabel.TabIndex = 8;
        TypeLabel.Text = "Type";
        // 
        // QuantityLabel
        // 
        QuantityLabel.AutoSize = true;
        QuantityLabel.Location = new Point(0, 246);
        QuantityLabel.Name = "QuantityLabel";
        QuantityLabel.Size = new Size(99, 28);
        QuantityLabel.TabIndex = 7;
        QuantityLabel.Text = "Quantity";
        // 
        // IdNumberTextBox
        // 
        IdNumberTextBox.Location = new Point(179, 60);
        IdNumberTextBox.Name = "IdNumberTextBox";
        IdNumberTextBox.Size = new Size(100, 35);
        IdNumberTextBox.TabIndex = 6;
        // 
        // TypeTextBox
        // 
        TypeTextBox.Location = new Point(90, 296);
        TypeTextBox.Name = "TypeTextBox";
        TypeTextBox.Size = new Size(100, 35);
        TypeTextBox.TabIndex = 5;
        // 
        // QuantityTextBox
        // 
        QuantityTextBox.Location = new Point(105, 243);
        QuantityTextBox.Name = "QuantityTextBox";
        QuantityTextBox.Size = new Size(100, 35);
        QuantityTextBox.TabIndex = 4;
        // 
        // PriceTextBox
        // 
        PriceTextBox.Location = new Point(90, 177);
        PriceTextBox.Name = "PriceTextBox";
        PriceTextBox.Size = new Size(100, 35);
        PriceTextBox.TabIndex = 3;
        // 
        // priceLabel
        // 
        priceLabel.AutoSize = true;
        priceLabel.Location = new Point(6, 184);
        priceLabel.Name = "priceLabel";
        priceLabel.Size = new Size(62, 28);
        priceLabel.TabIndex = 2;
        priceLabel.Text = "price";
        // 
        // NameTag
        // 
        NameTag.AutoSize = true;
        NameTag.Location = new Point(6, 122);
        NameTag.Name = "NameTag";
        NameTag.Size = new Size(70, 28);
        NameTag.TabIndex = 1;
        NameTag.Text = "Name";
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(90, 115);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.Size = new Size(100, 35);
        NameTextBox.TabIndex = 0;
        // 
        // InventoryApplication
        // 
        BackColor = Color.IndianRed;
        ClientSize = new Size(642, 664);
        Controls.Add(informationGroup);
        Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        Name = "InventoryApplication";
        Text = "inventoryApplication";
        informationGroup.ResumeLayout(false);
        informationGroup.PerformLayout();
        ResumeLayout(false);
    }


      

  

    
}
    






