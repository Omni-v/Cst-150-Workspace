using System.Collections.Generic;

namespace buttonClicker
{
    public class InventoryManager
    {
        private List<InventoryItem> Inventory { get; set; }

        public InventoryManager()
        {
            this.Inventory = new List<InventoryItem>();
        }

        public InventoryItem AddItem(string idNumber, string name, string price, string quantity, string type)
        {
            var newItem = new InventoryItem(idNumber, name, int.Parse(price), int.Parse(quantity), type);
            this.Inventory.Add(newItem);
            return newItem;
        }

        // Add other inventory management methods as needed, like remove item, update item, etc.

        public class InventoryItem
        {
            public int IdNumber { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public int Quantity { get; set; }
            public string Type { get; set; }

            public InventoryItem(string idNumber, string name, int price, int quantity, string type)
            {
                IdNumber = int.Parse(idNumber);
                Name = name;
                Price = price;
                Quantity = quantity;
                Type = type;
            }
        }
    }
}

