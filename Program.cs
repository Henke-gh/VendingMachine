using System.Data;
using VendningMachine;

Stock vendingMachine = new Stock("Apocalypse");

Item noHope = new Item("Lack of Hope", 16, 34);
Item bread = new Item("Stale Bread", 21, 50);
Item water = new Item("Polluted Water", 7, 42);

vendingMachine.AddToStock(noHope);
vendingMachine.AddToStock(bread);
vendingMachine.AddToStock(water);

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("");
Console.WriteLine("Ahhh, a new face! What's your name?");
string? customerName = Console.ReadLine();

if (customerName == null || customerName == "")
{
    customerName = "Stranger";
}

Customer newCustomer = new Customer(customerName, 360);

Console.WriteLine($"Have a look around {newCustomer.Name}!");
while (true)
{
    Console.WriteLine("Commands: 'Shop', 'Inventory', 'Exit'");
    Console.Write("Enter command: ");
    string? command = Console.ReadLine();

    if (command == "Shop")
    {
        Console.WriteLine("");
        Console.WriteLine($"Welcome to my store, {newCustomer.Name}");
        Thread.Sleep(800);

        Storefront.GetStorefront();
        Thread.Sleep(500);
        Storefront.GetStock(vendingMachine);
        Storefront.ShopControls(vendingMachine, newCustomer);
    }

    if (command == "Inventory")
    {
        Console.WriteLine("");
        Inventory.GetCustomerInfo(newCustomer);
        continue;
    }

    if (command == "Exit")
    {
        Thread.Sleep(300);
        Console.WriteLine("Bye.");
        Console.WriteLine("");
        break;
    }
}

Console.ResetColor();