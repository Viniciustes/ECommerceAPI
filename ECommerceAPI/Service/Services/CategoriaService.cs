using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Service.Interfaces;
using ECommerceAPI.Domain.Interfaces.Repositories;

namespace ECommerceAPI.Service.Services
{
    public class CategoriaService : Service<Categoria>, ICategoriaService
    {
        public CategoriaService(ICategoriaRepository repository) : base(repository)
        {
        }
    }
}
