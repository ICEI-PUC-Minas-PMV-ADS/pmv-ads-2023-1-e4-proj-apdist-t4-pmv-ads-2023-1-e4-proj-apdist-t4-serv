import { TipoServico } from "../tipo-servicos";

export interface Pedido {
  id?: number;
  tipoServico: TipoServico;
  descricao : string;
  usuarioId: number;
  status: string;
  data: Date;
}
