import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import {
    CriarContratoTrabalho,
    CriarEmpresa,
    CriarContribuicaoSindical,
    CriarFerias,
    CriarAlteracaoSalarial, 
    CriarAnotacaoGeral,
    CriarLicenca,
    CriarInternacao,
    VincularFuncionario,
    DesvincularFuncionario,
    CriarFGTS} from '../Models';

@Injectable({providedIn: 'root'})
export class EmpresaService {
    private API = 'http://localhost:5001/api/Empresa/';

    constructor(private httpClient: HttpClient,
        private router: Router,
        private toasterService: ToastrService) {}

    public recuperaFuncinarioSelecionado() {
        const selectedFuncionario = JSON.parse(localStorage.getItem('selectedFuncionario'));
        if (!selectedFuncionario) {
            this.router.navigate(['/listagem-funcionario']);
            this.toasterService.warning('Por favor, selecione um Funcionário', 'Alerta');
        }
        else {
            return selectedFuncionario;
        }
    }

    public cadastrarEmpresa(novaEmpresa: CriarEmpresa) {
        return this.httpClient.post(this.API + 'CadastrarEmpresa', novaEmpresa);
    }

    public cadastrarContratoTrabalho(novoContratoTrabalho: CriarContratoTrabalho) {
        return this.httpClient.post(this.API + 'CadastrarContratoTrabalho', novoContratoTrabalho);
    }

    public cadastrarContribuicaoSindical(novaContribuicaoSindical: CriarContribuicaoSindical) {
        return this.httpClient.post(this.API + 'CadastrarContribuicaoSindical', novaContribuicaoSindical);
    }

    public cadastrarAlteracaoSalarial(novaAlteracaoSalarial: CriarAlteracaoSalarial) {
        return this.httpClient.post(this.API + 'CadastrarAlteracaoSalarial', novaAlteracaoSalarial);
    }

    public cadastrarFerias(novaFerias: CriarFerias) {
        return this.httpClient.post(this.API + 'CadastrarFerias', novaFerias);
    }

    public cadastrarAnotacaoGeral(novaAnotacaoGeral: CriarAnotacaoGeral) {
        return this.httpClient.post(this.API + 'CadastrarAnotacaoGeral', novaAnotacaoGeral);
    }

    public cadastrarFGTS(criarFGTS: CriarFGTS) {
        return this.httpClient.post(this.API + 'CadastrarFGTS', criarFGTS);
    }

    public cadastrarLicenca(novaLicenca: CriarLicenca) {
        return this.httpClient.post(this.API + 'CadastrarLicenca', novaLicenca);
    }

    public cadastrarInternacao(novaInternacao: CriarInternacao) {
        return this.httpClient.post(this.API + 'CadastrarInternacao', novaInternacao);
    }

    public vincularFuncionario(vincularFuncionarioModel: VincularFuncionario) {
        return this.httpClient.post(this.API + 'VincularFuncionario', vincularFuncionarioModel);
    }

    public desvincularFuncionario(desvincularFuncionarioModel: DesvincularFuncionario) {
        return this.httpClient.post(this.API + 'DesvincularFuncionario', desvincularFuncionarioModel);
    }

    public recuperaFuncionarios(idEmpresa: number) {
        return this.httpClient.get(this.API + `RecuperaFuncionarios/${idEmpresa}`);
    }

    public recuperaFuncionarioHistorico(idEmpresa: number) {
        return this.httpClient.get(this.API + `RecuperaHistoricoFuncionarios/${idEmpresa}`);
    }
}
