import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Orcamento } from './orcamento';
import { Pedido } from '../pedidos/pedido';

@Injectable({
  providedIn: 'root'
})
export class OrcamentoService {

  private readonly apiURL: string = environment.apiURLBase + "/Orcamentos";


  constructor(
    private http: HttpClient
  ) { }

  listar(usuarioId: number): Observable<Orcamento[]>{
    const url = `${this.apiURL}/usuario/${usuarioId}`
    return this.http.get<Orcamento[]>(url);
  }

  editar(orcamento: Orcamento): Observable<Orcamento> {
    const url = `${this.apiURL}/${orcamento.id}`
    return this.http.put<Orcamento>(url, orcamento);
  }

  buscarPorId(id: number): Observable<Orcamento> {
    const url = `${this.apiURL}/${id}`
    return this.http.get<Orcamento>(url);
  }

  enviar(id: number): Observable<Orcamento> {
    const url = `${this.apiURL}/${id}/enviar`
    return this.http.post<Orcamento>(url, null);
  }
}
