using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo é Obrigatório")]
        [MaxLength(100, ErrorMessage = "O Campo deve ter, no máximo 100 caracteres!")]
        [MinLength(3, ErrorMessage = "")]

        public string ProdutoNome { get; set; }
        [Required(ErrorMessage = "O Campo é Obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "O valor do Produto deve ser um número positivo")]

        public double Valor { get; set; }
        [Required(ErrorMessage = "O Campo é Obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "O valor do Produto deve ser um número positivo")]
        [Display(Name ="Estoque Atual")]

        public double QtdadeEstoque { get; set; }
        [Display(Name ="Ativo?")]
        public bool CadastroAtivo { get; set; }

        /*Chave Estrangeira*/
        [Required(ErrorMessage = "Por favor selecione uma categoria!")]
        public Guid CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }

    }
}
