using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Domain.Interfaces.Repositories;
using ECommerceAPI.Infrastructure.Context;

namespace ECommerceAPI.Infrastructure.Repositories
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(ECommerceContext context) : base(context)
        {
        }
    }
}
