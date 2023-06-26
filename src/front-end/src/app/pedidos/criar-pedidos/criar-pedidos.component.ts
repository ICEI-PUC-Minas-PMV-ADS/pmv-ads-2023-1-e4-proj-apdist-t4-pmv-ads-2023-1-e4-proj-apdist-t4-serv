import { TipoServico } from './../../tipo-servicos';
import { Component } from '@angular/core';
import { PedidoService } from '../pedido.service';
import { AuthService } from 'src/app/auth.service';
import { TipoServicosService } from 'src/app/tipo-servicos.service';
import { Pedido } from '../pedido';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-criar-pedidos',
  templateUrl: './criar-pedidos.component.html',
  styleUrls: ['./criar-pedidos.component.css']
})
export class CriarPedidosComponent {
  pedido: Pedido = {
    tipoServico: {
      id: 0,
      descricaoServico: ''
    },
    descricao : '',
    usuarioId: 0,
    status: 'Pendente',
    data:new Date()
  };

  listaTipoServico: TipoServico[] = [];


  constructor(
    private pedidoService: PedidoService,
    private authService: AuthService,
    private tipoServico: TipoServicosService,
    private router: Router,
    private route: ActivatedRoute
    ) { }


    ngOnInit(): void {
      this.tipoServico.listar().subscribe((listaTipoServico)=> {
        console.log(listaTipoServico);
        this.listaTipoServico = listaTipoServico;
      });
      const id = this.route.snapshot.paramMap.get('id');
      if (id) { //edicao
        this.pedidoService.buscarPorId(parseInt(id)).subscribe((pedido)=>{
          this.pedido = pedido
        })
      }
    }

    salvarPedido() {
      if (this.pedido.id) {
        this.pedidoService.editar(this.pedido).subscribe(()=>{
          this.router.navigate(['/pedidos'])
        });
      } 
      else {
        this.pedido.usuarioId = this.authService.getUsuarioId();
        const found = this.listaTipoServico.find(element => element.id = this.pedido.tipoServico.id);
        if (found)
          this.pedido.tipoServico.descricaoServico = found.descricaoServico;
        //this.pedido.tipoServico.descricaoServico = this.listaTipoServico.indexOf()
        console.log(this.pedido);
        
        this.pedidoService.criar(this.pedido).subscribe(()=>{
          this.router.navigate(['/pedidos'])
        });
      }
    }

    cancelarPedido(){
      this.router.navigate(['/pedidos'])
    }

    


  

}
