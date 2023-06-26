using System.Text.Json.Serialization;

namespace api_contratos_servicos.Models
{
    public class FornecedorTipoServico
    {
        public int FornecedorId { get; set; }

        [JsonIgnore]
        public virtual Fornecedor Fornecedor { get; set; }
        public int TipoServicoId { get; set; }

        [JsonIgnore]
        public virtual TipoServico TipoServico { get; set; }
    }
}
