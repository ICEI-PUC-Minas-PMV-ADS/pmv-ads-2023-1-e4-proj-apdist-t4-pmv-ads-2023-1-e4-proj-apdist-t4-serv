import { PedidoService } from './../../pedidos/pedido.service';
import { OrcamentoService } from './../orcamento.service';
import { Component } from '@angular/core';
import { Orcamento } from '../orcamento';
import { AuthService } from 'src/app/auth.service';

@Component({
  selector: 'app-listar-orcamentos',
  templateUrl: './listar-orcamentos.component.html',
  styleUrls: ['./listar-orcamentos.component.css']
})
export class ListarOrcamentosComponent {

  listaOrcamentos: Orcamento[] = [];
  orcamentoSelecionado!: Orcamento;
  acao: string = '';
  tituloModal: string = '';
  tituloBotaoModal: string = '';

  constructor(
    private orcamentoService: OrcamentoService,
    private authService: AuthService,
    ) { }

  ngOnInit(): void {
    this.orcamentoService.listar(this.authService.getUsuarioId()).subscribe((listaOrcamentos)=> {
      this.listaOrcamentos = listaOrcamentos;
    });
  }

  prepararOrcamentoParaAcao(orcamento: Orcamento, acao: string) {
    this.orcamentoSelecionado = orcamento;
    this.acao = acao;
    this.tituloModal = `Deseja realmente ${acao[0].toUpperCase() + acao.substr(1)} este orcamento?`;
    this.tituloBotaoModal = acao[0].toUpperCase() + acao.substr(1);
  }

  acaoModal(){
    if (this.acao && this.orcamentoSelecionado && this.orcamentoSelecionado.id){
      if(this.acao === 'enviar'){
        if(this.orcamentoSelecionado.valorOrcamento == 0) {
          alert("Valor do Orcamento zerado!!!");
          return
        }
        this.orcamentoService.enviar(this.orcamentoSelecionado.id).subscribe(()=>{
          console.log("enviar");
          this.ngOnInit();
        });
      }
    }

  }


}
