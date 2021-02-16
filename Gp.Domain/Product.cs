using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gp.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public DateTime DataProd { get; set; }
        public Category Category { get; set; }
        public List<Provider> Providers { get; set; }
        public Product()
        {

        }

        public Product(string name, int quantity, float price, string description, DateTime dataProd)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Description = description;
            DataProd = dataProd;
        }
    }
}
