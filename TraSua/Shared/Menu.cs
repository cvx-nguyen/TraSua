using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSua.Shared
{
    public class Menu
    {
        public List<Product> products { get; set; }
        = new List<Product>();
        public void Add(Product pizza)
            => products.Add(pizza);
        public Product? GetProduct(int id)
            => products.SingleOrDefault(pizza => pizza.Id == id);
    }
}
