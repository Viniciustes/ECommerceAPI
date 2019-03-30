using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Infrastructure.Context
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<CategoriaProduto> CategoriaProdutos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaProdutoEntityConfiguration());
        }
    }
}
