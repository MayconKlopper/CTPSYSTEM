import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { BsLocaleService } from 'ngx-bootstrap/datepicker';
import { defineLocale } from 'ngx-bootstrap/chronos';
import { ptBrLocale } from 'ngx-bootstrap/locale';
defineLocale('pt-br', ptBrLocale);

import {
    CriarInternacao,
    FuncionarioDetalhes,
    MessageModel} from '../../../Models';
import { EmpresaService } from '../../empresa.service';

@Component({
    selector: 'app-criar-internacao',
    templateUrl: './criar-internacao.component.html'
})
export class CriarInternacaoComponent implements OnInit {
    public selectedFuncionario: FuncionarioDetalhes;
    public novaInternacao: CriarInternacao = new CriarInternacao;

    public formGroup = this.formBuilder.group({
        dataInternacao: ['dataInternacao', Validators.required],
        dataAlta: ['dataAlta', Validators.required],
        hospital: ['hospital', Validators.required],
        registro: ['registro', Validators.required],
        matricula: ['matricula', Validators.required]
    });

    public get dataInternacao() { return this.formGroup.get('dataInternacao'); }
    public get dataAlta() { return this.formGroup.get('dataAlta'); }
    public get hospital() { return this.formGroup.get('hospital'); }
    public get registro() { return this.formGroup.get('registro'); }
    public get matricula() { return this.formGroup.get('matricula'); }

    constructor(private empresaService: EmpresaService,
        private toasterService: ToastrService,
        private formBuilder: FormBuilder,
        private localeService: BsLocaleService) { }

    ngOnInit(): void {
        this.localeService.use('pt-br');
        this.novaInternacao.dataInternacao = new Date();
        this.novaInternacao.dataAlta = new Date();
        this.selectedFuncionario = this.empresaService.recuperaFuncinarioSelecionado();
    }

    criarInternacao() {
        this.novaInternacao.idCarteiratrabalho = this.selectedFuncionario.idCarteiraTrabalho;
        this.empresaService.cadastrarInternacao(this.novaInternacao).subscribe(
            (sucesso) => {
                this.toasterService.success(`O Registro de Internação foi criado com sucesso para o funcionário ${this.selectedFuncionario.nome}`, 'Sucesso');
            },
            (erro) => {
                const mensagemErro = erro as MessageModel;
                this.toasterService.error(mensagemErro.texto, 'Erro');
            }
        );
    }
}
