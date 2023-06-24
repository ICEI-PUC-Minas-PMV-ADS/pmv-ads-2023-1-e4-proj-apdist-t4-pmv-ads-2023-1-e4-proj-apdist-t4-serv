import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PedidosRoutingModule } from './pedidos-routing.module';
import { CriarPedidosComponent } from './criar-pedidos/criar-pedidos.component';
import { ListarPedidosComponent } from './listar-pedidos/listar-pedidos.component';


@NgModule({
  declarations: [
    CriarPedidosComponent,
    ListarPedidosComponent,],
  imports: [
    CommonModule,
    PedidosRoutingModule
  ],
  exports:[
    CriarPedidosComponent,
    ListarPedidosComponent,
  ]
})
export class PedidosModule { }
