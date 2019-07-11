import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { NgxUiLoaderService } from 'ngx-ui-loader';
import { ToastrService } from 'ngx-toastr';
import { BsLocaleService } from 'ngx-bootstrap/datepicker';
import { defineLocale } from 'ngx-bootstrap/chronos';
import { ptBrLocale } from 'ngx-bootstrap/locale';
defineLocale('pt-br', ptBrLocale);

import {
    FuncionarioDetalhes,
    CriarContratoTrabalho,
    User,
    MessageModel } from '../../../Models';
import { EmpresaService } from '../../empresa.service';

@Component({
    selector: 'app-criar-contrato-trabalho',
    templateUrl: './criar-contrato-trabalho.component.html'
})
export class CriarContratoTrabalhoComponent implements OnInit {
    public selectedFuncionario: FuncionarioDetalhes;
    public usuarioLogado: User;
    public novoContratoTrabalho: CriarContratoTrabalho = new CriarContratoTrabalho;

    public formGroup = this.formBuilder.group({
        cargo: ['cargo', Validators.required],
        dataAdmissao: ['dataAdmissao', Validators.required],
        CBONumero: ['CBONumero', Validators.required],
        remuneracao: ['remuneracao', Validators.required],
        remuneracaoExtenso: ['remuneracaoExtenso', Validators.required],
    });

    public get cargo() { return this.formGroup.get('cargo'); }
    public get dataAdmissao() { return this.formGroup.get('dataAdmissao'); }
    public get CBONumero() { return this.formGroup.get('CBONumero'); }
    public get remuneracao() { return this.formGroup.get('remuneracao'); }
    public get remuneracaoExtenso() { return this.formGroup.get('remuneracaoExtenso'); }

    constructor(private empresaService: EmpresaService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private toasterService: ToastrService,
        private formBuilder: FormBuilder,
        private localeService: BsLocaleService) { }

    ngOnInit(): void {
        this.localeService.use('pt-br');
        this.novoContratoTrabalho.dataAdmissao = new Date();
        this.selectedFuncionario = this.empresaService.recuperaFuncinarioSelecionado();
        this.usuarioLogado = JSON.parse(localStorage.getItem('usuarioLogado'));
    }

    criarContratoTrabalho() {
        this.ngxUiLoaderService.start();
        this.novoContratoTrabalho.idEmpresa = this.usuarioLogado.empresa.id;
        this.novoContratoTrabalho.idCarteiraTrabalho = this.selectedFuncionario.idCarteiraTrabalho;
        this.empresaService.cadastrarContratoTrabalho(this.novoContratoTrabalho).subscribe(
            (sucesso) => {
                const idContratoTrabalho = sucesso as number;
                this.toasterService.success(`Contrato de trabalho criado com sucesso para o Funcionário ${this.selectedFuncionario.nome}`, 'Sucesso');

                this.selectedFuncionario.idContratoTrabalho = idContratoTrabalho;
                localStorage.setItem('selectedFuncionario', JSON.stringify(this.selectedFuncionario));
                this.novoContratoTrabalho = new CriarContratoTrabalho();
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
