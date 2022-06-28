using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSua.Shared
{
    public class Menu
    {
        public List<Product> Products { get; set; }
        = new List<Product>();
        public void Add(Product product)
            => Products.Add(product);
        public Product? GetProduct(int id)
            => Products.SingleOrDefault(product => product.Id == id);
    }
}
