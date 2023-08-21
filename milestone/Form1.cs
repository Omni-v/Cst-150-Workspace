using Milestone;
using System.ComponentModel;
using System;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;


namespace buttonClicker;



public partial class InventoryApplication : Form
{

    private InventoryManager inventoryManager;


    public InventoryApplication()
    {
        InitializeComponent();
        inventoryManager = new InventoryManager();


    }







    private void InitializeComponent()
    {
        informationGroup = new GroupBox();
        searchResultsListBox = new ListBox();
        btnSearch = new Button();
        chkAlphabeticalName = new CheckBox();
        chkPrice = new CheckBox();
        btnRestock = new Button();
        btnRemove = new Button();
        btnDisplayItems = new Button();
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
        informationGroup.Controls.Add(searchResultsListBox);
        informationGroup.Controls.Add(btnSearch);
        informationGroup.Controls.Add(chkAlphabeticalName);
        informationGroup.Controls.Add(chkPrice);
        informationGroup.Controls.Add(btnRestock);
        informationGroup.Controls.Add(btnRemove);
        informationGroup.Controls.Add(btnDisplayItems);
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
        informationGroup.Size = new Size(917, 452);
        informationGroup.TabIndex = 0;
        informationGroup.TabStop = false;
        informationGroup.Text = "Required Information";
        // 
        // searchResultsListBox
        // 
        searchResultsListBox.FormattingEnabled = true;
        searchResultsListBox.ItemHeight = 28;
        searchResultsListBox.Location = new Point(323, 110);
        searchResultsListBox.Name = "searchResultsListBox";
        searchResultsListBox.Size = new Size(594, 172);
        searchResultsListBox.TabIndex = 18;
        // 
        // btnSearch
        // 
        btnSearch.BackColor = Color.SeaGreen;
        btnSearch.Location = new Point(573, 350);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(123, 37);
        btnSearch.TabIndex = 17;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = false;
        btnSearch.Click += btnSearch_Click;
        // 
        // chkAlphabeticalName
        // 
        chkAlphabeticalName.AutoSize = true;
        chkAlphabeticalName.Location = new Point(323, 72);
        chkAlphabeticalName.Name = "chkAlphabeticalName";
        chkAlphabeticalName.Size = new Size(368, 32);
        chkAlphabeticalName.TabIndex = 16;
        chkAlphabeticalName.Text = "search for items alphbetically A-Z";
        chkAlphabeticalName.UseVisualStyleBackColor = true;
        // 
        // chkPrice
        // 
        chkPrice.AutoSize = true;
        chkPrice.Location = new Point(323, 34);
        chkPrice.Name = "chkPrice";
        chkPrice.Size = new Size(236, 32);
        chkPrice.TabIndex = 15;
        chkPrice.Text = "search item by price ";
        chkPrice.UseVisualStyleBackColor = true;
        // 
        // btnRestock
        // 
        btnRestock.BackColor = Color.SeaGreen;
        btnRestock.Location = new Point(436, 350);
        btnRestock.Name = "btnRestock";
        btnRestock.Size = new Size(123, 37);
        btnRestock.TabIndex = 14;
        btnRestock.Text = "Restock";
        btnRestock.UseVisualStyleBackColor = false;
        btnRestock.Click += btnRestock_Click;
        // 
        // btnRemove
        // 
        btnRemove.BackColor = Color.SeaGreen;
        btnRemove.Location = new Point(145, 350);
        btnRemove.Name = "btnRemove";
        btnRemove.Size = new Size(123, 37);
        btnRemove.TabIndex = 13;
        btnRemove.Text = "Remove Item";
        btnRemove.UseVisualStyleBackColor = false;
        btnRemove.Click += btnRemove_Click;
        // 
        // btnDisplayItems
        // 
        btnDisplayItems.BackColor = Color.SeaGreen;
        btnDisplayItems.Location = new Point(284, 350);
        btnDisplayItems.Name = "btnDisplayItems";
        btnDisplayItems.Size = new Size(123, 37);
        btnDisplayItems.TabIndex = 12;
        btnDisplayItems.Text = "Display Items";
        btnDisplayItems.UseVisualStyleBackColor = false;
        btnDisplayItems.Click += btnDisplayItems_Click;
        // 
        // ExitFormButton
        // 
        ExitFormButton.BackColor = Color.IndianRed;
        ExitFormButton.Location = new Point(298, 404);
        ExitFormButton.Name = "ExitFormButton";
        ExitFormButton.Size = new Size(75, 42);
        ExitFormButton.TabIndex = 11;
        ExitFormButton.Text = "Exit";
        ExitFormButton.UseVisualStyleBackColor = false;
        // 
        // addToInventory
        // 
        addToInventory.BackColor = Color.SeaGreen;
        addToInventory.Location = new Point(0, 350);
        addToInventory.Name = "addToInventory";
        addToInventory.Size = new Size(123, 37);
        addToInventory.TabIndex = 10;
        addToInventory.Text = "Add Item to the inventory";
        addToInventory.UseVisualStyleBackColor = false;
        addToInventory.Click += addToInventory_Click;
        // 
        // ItemIdNumberLabel
        // 
        ItemIdNumberLabel.AutoSize = true;
        ItemIdNumberLabel.Location = new Point(0, 50);
        ItemIdNumberLabel.Name = "ItemIdNumberLabel";
        ItemIdNumberLabel.Size = new Size(101, 28);
        ItemIdNumberLabel.TabIndex = 9;
        ItemIdNumberLabel.Text = "Item ID#";
        // 
        // TypeLabel
        // 
        TypeLabel.AutoSize = true;
        TypeLabel.Location = new Point(6, 224);
        TypeLabel.Name = "TypeLabel";
        TypeLabel.Size = new Size(60, 28);
        TypeLabel.TabIndex = 8;
        TypeLabel.Text = "Type";
        // 
        // QuantityLabel
        // 
        QuantityLabel.AutoSize = true;
        QuantityLabel.Location = new Point(2, 180);
        QuantityLabel.Name = "QuantityLabel";
        QuantityLabel.Size = new Size(99, 28);
        QuantityLabel.TabIndex = 7;
        QuantityLabel.Text = "Quantity";
        // 
        // IdNumberTextBox
        // 
        IdNumberTextBox.BackColor = Color.Azure;
        IdNumberTextBox.Location = new Point(127, 50);
        IdNumberTextBox.Name = "IdNumberTextBox";
        IdNumberTextBox.Size = new Size(100, 35);
        IdNumberTextBox.TabIndex = 6;
        // 
        // TypeTextBox
        // 
        TypeTextBox.BackColor = Color.Azure;
        TypeTextBox.Location = new Point(127, 221);
        TypeTextBox.Name = "TypeTextBox";
        TypeTextBox.Size = new Size(100, 35);
        TypeTextBox.TabIndex = 5;
        // 
        // QuantityTextBox
        // 
        QuantityTextBox.BackColor = Color.Azure;
        QuantityTextBox.Location = new Point(127, 177);
        QuantityTextBox.Name = "QuantityTextBox";
        QuantityTextBox.Size = new Size(100, 35);
        QuantityTextBox.TabIndex = 4;
        // 
        // PriceTextBox
        // 
        PriceTextBox.BackColor = Color.Azure;
        PriceTextBox.Location = new Point(127, 134);
        PriceTextBox.Name = "PriceTextBox";
        PriceTextBox.Size = new Size(100, 35);
        PriceTextBox.TabIndex = 3;
        // 
        // priceLabel
        // 
        priceLabel.AutoSize = true;
        priceLabel.Location = new Point(6, 138);
        priceLabel.Name = "priceLabel";
        priceLabel.Size = new Size(62, 28);
        priceLabel.TabIndex = 2;
        priceLabel.Text = "price";
        // 
        // NameTag
        // 
        NameTag.AutoSize = true;
        NameTag.Location = new Point(6, 93);
        NameTag.Name = "NameTag";
        NameTag.Size = new Size(70, 28);
        NameTag.TabIndex = 1;
        NameTag.Text = "Name";
        // 
        // NameTextBox
        // 
        NameTextBox.BackColor = Color.Azure;
        NameTextBox.Location = new Point(127, 93);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.Size = new Size(100, 35);
        NameTextBox.TabIndex = 0;
        // 
        // InventoryApplication
        // 
        BackColor = Color.IndianRed;
        ClientSize = new Size(1227, 664);
        Controls.Add(informationGroup);
        Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        Name = "InventoryApplication";
        Text = "inventoryApplication";
        Load += InventoryApplication_Load;
        informationGroup.ResumeLayout(false);
        informationGroup.PerformLayout();
        ResumeLayout(false);
    }

    private void addToInventory_Click(object sender, EventArgs e)
    {
        try
        {
            double price = 0;
            int quantity = 0;

            if (!double.TryParse(PriceTextBox.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            if (!int.TryParse(QuantityTextBox.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            inventoryManager.AddItem(IdNumberTextBox.Text, NameTextBox.Text, price, quantity, TypeTextBox.Text);

            MessageBox.Show("Item added to inventory");

            // Clear text boxes after successful addition
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
    private void btnRemove_Click(object sender, EventArgs e)
    {
        string idToRemove = IdNumberTextBox.Text;  // Assuming you're using the IdNumberTextBox to get the ID of the item to remove.

        if (inventoryManager.RemoveItem(idToRemove))
        {
            MessageBox.Show("Item removed successfully");
        }
        else
        {
            MessageBox.Show("Item not found");
        }
        IdNumberTextBox.Clear(); // Clear the TextBox after removal operation.
                                 // You might also want to clear the other TextBoxes to avoid confusion.
        NameTextBox.Clear();
        PriceTextBox.Clear();
        QuantityTextBox.Clear();
        TypeTextBox.Clear();
    }


    private void btnDisplayItems_Click(object sender, EventArgs e)
    {
        var items = inventoryManager.GetAllItems();
        DisplayItems(items);
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        var items = inventoryManager.GetAllItems();

        // Assuming alphabeticalCheckbox and priceCheckbox are the names of your checkboxes
        if (chkAlphabeticalName.Checked)
        {
            items = items.OrderBy(item => item.Name).ToList();
        }
        else if (chkPrice.Checked)
        {
            items = items.OrderBy(item => item.Price).ToList();
        }

        DisplayItems(items);
    }

    private void DisplayItems(List<InventoryItem> items)
    {
        searchResultsListBox.Items.Clear();
        foreach (var item in items)
        {
            searchResultsListBox.Items.Add(FormatItemDisplay(item));
        }
    }

    private string FormatItemDisplay(InventoryItem item)
    {
        return $"{item.IdNumber} - {item.Name} | Price: ${item.Price} | Quantity: {item.Quantity} | Type: {item.Type}";
    }

    // Checkbox changed event handlers to ensure only one checkbox is checked at a time
    private void alphabeticalCheckbox_CheckedChanged(object sender, EventArgs e)
    {
        if (chkAlphabeticalName.Checked)
        {
            chkPrice.Checked = false;
        }
    }

    private void priceCheckbox_CheckedChanged(object sender, EventArgs e)
    {
        if (chkPrice.Checked)
        {
            chkAlphabeticalName.Checked = false;
        }
    }
    private void DisplayAllItems()
    {
        searchResultsListBox.Items.Clear(); // Clear the current items from the ListBox

        var items = inventoryManager.GetAllItems();
        foreach (var item in items)
        {
            searchResultsListBox.Items.Add(item.ToString());
        }
    }
    private void InventoryApplication_Load(object sender, EventArgs e)
    {
        DisplayAllItems();
    }

    private void btnRestock_Click(object sender, EventArgs e)
    {
        try
        {
            string idNumber = IdNumberTextBox.Text;
            int quantityToAdd = int.Parse(QuantityTextBox.Text);

            inventoryManager.RestockItem(idNumber, quantityToAdd);

            MessageBox.Show($"Successfully restocked {quantityToAdd} items!");

            DisplayAllItems();  // Refresh the displayed items after restocking.
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Restock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}










