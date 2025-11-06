using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.Models
{
    public class Categoria
    {
        // Campo Id sempre será o nome da classe+Id
        // Ex: CategoriaId
        public int CategoriaId { get; set; }

        // DataAnnotations: validações nos campos do formulário, exibe mensagens de erros.
        [Required(ErrorMessage = "O Nome da categoria é obrigatório.")] // O campo Nome é Obrigatório
        [StringLength(100, ErrorMessage = "O nome da categoria não pode ter mais de 100 caracteres.")] // tamanho maximo do campo
        [Display(Name = "Nome da Categoria")]
        public string? Nome { get; set; }
    }
}
