using ECommerceServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceServer.Persistence.Contexts;

public class ECommerceApiDbContext:DbContext
{
    public ECommerceApiDbContext(DbContextOptions options):base(options)
    { }
    public DbSet<Product>  Products { get; set; }
    public DbSet<Order>  Orders { get; set; }
    public DbSet<Customer>  Customers { get; set; }
}