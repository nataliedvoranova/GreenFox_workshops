using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webshopapp.Models
{
    public class Product
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Price { get; private set; }
        public int Available { get; private set; }

        public Product (string name, string decription, int price, int available)
        {
            Name = name;
            Description = decription;
            Price = price;
            Available = available;
        }
        public List<Product> ShowAvailable(List<Product> allProducts)
        {
            List<Product> availableProducts = new List<Product>();
            if (Available<1)
            {
                foreach (var item in allProducts)
                {
                    availableProducts.Add(item);
                }
            }
            return availableProducts;
        }
    }
}
