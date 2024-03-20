namespace VendningMachine
{
    public class Customer
    {
        public string? Name { get; set; }
        public int? Wallet { get; set; }
        public List<Item> BoughtItems { get; } = new List<Item>();

        public Customer(string name, int wallet)
        {
            Name = name;
            Wallet = wallet;
        }

        public void AddItem(Item item)
        {
            BoughtItems.Add(item);
            Wallet -= item.Cost;
        }

    }
}