using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Domain.Interfaces.Repositories;
using ECommerceAPI.Service.Interfaces;

namespace ECommerceAPI.Service.Services
{
    public class ProdutoService : Service<Produto>, IProdutoService
    {
        public ProdutoService(IProdutoRepository repository) : base(repository)
        {
        }
    }
}
