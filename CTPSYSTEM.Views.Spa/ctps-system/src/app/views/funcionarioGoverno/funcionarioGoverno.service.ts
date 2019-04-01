import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CriarCarteiraTrabalho } from '../Models';

@Injectable({ providedIn: 'root' })
export class FuncionarioGovernoService {
    private API = 'http://localhost:5001/api/FuncionarioGoverno/';

    constructor(private httpClient: HttpClient) {}

    public recuperaFuncionarios() {
        return this.httpClient.get(this.API + 'RecuperaFuncionario');
    }

    public cadastrarCarteiraTrabalho(novaCarteiraTrabalho: CriarCarteiraTrabalho) {
        return this.httpClient.post(this.API + 'CadastarCarteiraTrabalho', novaCarteiraTrabalho);
    }
}
