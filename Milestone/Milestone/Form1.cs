using System.Drawing.Text;

namespace buttonClicker
{
    public partial class InventoryApplication : Form
    {
        public InventoryApplication()
        {
            InitializeComponent();
        }
        //create an array to hold 5 drink items and their prices
        string[] drinkItems = new string[5] { "Coke", "Sprite", "Fanta", "Dr. Pepper", "Pepsi" };
        double[] drinkPrices = new double[5] { 1.50, 1.50, 1.50, 1.50, 1.50 };
        //create a variable to hold the current stock of the item
        int currentStock = 10;

        private void CurrentStock_Click(object sender, EventArgs e)
        {
            //create a variable that will show the current inventory of each item.
            string itemsInStock = "";
            //create a for loop that will loop through the array and display the current stock of each item.
            for (int i = 0; i < drinkItems.Length; i++)
            {
                itemsInStock += drinkItems[i] + " " + currentStock + "\n";
            }
            //display the current stock of each item in the label.
            itemsInStockDisplay.Text = itemsInStock;


        }

        private void resetApplication_Click(object sender, EventArgs e)
        {
            //if the inventory is less than 10, then reset the inventory to 10.
            if (currentStock < 10)
            {
                currentStock = 10;
                itemsInStockDisplay.Text = drinkItems[0] + " " + currentStock + "\n" + drinkItems[1] + " " + currentStock + "\n" + drinkItems[2] + " " + currentStock + "\n" + drinkItems[3] + " " + currentStock + "\n" + drinkItems[4] + " " + currentStock + "\n";
            }
            //if the inventory is more than 10, then display the current stock of each item.
            else
            {
                itemsInStockDisplay.Text = drinkItems[0] + " " + currentStock + "\n" + drinkItems[1] + " " + currentStock + "\n" + drinkItems[2] + " " + currentStock + "\n" + drinkItems[3] + " " + currentStock + "\n" + drinkItems[4] + " " + currentStock + "\n";
            }



        }

        private void clearStock_Click(object sender, EventArgs e)
        {
            //if the inventory is more than 0, then clear the inventory.
            if (currentStock > 0)
            {
                currentStock = 0;
                itemsInStockDisplay.Text = drinkItems[0] + " " + currentStock + "\n" + drinkItems[1] + " " + currentStock + "\n" + drinkItems[2] + " " + currentStock + "\n" + drinkItems[3] + " " + currentStock + "\n" + drinkItems[4] + " " + currentStock + "\n";
            }


        }

        private void addOneToInventory_Click(object sender, EventArgs e)
        {
            //if the inventory is less than 10, then add one to the inventory.
            if (currentStock < 10)
            {
                currentStock++;
                itemsInStockDisplay.Text = drinkItems[0] + " " + currentStock + "\n" + drinkItems[1] + " " + currentStock + "\n" + drinkItems[2] + " " + currentStock + "\n" + drinkItems[3] + " " + currentStock + "\n" + drinkItems[4] + " " + currentStock + "\n";
            }
        }

        private void sellItems_Click(object sender, EventArgs e)
        {
            //if the inventory is more than 4, then sell one of each item.
            if (currentStock > 4)
            {
                currentStock -= 5;
                itemsInStockDisplay.Text = drinkItems[0] + " " + currentStock + "\n" + drinkItems[1] + " " + currentStock + "\n" + drinkItems[2] + " " + currentStock + "\n" + drinkItems[3] + " " + currentStock + "\n" + drinkItems[4] + " " + currentStock + "\n";


            }
        }


    }
}





