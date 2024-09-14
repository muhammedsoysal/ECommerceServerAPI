using ECommerceServer.Application.Repository;
using ECommerceServer.Domain.Entities;
using ECommerceServer.Persistence.Contexts;

namespace ECommerceServer.Persistence.Repositories;

public class CustomerWriteRepository: WriteRepository<Customer>,ICustomerWriteRepository
{
    public CustomerWriteRepository(ECommerceApiDbContext context) : base(context)
    {
    }
}