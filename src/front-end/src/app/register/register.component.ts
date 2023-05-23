import { Router } from '@angular/router';
import { UsuarioRegistro } from './usuarioRegistro';
import { Component } from '@angular/core';
import { AuthService } from '../auth.service';
import { CepServiceService } from '../cep-service.service';
import { Cep } from './cep';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  usuarioRegistro: UsuarioRegistro;
  senhaConfirmacao: string;
  errors?: String[];

  constructor(
    private router: Router,
    private authService: AuthService,
    private cepService: CepServiceService
  ){
    this.usuarioRegistro = new UsuarioRegistro;
    this.senhaConfirmacao ='';
   }

   ngOnInit(): void {
  }

  consultaCep(){
    console.log(this.usuarioRegistro.cep);
    if (this.usuarioRegistro.cep) {
      this.cepService.buscar(this.usuarioRegistro.cep).subscribe((dados) => this.populaForm(dados))
    }
  }

  populaForm(dados: Cep){
    this.usuarioRegistro.logradouro = dados.logradouro;
    this.usuarioRegistro.bairro = dados.bairro;
    this.usuarioRegistro.cidade = dados.localidade;
    this.usuarioRegistro.uf = dados.uf;
  }

  onSubmit(){
    console.log(this.usuarioRegistro);
    if (this.usuarioRegistro) {
      this.authService
                  .salvar(this.usuarioRegistro)
                  .subscribe( {
                    next: (response) =>{
                      console.log(response);
                      this.router.navigate(['/home']);
                    }, 
                    error: (errorResponse) => {
                      console.log(errorResponse);
                      this.errors = ['Usuário e/ou senha incorreto(s).']

                    }
                  });
    } else {
      this.errors = ['Usuário e/ou senha incorreto(s).']
    }
  }
}
