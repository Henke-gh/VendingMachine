namespace VendningMachine

{
    public class Storefront
    {
        public static void GetStorefront()
        {
            string header = "End of the World Artifacts";
            int spacing = 52 - header.Length;

            for (int i = 0; i < 2; i++)
            {


                for (int j = 0; j < 54; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("");
            }

            Console.Write("|");
            for (int i = 0; i < spacing / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write(header);
            for (int i = 0; i < spacing / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");

            Console.WriteLine("");
            for (int j = 0; j < (spacing * 2 + 2); j++)
            {
                Console.Write("-");
            }
            Console.WriteLine("");

        }

        public static void GetStock(Stock stock)
        {
            Console.WriteLine("-- Items in stock --");
            Console.WriteLine("");

            foreach (var item in stock.InStock)
            {
                string? name = item.Name;
                int? cost = item.Cost;
                int? quantity = item.Quantity;
                string? description = item.Description;

                Console.WriteLine($"[{name}] - Cost: {cost} screws. - In Stock: {quantity} pcs.");
                Thread.Sleep(300);
            }
        }

        public static void ShopControls(Stock stock, Customer customer)
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine($"Your funds: {customer.Wallet}");
                Console.WriteLine("");
                Console.WriteLine("What do you wish to buy?");
                Console.Write("Enter item name: ");
                string? itemToBuy = Console.ReadLine();
                Console.WriteLine("");

                bool itemFound = false;

                if (itemToBuy == "Leave")
                {
                    Console.WriteLine("Thank you for your business. I'll see you around.");
                    break;
                }

                foreach (var item in stock.InStock)
                {
                    string? itemName = item.Name;
                    if (itemName == itemToBuy)
                    {
                        itemFound = true;
                        if (item.Cost > customer.Wallet)
                        {
                            Console.WriteLine("You seem to lack sufficent funds.., maybe I can interest you in leaving?");
                            break;
                        }
                        if (item.Cost <= customer.Wallet)
                        {
                            Console.WriteLine("A splendid choice!");
                            Console.WriteLine($"{itemToBuy} has been added to your inventory.");
                            customer.AddItem(item);
                            item.Quantity -= 1;
                            break;
                        }
                    }
                }
                if (!itemFound)
                {
                    if (itemToBuy == "" || itemToBuy == null)
                    {
                        Console.WriteLine("Speak up, I can't hear you!");
                    }
                    else
                    {
                        Console.WriteLine($"We don't seem to keep {itemToBuy} in stock..");
                    }
                }

            }
        }
    }
}
