import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { NgxUiLoaderService } from 'ngx-ui-loader';
import { ToastrService } from 'ngx-toastr';
import { BsLocaleService } from 'ngx-bootstrap/datepicker';
import { defineLocale } from 'ngx-bootstrap/chronos';
import { ptBrLocale } from 'ngx-bootstrap/locale';
defineLocale('pt-br', ptBrLocale);

import {
    CriarAlteracaoSalarial,
    FuncionarioDetalhes,
    MessageModel} from '../../../Models';
import { EmpresaService } from '../../empresa.service';

@Component({
    selector: 'app-criar-alteracao-salarial',
    templateUrl: './criar-alteracao-salarial.component.html'
})
export class CriarAlteracaoSalarialComponent implements OnInit {
    public selectedFuncionario: FuncionarioDetalhes;
    public novaAlteracaoSalarial: CriarAlteracaoSalarial = new CriarAlteracaoSalarial();

    public formGroup = this.formBuilder.group({
        cargo: ['cargo', Validators.required],
        dataAumento: ['dataAumento', Validators.required],
        motivo: ['motivo', Validators.required],
        remuneracao: ['remuneracao', Validators.required],
        remuneracaoExtenso: ['remuneracaoExtenso', Validators.required],
    });

    public get cargo() { return this.formGroup.get('cargo'); }
    public get dataAumento() { return this.formGroup.get('dataAumento'); }
    public get motivo() { return this.formGroup.get('motivo'); }
    public get remuneracao() { return this.formGroup.get('remuneracao'); }
    public get remuneracaoExtenso() { return this.formGroup.get('remuneracaoExtenso'); }

    constructor(private empresaService: EmpresaService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private toasterService: ToastrService,
        private formBuilder: FormBuilder,
        private localeService: BsLocaleService) { }

    ngOnInit(): void {
        this.localeService.use('pt-br');
        this.novaAlteracaoSalarial.dataAumento = new Date();
        this.selectedFuncionario = this.empresaService.recuperaFuncinarioSelecionado();
    }

    criarAlteracaoSalarial() {
        this.ngxUiLoaderService.start();
        this.novaAlteracaoSalarial.idContratoTrabalho = this.selectedFuncionario.idContratoTrabalho;
        this.empresaService.cadastrarAlteracaoSalarial(this.novaAlteracaoSalarial).subscribe(
            (sucesso) => {
                this.toasterService.success(`Alteração Salarial criada com sucesso para o funcionário ${this.selectedFuncionario.nome}`, 'Sucesso');
                this.novaAlteracaoSalarial = new CriarAlteracaoSalarial();
            },
            (erro) => {
                const mensagemErro = erro as MessageModel;
                this.toasterService.error(mensagemErro.texto, 'Erro');
                this.ngxUiLoaderService.stop();
            },
            () => { this.ngxUiLoaderService.stop(); }
        );
    }
}
