using Microsoft.EntityFrameworkCore;
using ShoppingApplication.Models;

namespace ShoppingApplication.DAL;

public class ShoppingAppDbContext : DbContext
{
    public ShoppingAppDbContext(DbContextOptions options) : base(options)
    {
    }

    public ShoppingAppDbContext()
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Shipper> Shippers { get; set; }




    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=netDemo;User Id=root;Password=Ishwar@2003");
            }

        



    }
}
