using ECommerceServer.Application.Repository;
using ECommerceServer.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ECommerceServer.Persistence.Repositories;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
{
    private readonly ECommerceApiDbContext _context;

    public WriteRepository(ECommerceApiDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public async Task<bool> AddAsync(T model)
    {
        EntityEntry<T> entityEntry = await Table.AddAsync(model);
        return entityEntry.State == EntityState.Added;
    }

    public async Task<bool> AddRangeAsync(List<T> models)
    {
        await Table.AddRangeAsync(models);
        return true;
    }

    public bool Remove(T model)
    {
        EntityEntry<T> entityEntry = Table.Remove(model);
        return entityEntry.State == EntityState.Deleted;
    }

    public async Task<bool> RemoveAsync(string id)
    {
        T model = await Table.FirstOrDefaultAsync(t => t.Id == Guid.Parse(id));
        return Remove(model);
    }

    public bool RemoveRange(List<T> models)
    {
        Table.RemoveRange(models);
        return true;
    }

    public bool Update(T model)
    {
        EntityEntry entityEntry = Table.Update(model);
        return entityEntry.State == EntityState.Modified;
    }

    public async Task<int> SaveAsync() => await _context.SaveChangesAsync();
}