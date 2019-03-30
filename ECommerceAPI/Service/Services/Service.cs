using ECommerceAPI.Domain.Interfaces.Repositories;
using ECommerceAPI.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerceAPI.Service.Services
{
    public class Service<Entity> : IService<Entity> where Entity : class
    {
        private readonly IRepository<Entity> repository;

        public Service(IRepository<Entity> repository)
        {
            this.repository = repository;
        }

        public void Add(Entity entity) => repository.Add(entity);

        public async Task AddAsync(Entity entity) => await repository.AddAsync(entity);

        public void Delete(int id) => repository.Delete(id);

        public void Delete(Entity entity) => repository.Delete(entity);

        public async Task DeleteAsync(int id) => await repository.DeleteAsync(id);

        public async Task DeleteAsync(Entity entity) => await repository.DeleteAsync(entity);

        public bool EntityExistsAny(int id) => repository.EntityExistsAny(id);

        public IEnumerable<Entity> GetAll() => repository.GetAll();

        public async Task<IEnumerable<Entity>> GetAllAsync() => await repository.GetAllAsync();

        public Entity GetById(int id) => repository.GetById(id);

        public async Task<Entity> GetByIdAsync(int id) => await repository.GetByIdAsync(id);

        public void Update(Entity entity) => repository.Update(entity);

        public async Task UpdateAsync(Entity entity) => await repository.UpdateAsync(entity);
    }
}
