import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CriarPedidosComponent } from './criar-pedidos/criar-pedidos.component';
import { authGuard } from '../auth.guard';
import { LayoutComponent } from '../layout/layout.component';
import { ListarPedidosComponent } from './listar-pedidos/listar-pedidos.component';

const routes: Routes = [
  {path: 'pedidos', component: LayoutComponent, children: [
    {path: 'novo', component: CriarPedidosComponent, canActivate: [authGuard]},
    {path: 'listar', component: ListarPedidosComponent, canActivate: [authGuard]},
    {path: '',redirectTo: '/pedidos/listar', pathMatch: 'full'}
  ]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PedidosRoutingModule { }
