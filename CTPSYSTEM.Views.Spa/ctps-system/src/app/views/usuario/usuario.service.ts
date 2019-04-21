import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { environment } from '../../../environments/environment';

import {
    ContratoTrabalhoDetalhes,
    CriarFuncionario,
    CriarHash } from '../Models';

@Injectable()
export class UsuarioService {
    private API = environment.api + 'Funcionario/';

    constructor(private httpClient: HttpClient,
        private router: Router,
        private toasterService: ToastrService) {}

    public getContratoTrabalho(): ContratoTrabalhoDetalhes {
        const selectedContratoTrabalho = JSON.parse(localStorage.getItem('selectedContratoTrabalho'));
        if (!selectedContratoTrabalho) {
            this.router.navigate(['/contrato-trabalho']);
            this.toasterService.warning('Por favor, selecione um contrato de trabalho', 'Alerta');
        }
        else {
            return selectedContratoTrabalho;
        }
    }

    public recuperaUsuario(cpf: string) {
        return this.httpClient.get(this.API + `RecuperaFuncionario/${cpf}`);
    }

    public recuperaCarteiraTrabalho(idUsuario: number) {
        return this.httpClient.get(this.API + `RecuperaCarteiraTrabalho/${idUsuario}`);
    }

    public recuperarLicenca(idCarteiraTrabalho: number) {
        return this.httpClient.get(this.API + `RecuperaLicenca/${idCarteiraTrabalho}`);
    }

    public recuperaInternacao(idCarteiraTrabalho: number) {
        return this.httpClient.get(this.API + `RecuperaInternacao/${idCarteiraTrabalho}`);
    }

    public recuperaContratoTrabaho(idCarteiraTrabalho: number) {
        return this.httpClient.get(this.API + `RecuperaContratoTrabalho/${idCarteiraTrabalho}`);
    }

    public recuperarContribuicaoSindical(idContratoTrabalho: number) {
        return this.httpClient.get(this.API + `RecuperaContribuicaoSindical/${idContratoTrabalho}`);
    }

    public recuperarAlteracaoSalarial(idContratoTrabalho: number) {
        return this.httpClient.get(this.API + `RecuperaAlteracaoSalarial/${idContratoTrabalho}`);
    }

    public recuperarFerias(idContratoTrabalho: number) {
        return this.httpClient.get(this.API + `RecuperaFerias/${idContratoTrabalho}`);
    }

    public recuperarAnotacaoGeral(idContratoTrabalho: number) {
        return this.httpClient.get(this.API + `RecuperaAnotacaoGeral/${idContratoTrabalho}`);
    }

    public recuperarFGTS(idContratoTrabalho: number) {
        return this.httpClient.get(this.API + `RecuperaFGTS/${idContratoTrabalho}`);
    }

    public recuperarCarteiraTrabalhoHistorico(idFuncionario: number) {
        return this.httpClient.get(this.API + `RecuperaCarteiraTrabalhoHistorico/${idFuncionario}`);
    }

    public recuperarEmpesaHistorico(idFuncionario: number) {
        return this.httpClient.get(this.API + `RecuperaEmpresaHistorico/${idFuncionario}`);
    }

    public cadastrarFuncionario(novoFuncionario: CriarFuncionario) {
        return this.httpClient.post(this.API + 'CadastrarFuncionario', novoFuncionario);
    }
}
