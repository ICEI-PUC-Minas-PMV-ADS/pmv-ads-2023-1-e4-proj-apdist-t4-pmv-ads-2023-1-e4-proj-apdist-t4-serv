using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_contratos_servicos.Models
{
    [Table("TipoServico")]
    public class TipoServico
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Descricao do Tipo de Serviço!")]
        public string descricaoServico { get; set; }

        [JsonIgnore]
        public virtual ICollection<FornecedorTipoServico> FornecedorTipoServico { get; set; }

    }
}
