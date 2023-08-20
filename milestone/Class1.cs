using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone
{
    public class InventoryManager
    {
        private List<InventoryItem> inventory = new List<InventoryItem>();

        public InventoryItem AddItem(string idNumber, string name, string price, string quantity, string type)
        {
            if
                (string.IsNullOrEmpty(idNumber) || string.IsNullOrEmpty(name) ||
                 string.IsNullOrEmpty(price) || string.IsNullOrEmpty(quantity) ||
                 string.IsNullOrEmpty(type))
            {
                throw new Exception("Please fill out all the information");
            }
            if (!int.TryParse(price, out int priceParsed))
            {
                throw new Exception("Please enter a valid price");
            }
            if (!int.TryParse(quantity, out int quantityParsed))
            {
                throw new Exception("Please enter a valid quantity");
            }
            InventoryItem newItem = new InventoryItem(idNumber, name, priceParsed, quantityParsed, type);
            inventory.Add(newItem);
            return newItem;
        }

        public class InventoryItem
        {
            public int IdNumber { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
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