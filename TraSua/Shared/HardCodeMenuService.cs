using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSua.Shared
{
    public class HardCodeMenuService : IMenuService
    {
        public ValueTask<Menu> GetMenu() => new ValueTask<Menu>(
            new Menu
            {
                Products = new List<Product>
                {
                   new Product(1, "\nNhiều trân châu", 12.00M, Pearl.nhieu),
                   new Product(2, "\nÍt trân châu", 10.00M, Pearl.it),
                   new Product(3, "\nKhông trân châu", 9.99M, Pearl.None)
                }
            });
    }
}
