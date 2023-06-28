import { Component } from '@angular/core';
import { Pedido } from '../pedido';
import { PedidoService } from '../pedido.service';
import { AuthService } from 'src/app/auth.service';

@Component({
  selector: 'app-listar-pedidos',
  templateUrl: './listar-pedidos.component.html',
  styleUrls: ['./listar-pedidos.component.css']
})
export class ListarPedidosComponent {

  listaPedidos: Pedido[] = [];
  pedidoSelecionado!: Pedido;
  acao: string = '';
  tituloModal: string = '';
  tituloBotaoModal: string = '';

  constructor(
    private pedidoService: PedidoService,
    private authService: AuthService,

    ) { }

  ngOnInit(): void {
    this.pedidoService.listar(this.authService.getUsuarioId()).subscribe((listaPedidos)=> {
      this.listaPedidos = listaPedidos;
    });
  }

  prepararPedidoParaAcao(pedido: Pedido, acao: string) {
    this.pedidoSelecionado = pedido;
    this.acao = acao;
    this.tituloModal = `Deseja realmente ${acao[0].toUpperCase() + acao.substr(1)} este pedido?`;
    this.tituloBotaoModal = acao[0].toUpperCase() + acao.substr(1);
  }

  acaoModal(){
    if (this.acao && this.pedidoSelecionado && this.pedidoSelecionado.id){
      if(this.acao === 'cancelar'){
        this.pedidoService.cancelar(this.pedidoSelecionado.id).subscribe(()=>{
          console.log("cancelou");
          this.ngOnInit();
        });
      }
      if(this.acao === 'enviar'){
        this.pedidoService.enviar(this.pedidoSelecionado.id).subscribe(()=>{
          console.log("enviou");
          this.ngOnInit();
        });
      }
      if(this.acao === 'aprovar'){
        this.pedidoService.aprovar(this.pedidoSelecionado.id).subscribe(()=>{
          console.log("aprovou");
          this.ngOnInit();
        });
      }
      if(this.acao === 'rejeitar'){
        this.pedidoService.rejeitar(this.pedidoSelecionado.id).subscribe(()=>{
          console.log("rejeitou");
          this.ngOnInit();
        });
      }
    }

  }


}
