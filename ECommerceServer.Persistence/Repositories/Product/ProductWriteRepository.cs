using ECommerceServer.Application.Repository;
using ECommerceServer.Domain.Entities;
using ECommerceServer.Persistence.Contexts;

namespace ECommerceServer.Persistence.Repositories;

public class ProductWriteRepository:WriteRepository<Product>,IProductWriteRepository
{
    public ProductWriteRepository(ECommerceApiDbContext context) : base(context)
    {
    }
}