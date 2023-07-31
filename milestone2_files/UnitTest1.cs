using Xunit;
using buttonClicker; // if your InventoryManager is in the 'buttonClicker' namespace

public class InventoryManagerTests
{
    [Fact]
    public void TestAddItem()
    {
        // Arrange
        var inventoryManager = new InventoryManager();
        string idNumber = "1";
        string name = "Item1";
        string price = "10";
        string quantity = "5";
        string type = "Type1";

        // Act
        var newItem = inventoryManager.AddItem(idNumber, name, price, quantity, type);

        // Assert
        
        Assert.Equal(int.Parse(idNumber), newItem.IdNumber);
        Assert.Equal(name, newItem.Name);
        Assert.Equal(double.Parse(price), newItem.Price);
        Assert.Equal(int.Parse(quantity), newItem.Quantity);
        Assert.Equal(type, newItem.Type);
    }
}