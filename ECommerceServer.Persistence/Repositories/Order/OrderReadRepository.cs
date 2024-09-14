using ECommerceServer.Application.Repository;
using ECommerceServer.Domain.Entities;
using ECommerceServer.Persistence.Contexts;

namespace ECommerceServer.Persistence.Repositories;

public class OrderReadRepository:ReadRepository<Order>,IOrderReadRepository
{
    public OrderReadRepository(ECommerceApiDbContext context) : base(context)
    {
    }
}