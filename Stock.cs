namespace VendningMachine
{
    public class Stock
    {
        public string? Name { get; }
        public List<Item> InStock { get; } = new List<Item>();

        public Stock(string name)
        {
            Name = name;
        }

        public void AddToStock(Item item)
        {
            InStock.Add(item);
        }

        public void RemoveFromStock(Item item)
        {
            if (item.Quantity <= 0)
            {
                InStock.Remove(item);
            }
        }
    }
}