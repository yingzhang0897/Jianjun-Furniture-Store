using Microsoft.AspNetCore.Identity.EntityFrameworkCore; // For IdentityDbContext
using Microsoft.EntityFrameworkCore; // For DbContext


public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}

