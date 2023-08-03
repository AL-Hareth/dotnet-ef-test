using CrashCourse.Models;
using Microsoft.EntityFrameworkCore;

namespace CrashCourse.Data;

public class StoreContext : DbContext {

    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<OrderDetails> OrderDetails { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlServer(@"Server=localhost; TrustServerCertificate=True; Database=StoreDB; User Id=sa; Password=Alhareth_2004");
    }

}


