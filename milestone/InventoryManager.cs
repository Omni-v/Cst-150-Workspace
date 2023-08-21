using System;
using System.Collections.Generic;
using System.Linq;

namespace buttonClicker; 

public class InventoryManager
{
    private List<InventoryItem> items;

    public InventoryManager()
    {
        items = new List<InventoryItem>();
    }

    public void AddItem(string idNumber, string name, double price, int quantity, string type)
    {
        var existingItem = items.FirstOrDefault(i => i.IdNumber == idNumber);
        if (existingItem != null)
        {
            throw new InvalidOperationException($"Item with ID {idNumber} already exists.");
        }

        var newItem = new InventoryItem
        {
            IdNumber = idNumber,
            Name = name,
            Price = price,
            Quantity = quantity,
            Type = type
        };
        items.Add(newItem);
    }

    public bool RemoveItem(string id)
    {
        var itemToRemove = items.FirstOrDefault(item => item.IdNumber == id);
        if (itemToRemove != null)
        {
            items.Remove(itemToRemove);
            return true; // indicates successful removal
        }
        return false; // indicates item not found, so not removed
    }
    public List<InventoryItem> SearchByName()
    {
        return items.OrderBy(item => item.Name).ToList();
    }

    public List<InventoryItem> SearchByPrice()
    {
        return items.OrderBy(item => item.Price).ToList();
    }

    public List<InventoryItem> GetAllItems()
    {
        return items;
    }

    public InventoryItem GetItemById(string id)
    {
        return items.FirstOrDefault(i => i.IdNumber == id);
    }
    public void RestockItem(string id, int quantity)
    {
        var itemToRestock = items.FirstOrDefault(item => item.IdNumber == id);
        if (itemToRestock != null)
        {
            itemToRestock.Quantity += quantity;
        }
        else
        {
            throw new InvalidOperationException($"No item with ID {id} found to restock.");
        }
    }
}

public class InventoryItem
{
    public string IdNumber { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Type { get; set; }
}