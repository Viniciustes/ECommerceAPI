using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Domain.Interfaces.Repositories;
using ECommerceAPI.Infrastructure.Context;

namespace ECommerceAPI.Infrastructure.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ECommerceContext context) : base(context)
        {
        }
    }
}
