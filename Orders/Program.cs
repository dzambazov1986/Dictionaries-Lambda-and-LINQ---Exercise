var products = new Dictionary<string, Product>();

        string input;
        while ((input = Console.ReadLine()) != "buy")
        {
            string[] productData = input.Split(' ');
            string name = productData[0];
            decimal price = decimal.Parse(productData[1]);
            int quantity = int.Parse(productData[2]);

            if (!products.ContainsKey(name))
            {
                products[name] = new Product { Price = price, Quantity = quantity };
            }
            else
            {
                products[name].Quantity += quantity;
                if (products[name].Price != price)
                {
                    products[name].Price = price;
                }
            }
        }

        foreach (var product in products)
        {
            Console.WriteLine($"{product.Key} -> {product.Value.TotalPrice:F2}");
        }
    

class Product
{
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice
    {
        get { return Price * Quantity; }
    }
}