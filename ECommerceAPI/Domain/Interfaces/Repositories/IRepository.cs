using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerceAPI.Domain.Interfaces.Repositories
{
    public interface IRepository<Entity> where Entity : class
    {
        Entity GetById(int id);
        IEnumerable<Entity> GetAll();
        void Add(Entity entity);
        void Update(Entity entity);
        void Delete(int id);
        void Delete(Entity entity);
        bool EntityExistsAny(int id);

        //ASYNCHRONOUS
        Task<Entity> GetByIdAsync(int id);
        Task<IEnumerable<Entity>> GetAllAsync();
        Task AddAsync(Entity entity);
        Task UpdateAsync(Entity entity);
        Task DeleteAsync(int id);
        Task DeleteAsync(Entity entity);
    }
}
