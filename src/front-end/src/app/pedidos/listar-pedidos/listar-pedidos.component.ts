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

  constructor(
    private pedidService: PedidoService,
    private authService: AuthService,

    ) { }

  ngOnInit(): void {
    console.log("Entroua!!!")
    this.pedidService.listar(this.authService.getUsuarioId()).subscribe((listaPedidos)=> {
      this.listaPedidos = listaPedidos;
    });

  }

}
