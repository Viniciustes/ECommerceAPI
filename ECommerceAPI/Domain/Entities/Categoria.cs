using System.Collections.Generic;

namespace ECommerceAPI.Domain.Entities
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public IList<CategoriaProduto> CategoriaProdutos { get; set; }

        public Categoria()
        {
        }

        public Categoria(string nome)
        {
            Nome = nome;
        }
    }
}
