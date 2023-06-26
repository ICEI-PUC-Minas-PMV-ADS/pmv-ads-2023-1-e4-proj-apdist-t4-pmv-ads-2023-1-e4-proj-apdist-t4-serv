using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_contratos_servicos.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Tipo De Serviço!")]

        public TipoServico TipoServico { get; set; }

        [JsonIgnore]
        public int TipoServicoId { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Data!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Descrição!")]
        public string Descricao { get; set; }


        [Required(ErrorMessage = "Obrigatório Informar o Status!")]
        public string Status { get; set; }

        [JsonIgnore]
        public Usuario Usuario { get; set; }

        public int UsuarioId { get; set; }

    }


}
