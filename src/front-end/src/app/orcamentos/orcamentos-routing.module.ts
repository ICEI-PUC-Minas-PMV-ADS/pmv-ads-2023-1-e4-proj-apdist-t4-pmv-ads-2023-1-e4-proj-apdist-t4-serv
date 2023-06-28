import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutComponent } from '../layout/layout.component';
import { DetalharOrcamentosComponent } from './detalhar-orcamentos/detalhar-orcamentos.component';
import { ListarOrcamentosComponent } from './listar-orcamentos/listar-orcamentos.component';
import { authGuard } from '../auth.guard';

const routes: Routes = [
  {path: 'orcamentos', component: LayoutComponent, children: [
    {path: 'editar/:id', component: DetalharOrcamentosComponent, canActivate: [authGuard]},
    {path: 'listar', component: ListarOrcamentosComponent, canActivate: [authGuard]},
    {path: '',redirectTo: '/orcamentos/listar', pathMatch: 'full'}
  ]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OrcamentosRoutingModule { }
