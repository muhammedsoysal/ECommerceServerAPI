using ECommerceServer.Application.Repository;
using ECommerceServer.Domain.Entities;
using ECommerceServer.Persistence.Contexts;

namespace ECommerceServer.Persistence.Repositories;

public class ProductReadRepository:ReadRepository<Product>,IProductReadRepository
{
    public ProductReadRepository(ECommerceApiDbContext context) : base(context)
    {
    }
}