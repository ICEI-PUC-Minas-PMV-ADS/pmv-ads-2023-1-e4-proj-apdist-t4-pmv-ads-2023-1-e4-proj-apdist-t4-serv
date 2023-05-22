import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Usuario } from './login/usuario';
import { Observable } from 'rxjs';
import { environment } from '../environments/environment';
import { JwtHelperService } from '@auth0/angular-jwt';
import { UsuarioRegistro } from './register/usuarioRegistro';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  apiURL: string = environment.apiURLBase + "/Usuarios/cadastrar";
  tokenURL: string = environment.apiURLBase + "/Usuarios/login";
  jwtHelper: JwtHelperService = new JwtHelperService();
  
  constructor(
    private http: HttpClient
  ) { }

  obterToken(){
    const tokenString = localStorage.getItem('access_token');
    if (tokenString) {
      const token = JSON.parse(tokenString).token;
      return token;      
    }
    return null;
  }

  encerrarSessao(){
    localStorage.removeItem('access_token');
  }

  getUsuarioAutenticado(){
    const token = this.obterToken();
    if (token) {
      const usuario = this.jwtHelper.decodeToken(token).user_name;
      return usuario;      
    }
    return null;
  }

  isAutheticated(): boolean{
    const token = this.obterToken();
    if (token) {
      const expired = this.jwtHelper.isTokenExpired(token);
      return !expired;      
    }
    return false;
  }

  salvar(usuario: UsuarioRegistro): Observable<any>{
    return this.http.post<any>(this.apiURL, usuario);
  }

  tentarLogar( username: string, password: string): Observable<any>{
    /*const params = new HttpParams()
                                        .set('username', username)
                                        .set('password', password)
                                        .set('grant_type', 'password');
    const headers = {
      //'Authorization' : 'Basic ' + btoa(`${this.clientID}:${this.clientSecret}`),
      'Content-Type' : 'application/x-www-form-urlencoded'
    }
    */
    const usuario: Usuario= new Usuario();
    usuario.email = username;
    usuario.senha = password;
    return /*this.http.get<any[]>(`http://servicos.melopecas.com.br/api/TipoServicos`);//*/this.http.post<any>(this.tokenURL, usuario);
  }
}
