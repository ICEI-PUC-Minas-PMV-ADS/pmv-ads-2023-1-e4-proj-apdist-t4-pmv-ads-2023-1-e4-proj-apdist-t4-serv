import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Pedido } from './pedido';

@Injectable({
  providedIn: 'root'
})
export class PedidoService {

  private readonly apiURL: string = environment.apiURLBase + "/Pedidos";


  constructor(
    private http: HttpClient
  ) { }

  listar(usuarioId: number): Observable<Pedido[]>{
    const url = `${this.apiURL}/usuario/${usuarioId}`
    return this.http.get<Pedido[]>(url);
  }

  criar(pedido: Pedido): Observable<Pedido> {
    const url = `${this.apiURL}`
    return this.http.post<Pedido>(url, pedido);
  }

  editar(pedido: Pedido): Observable<Pedido> {
    const url = `${this.apiURL}/${pedido.id}`
    return this.http.put<Pedido>(url, pedido);
  }

  buscarPorId(id: number): Observable<Pedido> {
    const url = `${this.apiURL}/${id}`
    return this.http.get<Pedido>(url);
  }

  enviar(id: number): Observable<Pedido> {
    const url = `${this.apiURL}/${id}/enviar`
    return this.http.post<Pedido>(url, null);
  }

  cancelar(id: number): Observable<Pedido> {
    const url = `${this.apiURL}/${id}/cancelar`
    return this.http.delete<Pedido>(url);
  }


}
