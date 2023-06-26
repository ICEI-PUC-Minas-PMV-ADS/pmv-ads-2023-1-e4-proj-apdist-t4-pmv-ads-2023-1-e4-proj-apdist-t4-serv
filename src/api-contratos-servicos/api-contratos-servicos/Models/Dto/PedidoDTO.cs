namespace api_contratos_servicos.Models.Dto
{
    public class PedidoDTO
    {
        public int Id { get; set; }
        public TipoServico TipoServico { get; set; }
        public string Descricao { get; set; }
        public int UsuarioId { get; set; }
    }
}
