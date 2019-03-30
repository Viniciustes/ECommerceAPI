using ECommerceAPI.Domain.Interfaces.Repositories;
using ECommerceAPI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerceAPI.Infrastructure.Repositories
{
    public class Repository<Entity> : IRepository<Entity> where Entity : class
    {
        private readonly ECommerceContext context;

        public Repository(ECommerceContext context)
        {
            this.context = context;
        }

        public IEnumerable<Entity> GetAll() => context.Set<Entity>();

        public async Task<IEnumerable<Entity>> GetAllAsync() => await context.Set<Entity>().ToListAsync();

        public Entity GetById(int id) => context.Set<Entity>().Find(id);

        public async Task<Entity> GetByIdAsync(int id) => await context.Set<Entity>().FindAsync(id);

        public void Add(Entity entity)
        {
            context.Set<Entity>().Add(entity);
            context.SaveChanges();
        }

        public async Task AddAsync(Entity entity)
        {
            await context.Set<Entity>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public void AddRange(IEnumerable<Entity> entities)
        {
            context.Set<Entity>().AddRange(entities);
            context.SaveChanges();
        }

        public async Task AddRangeAsync(IEnumerable<Entity> entities)
        {
            await context.Set<Entity>().AddRangeAsync(entities);
            await context.SaveChangesAsync();
        }

        public void Update(Entity entity)
        {
            context.Set<Entity>().Update(entity);
            context.SaveChanges();
        }

        public async Task UpdateAsync(Entity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public void Delete(Entity entity)
        {
            context.Set<Entity>().Remove(entity);
            context.SaveChanges();
        }

        public async Task DeleteAsync(Entity entity)
        {
            context.Set<Entity>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            context.Set<Entity>().Remove(GetById(id));
            context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            context.Set<Entity>().Remove(GetById(id));
            await context.SaveChangesAsync();
        }

        public bool EntityExistsAny(int id) => GetById(id) != null;
    }
}
