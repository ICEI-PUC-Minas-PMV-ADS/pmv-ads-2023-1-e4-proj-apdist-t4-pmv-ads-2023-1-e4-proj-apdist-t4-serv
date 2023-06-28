import { NgModule } from "@angular/core";
import { ListarOrcamentosComponent } from "./listar-orcamentos/listar-orcamentos.component";
import { DetalharOrcamentosComponent } from "./detalhar-orcamentos/detalhar-orcamentos.component";
import { CommonModule } from "@angular/common";
import { OrcamentosRoutingModule } from "./orcamentos-routing.module";
import { FormsModule } from "@angular/forms";
import { RouterModule } from "@angular/router";
import { TemplateModule } from "../template/template.module";

@NgModule({
  declarations: [
    ListarOrcamentosComponent,
    DetalharOrcamentosComponent,
  ],
  imports: [
    CommonModule,
    OrcamentosRoutingModule,
    FormsModule,
    RouterModule,
    TemplateModule,
  ],
  exports: [
    ListarOrcamentosComponent,
    DetalharOrcamentosComponent,
  ]
})
export class OrcamentosModule { }
