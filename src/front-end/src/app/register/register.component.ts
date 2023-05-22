import { Router } from '@angular/router';
import { UsuarioRegistro } from './usuarioRegistro';
import { Component } from '@angular/core';
import { AuthService } from '../auth.service';

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
    private authService: AuthService
  ){
    this.usuarioRegistro = new UsuarioRegistro;
    this.senhaConfirmacao ='';
   }

   ngOnInit(): void {
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
