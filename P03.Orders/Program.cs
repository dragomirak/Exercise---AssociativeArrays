using System.Diagnostics;
using System.Xml.Linq;

namespace P03.Orders
{
    class Product
    {
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public void Update(double price, int quantity)
        {
            Price = price;
            Quantity += quantity;
        }

        public double GetTotalPrice()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"{Name} -> {GetTotalPrice():f2}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> productsMap = new Dictionary<string, Product>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] productInfo = input.Split(" ");
                string productName = productInfo[0];
                double productPrice = double.Parse(productInfo[1]);
                int productQuantity = int.Parse(productInfo[2]);

                Product product = new Product(productName, productPrice, productQuantity);

                if (!productsMap.ContainsKey(productName))
                {
                    productsMap.Add(product.Name, product);
                }
                else
                {
                    productsMap[productName].Update(product.Price, product.Quantity);
                }
            }

            foreach (KeyValuePair<string, Product> kvp in productsMap)
            {
                Console.WriteLine(kvp.Value);
            }
        }
    }
}