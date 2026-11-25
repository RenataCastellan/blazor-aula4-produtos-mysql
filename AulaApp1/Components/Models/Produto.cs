using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AulaApp1.Components.Models
{
    public class Produto
    {
        // Chave primária: o EF Core reconhece "Id" sozinho e o MySQL gera o número (AUTO_INCREMENT).
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome.")]
        [MaxLength(100)] // vira VARCHAR(100) no banco
        public string Nome { get; set; } = "";

        [Range(0.01, 100000, ErrorMessage = "Preço maior que zero.")]
        [Precision(10, 2)] // vira DECIMAL(10,2): dinheiro com 2 casas
        public decimal Preco { get; set; }

        public int Quantidade { get; set; }
    }

}
