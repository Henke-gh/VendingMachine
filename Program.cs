using System.Data;
using VendningMachine;

Stock vendingMachine = new Stock("Apocalypse");

Item noHope = new Item("Lack of Hope", 16, 34);
Item bread = new Item("Stale Bread", 21, 50);
Item water = new Item("Polluted Water", 7, 42);

vendingMachine.AddToStock(noHope);
vendingMachine.AddToStock(bread);
vendingMachine.AddToStock(water);

Console.WriteLine("Ahhh, a new face! What's your name?");
string? customerName = Console.ReadLine();

if (customerName == null)
{
    customerName = "Stranger";
}

Customer newCustomer = new Customer(customerName, 360);

Console.WriteLine("");
Console.WriteLine($"Right, well.. welcome to my store {newCustomer.Name}");
Thread.Sleep(800);

Storefront.GetStorefront();
Thread.Sleep(500);
Storefront.GetStock(vendingMachine);
Storefront.ShopControls(vendingMachine, newCustomer);