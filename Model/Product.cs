
namespace SoaProductApp.Model
{
    internal class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string? name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public Product()
        {
        }

        public override string? ToString()
        {
            return $"Name: {Name}, price: {Price}, quantity: {Quantity}";
        }
    }
}
