using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O Nome do produto é obrigatório.")] // O campo Nome é Obrigatório
        [StringLength(100, ErrorMessage = "O nome do produto não pode ter mais de 100 caracteres.")] // tamanho maximo do campo
        [Display(Name = "Nome do Produto")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "A marca do produto é obrigatória.")] // O campo Nome é Obrigatório
        [StringLength(100, ErrorMessage = "A marca do produto não pode ter mais de 100 caracteres.")] // tamanho maximo do campo
        [Display(Name = "Marca")]
        public string? Marca { get; set; } // Declaração do atributo

        // Relacionamento com Categoria (Chave Estrangeira)
        [Required(ErrorMessage = "A categoria é obrigatória")]
        [Display(Name = "Nome da Categoria")]
        public int CategoriaId { get; set; } // Id da tabela estrangeira
        public Categoria? Categoria { get; set; } // Classe que pertence o Id estrangeiro


        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "O Estoque Atual não pode ser negativo.")] // Range -> Determina uma faixa de valores permitidos no campo,
        [Display(Name = "Estoque Atual")]
        public int EstoqueAtual { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "O Estoque Mínimo não pode ser negativo.")] // Range -> Determina uma faixa de valores permitidos no campo,
        [Display(Name = "Estoque Mínimo")]
        public int EstoqueMinimo { get; set; }


        [Required]
        [DataType(DataType.Date, ErrorMessage = "Informe uma data válida.")] // DataType -> Define o tipo de dados do campo com tipos pre configurados dentro do C#
        [Display(Name = "Data de Validade")]
        public DateTime? DataValidade { get; set; }

        [Required]
        [DataType(DataType.Currency)] // Currency -> Define o campo como valor decimal da moeda corrente (R$)
        [Display(Name = "Preço de Custo")]
        public decimal? PrecoCusto { get; set; }

        [Required]
        [DataType(DataType.Currency)] // Currency -> Define o campo como valor decimal da moeda corrente (R$)
        [Display(Name = "Preço de Venda")]
        public decimal? PrecoVenda { get; set; }

        [Display(Name = "Descrição Detalhada")]
        [DataType(DataType.MultilineText)] // Permite um texto mais longo (textarea)
        public string? Descricao { get; set; }
    }
}
