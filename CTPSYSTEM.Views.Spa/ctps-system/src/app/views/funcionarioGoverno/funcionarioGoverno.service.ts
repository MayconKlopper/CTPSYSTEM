import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CriarCarteiraTrabalho } from '../Models';
import { environment } from '../../../environments/environment';

@Injectable({ providedIn: 'root' })
export class FuncionarioGovernoService {
    private API = environment.api + 'FuncionarioGoverno/';

    constructor(private httpClient: HttpClient) {}

    public recuperaFuncionarios() {
        return this.httpClient.get(this.API + 'RecuperaFuncionario');
    }

    public recuperaEmpresas() {
        return this.httpClient.get(this.API + 'RecuperaEmpresa');
    }

    public cadastrarCarteiraTrabalho(novaCarteiraTrabalho: CriarCarteiraTrabalho) {
        return this.httpClient.post(this.API + 'CadastarCarteiraTrabalho', novaCarteiraTrabalho);
    }
}
