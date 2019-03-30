using ECommerceAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceAPI.Infrastructure.Mappings
{
    class CategoriaProdutoEntityConfiguration : IEntityTypeConfiguration<CategoriaProduto>
    {
        public void Configure(EntityTypeBuilder<CategoriaProduto> builder)
        {
            builder
                .ToTable("CategoriaProduto");

            builder
                .HasKey(x => new { x.IdCategoria, x.IdProduto });

            builder
                .HasOne(c => c.Categoria)
                .WithMany(p => p.CategoriaProdutos)
                .HasForeignKey(c => c.IdCategoria);

            builder
                .HasOne(p => p.Produto)
                .WithMany(c => c.CategoriaProdutos)
                .HasForeignKey(p => p.IdProduto);
        }
    }
}
