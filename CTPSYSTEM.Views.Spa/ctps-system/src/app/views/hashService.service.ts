import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';

import { CriarHash, HashDetalhes } from './Models';
import { environment } from '../../environments/environment';



@Injectable({
    providedIn: 'root'
})
export class HashService {
    private APIHash = environment.api + 'Hash/';

    constructor(private httpClient: HttpClient,
        private toasterService: ToastrService) {}

    public gerarChave(novoHash: CriarHash) {
        return this.httpClient.post(this.APIHash + 'GerarHash', novoHash);
    }

    public verificarValidadeHash(hash: HashDetalhes) {
        return this.httpClient.post(this.APIHash + 'VerificarValidadeHash', hash);
    }

    public hashValido(): boolean {
        return JSON.parse(localStorage.getItem('hashValido'));
    }
}
