using System.Reflection;
using ECommerceServer.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ECommerceServer.Persistence;

public class DesingTimeDbContextFactory:IDesignTimeDbContextFactory<ECommerceApiDbContext>
{
    public ECommerceApiDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<ECommerceApiDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionStrings);
        return new (dbContextOptionsBuilder.Options);
    }
}