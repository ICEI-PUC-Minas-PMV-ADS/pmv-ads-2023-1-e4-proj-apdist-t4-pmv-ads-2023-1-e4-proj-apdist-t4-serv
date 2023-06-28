namespace api_contratos_servicos.Models.Dto
{
    public class OrcamentoDTO
    {
        public int Id { get; set; }

        public Pedido Pedido { get; set; }

        public double ValorOrcamento { get; set; }

        public string Status { get; set; }

         public DateTime Data { get; set; }


    }
}
