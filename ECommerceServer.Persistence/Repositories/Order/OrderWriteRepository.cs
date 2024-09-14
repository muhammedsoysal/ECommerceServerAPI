using ECommerceServer.Application.Repository;
using ECommerceServer.Domain.Entities;
using ECommerceServer.Persistence.Contexts;

namespace ECommerceServer.Persistence.Repositories;

public class OrderWriteRepository:WriteRepository<Order>,IOrderWriteRepository
{
    public OrderWriteRepository(ECommerceApiDbContext context) : base(context)
    {
    }
}