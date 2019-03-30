using ECommerceAPI.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceAPI.Infrastructure.Context
{
    public class InicializacaoBancoDeDados
    {
        public static void Inicializar(in ECommerceContext eCommerceContext)
        {
            InicializarCategoria(eCommerceContext);
            InicializarProdutos(eCommerceContext);
        }

        private static void InicializarProdutos(in ECommerceContext eCommerceContext)
        {
            if (eCommerceContext.Produtos.Any()) return;

            var produtos = new List<Produto>
            {
                new Produto("Mouse", 59.99),
                new Produto("Sabonete", 5.84),
                new Produto("Cimento", 22.90),
                new Produto("Computador", 1589.90),
                new Produto("Vitamina", 189.74),
            };

            eCommerceContext.Produtos.AddRange(produtos);

            eCommerceContext.SaveChanges();

            var categoriaInformatica = new Categoria();
            categoriaInformatica = eCommerceContext.Categorias.FirstOrDefault(x => x.Nome == "Informática");

            var produtoMouse = new Produto();
            produtoMouse = eCommerceContext.Produtos.First(x => x.Nome == "Mouse");

            var categoriaProdutos = new CategoriaProduto(categoriaInformatica.Id,  produtoMouse.Id);

            eCommerceContext.CategoriaProdutos.Add(categoriaProdutos);

            eCommerceContext.SaveChanges();
        }

        private static void InicializarCategoria(in ECommerceContext eCommerceContext)
        {
            if (eCommerceContext.Categorias.Any()) return;

            var categorias = new List<Categoria>
            {
                new Categoria("Informática"),
                new Categoria("Saúde"),
                new Categoria("Beleza"),
                new Categoria("Construção")
            };

            eCommerceContext.Categorias.AddRange(categorias);

            eCommerceContext.SaveChanges();
        }
    }
}
