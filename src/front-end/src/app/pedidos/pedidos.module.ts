import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PedidosRoutingModule } from './pedidos-routing.module';
import { CriarPedidosComponent } from './criar-pedidos/criar-pedidos.component';
import { ListarPedidosComponent } from './listar-pedidos/listar-pedidos.component';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { TemplateModule } from '../template/template.module';


@NgModule({
  declarations: [
    CriarPedidosComponent,
    ListarPedidosComponent,],
  imports: [
    CommonModule,
    PedidosRoutingModule,
    FormsModule,
    RouterModule,
    TemplateModule
  ],
  exports:[
    CriarPedidosComponent,
    ListarPedidosComponent,
  ]
})
export class PedidosModule { }
