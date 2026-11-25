using System.ComponentModel.DataAnnotations;

namespace AulaApp1.Components.Models
{
    public class Categoria
    {
        [Required(ErrorMessage = "Informe o nome.")]
        public string Nome { get; set; } = "";

        [Range(1, 100000, ErrorMessage = "Quantidade maior que zero.")]
        public int Quantidade { get; set; }
    }

}
