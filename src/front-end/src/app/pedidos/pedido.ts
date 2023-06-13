export interface Pedido {
  id?: number
  cliente: string
  tipoServico: string
  descricao : string
  usuarioId: number;
  status: string;
}
