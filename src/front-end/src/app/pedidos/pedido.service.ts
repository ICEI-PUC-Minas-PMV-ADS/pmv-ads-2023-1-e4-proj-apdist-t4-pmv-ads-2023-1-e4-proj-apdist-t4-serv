import { Usuario } from './../login/usuario';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Pedido } from './pedido';

@Injectable({
  providedIn: 'root'
})
export class PedidoService {

  private readonly apiURL: string = environment.apiURLBase + "/Pedidos/usuario";


  constructor(
    private http: HttpClient
  ) { }

  listar(usuarioId: number): Observable<Pedido[]>{
    const url = `${this.apiURL}/${usuarioId}`
    return this.http.get<Pedido[]>(url);
  }


}
