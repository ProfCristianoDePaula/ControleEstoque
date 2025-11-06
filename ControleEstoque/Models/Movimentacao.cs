using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.Models
{
    public class Movimentacao
    {
        public int MovimentacaoId { get; set; }

        // Relacionamento com Produto ( Chave Estrangeira )
        [Required]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Required]
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Required]
        [Display(Name = "Tipo de Movimentação")]
        public string? Tipo { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data da Movimentação")]
        public DateTime? DataMovimentacao { get; set; }

        //Relacionamento com a tabela de Usuarios (IdentityUser)
        [Display(Name = "Usuário")]
        public string? UsuarioId { get; set; } // O IdentityUser utiliza o campo Id como String por padrão
        public IdentityUser? Usuario { get; set; } // Referencia para a classe padrão do Identity

        [Display(Name = "Observação")]
        [DataType(DataType.MultilineText)]
        public string? Observacao { get; set; }
    }
}
