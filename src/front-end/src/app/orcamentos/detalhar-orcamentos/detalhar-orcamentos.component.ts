import { Component } from '@angular/core';
import { Orcamento } from '../orcamento';
import { OrcamentoService } from '../orcamento.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-detalhar-orcamentos',
  templateUrl: './detalhar-orcamentos.component.html',
  styleUrls: ['./detalhar-orcamentos.component.css']
})
export class DetalharOrcamentosComponent {
  orcamento: Orcamento = {
    valorOrcamento: 0,
    status: '',
    data: new Date(),
    pedido: {
      tipoServico: {
        id: 0,
        descricaoServico: ''
      },
      descricao : '',
      usuarioId: 0,
      status: 'Pendente',
      data:new Date()
    }
  };



  constructor(
    private orcamentoService: OrcamentoService,
    private router: Router,
    private route: ActivatedRoute
    ) { }


    ngOnInit(): void {
      const id = this.route.snapshot.paramMap.get('id');
      if (id) { //edicao
        this.orcamentoService.buscarPorId(parseInt(id)).subscribe((orcamento)=>{
          this.orcamento = orcamento
        })
      }
    }

    salvarOrcamento() {
      if (this.orcamento.id) {
        this.orcamentoService.editar(this.orcamento).subscribe(()=>{
          this.router.navigate(['/orcamentos'])
        });
      } 
    }

    cancelarOrcamento(){
      this.router.navigate(['/orcamentos'])
    }

    


  

}
