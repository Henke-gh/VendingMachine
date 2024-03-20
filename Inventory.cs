namespace VendningMachine

{
    public class Inventory
    {
        public static void GetCustomerInfo(Customer customer)
        {
            Console.WriteLine($"Name: {customer.Name}");
            Console.WriteLine($"Wallet: {customer.Wallet} screws");
            Console.WriteLine("");
            Console.WriteLine("--[Your inventory]--");
            if (customer.BoughtItems.Count < 1)
            {
                Console.WriteLine("You don't seem to carry anything with you.");
            }
            else
            {
                foreach (var item in customer.BoughtItems)
                {
                    Console.WriteLine($"{item.Name}");
                }
            }

            Console.WriteLine("");
        }
    }
}