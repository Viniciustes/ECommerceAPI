namespace ECommerceAPI.Domain.Entities
{
    public class CategoriaProduto
    {
        public int IdCategoria { get; private set; }

        public Categoria Categoria { get; private set; }

        public int IdProduto { get; private set; }

        public Produto Produto { get; private set; }

        public CategoriaProduto()
        {
        }

        public CategoriaProduto(int idCategoria, int idProduto)
        {
            IdCategoria = idCategoria;
            IdProduto = idProduto;
        }
    }
}
