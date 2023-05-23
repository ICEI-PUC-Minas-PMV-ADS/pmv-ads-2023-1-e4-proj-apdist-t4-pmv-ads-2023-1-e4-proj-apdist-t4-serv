import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  constructor(
    private router: Router
  ){

   }

  redirectLogin() {
    console.log("entou1")
    this.router.navigate(['/login'])
  }

  redirectCadastro() {
    console.log("entou2")
    this.router.navigate(['/register'])
  }

}
