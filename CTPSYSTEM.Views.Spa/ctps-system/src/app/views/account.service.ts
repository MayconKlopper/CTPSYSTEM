import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';

import { LogIn, Register, User } from './Models';
import { environment } from '../../environments/environment';

@Injectable()
export class AccountService {
    private API = environment.api + 'Account/';

    constructor(private router: Router, private http: HttpClient) {
    }

    public recuperausuarioLogado(): User {
        const usuarioLogado = JSON.parse(localStorage.getItem('usuarioLogado'));

        if (usuarioLogado) {
            return usuarioLogado;
        }
        else {
            this.router.navigate(['./login']);
        }
    }

    public logado(): boolean {
        if (JSON.parse(localStorage.getItem('usuarioLogado'))) {
            return true;
        }

        return false;
    }

    public logIn(usuario: LogIn) {
        return this.http.post(this.API + 'LogIn', usuario);
    }

    public logOut() {
        return this.http.get(this.API + 'LogOut');
    }

    public cadastrarUsuario(usuario: Register) {
        return this.http.post(this.API + 'cadastrarUsuario', usuario);
    }
}
