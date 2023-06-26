using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_contratos_servicos.Models
{
    [Table("Orcamento")]
    public class Orcamento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o ID do Orçamento!")]
        public int PedidoId { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Valor do Orçamento!")]
        public double ValorOrcamento { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Status!")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Data!")]
        public DateTime Data { get; set; }

        public Usuario Usuario { get; set; }

        public int UsuarioId { get; set; }
    }
}
