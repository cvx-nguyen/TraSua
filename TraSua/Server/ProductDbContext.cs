using Microsoft.EntityFrameworkCore;
using TraSua.Shared; 

namespace TraSua.Server
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }
        public DbSet<Product> Pizzas { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var pizzaEntity = modelBuilder.Entity<Product>();
            pizzaEntity.HasKey(pizza => pizza.Id);
            pizzaEntity.Property(pizza => pizza.Name).HasMaxLength(88);
            pizzaEntity.Property(pizza => pizza.Price).HasColumnType("money");
            pizzaEntity.Property(pizza => pizza.Pearl).HasConversion<string>();

            var ordersEntity = modelBuilder.Entity<Order>();
            ordersEntity.HasKey(order => order.Id);
            ordersEntity.HasOne(order => order.Customer);
            ordersEntity.HasMany(order => order.Products).WithMany(product => product.Orders);

            var customerEntity = modelBuilder.Entity<Customer>();
            customerEntity.HasKey(customer => customer.Id);
            customerEntity.Property(customer => customer.Name).HasMaxLength(100);
            customerEntity.Property(customer => customer.Street).HasMaxLength(50);
            customerEntity.Property(customer => customer.City).HasMaxLength(50);

        }
    }
}
