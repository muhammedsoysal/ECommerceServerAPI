using ECommerceServer.Application.Repository;
using ECommerceServer.Domain.Entities;
using ECommerceServer.Persistence.Contexts;

namespace ECommerceServer.Persistence.Repositories;

public class CustomerReadRepository: ReadRepository<Customer>, ICustomerReadRepository
{
    public CustomerReadRepository(ECommerceApiDbContext context) : base(context)
    {
    }
}