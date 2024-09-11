namespace AppVendas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public double Valor { get; set; }
        public double QtdadeEstoque { get; set; }
        public bool CadastroAtivo { get; set; }

        public Guid CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }

    }
}
