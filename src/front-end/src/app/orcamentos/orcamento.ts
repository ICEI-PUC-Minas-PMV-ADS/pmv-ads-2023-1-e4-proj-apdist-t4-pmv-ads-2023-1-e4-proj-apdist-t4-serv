import { Pedido } from './../pedidos/pedido';
import { TipoServico } from "../tipo-servicos";

export interface Orcamento {
  id?: number;
  valorOrcamento: number;
  status: string;
  data: Date;
  pedido: Pedido;
}
