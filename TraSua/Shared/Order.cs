using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSua.Shared
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; } = default!;
        public ICollection<Product> Products { get; set; } =default!;
    }
}
