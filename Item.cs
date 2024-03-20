namespace VendningMachine
{
    public class Item
    {
        public string? Name { get; }
        public int Quantity { get; set; }
        public int Cost { get; }
        public string? Description { get; set; }

        public Item(string name, int quantity, int cost)
        {
            Name = name;
            Quantity = quantity;
            Cost = cost;
        }

        //Currently not in use
        public void AddDescription(string description)
        {
            Description = description;
        }

        //Not currently in use
        public string BuyItem(int wallet)
        {
            if (wallet < Cost)
            {
                return "You can't afford that.";
            }

            Quantity -= 1;
            return $"You bought {Name}.";
        }
    }
}