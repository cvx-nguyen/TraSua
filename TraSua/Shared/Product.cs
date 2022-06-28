using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace TraSua.Shared
{
    public class Product
    {
        public Product(int id, string name, decimal price, Pearl Pearl)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Pearl = Pearl;
        }
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }

        public Pearl Pearl { get; }
        [JsonIgnore]
        public ICollection<Order> Orders { get; set; }
    }
}
