using Microsoft.EntityFrameworkCore;

namespace ECommerceServer.Application.Repository;

public interface IRepository<T> where T:BaseEntity
{
   DbSet<T> Table { get; }
}