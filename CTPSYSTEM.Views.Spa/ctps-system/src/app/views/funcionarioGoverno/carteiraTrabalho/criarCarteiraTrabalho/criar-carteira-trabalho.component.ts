import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators, FormControl } from '@angular/forms';
import { NgxUiLoaderService } from 'ngx-ui-loader';
import { ToastrService } from 'ngx-toastr';
import { BsLocaleService } from 'ngx-bootstrap/datepicker';
import { defineLocale } from 'ngx-bootstrap/chronos';
import { ptBrLocale } from 'ngx-bootstrap/locale';
defineLocale('pt-br', ptBrLocale);

import {
    CriarCarteiraTrabalho,
    CriarEstrangeiro,
    FuncionarioDetalhes,
    MessageModel} from '../../../Models';
import { FuncionarioGovernoService } from '../../funcionarioGoverno.service';

@Component({
    selector: 'app-criar-carteira-trabalho',
    templateUrl: './criar-carteira-trabalho.component.html'
})
export class CriarCarteiraTrabalhoComponent implements OnInit {
    public novaCarteiraTrabalho: CriarCarteiraTrabalho = new CriarCarteiraTrabalho();
    public funcionarioSelecionado: FuncionarioDetalhes;
    public estrangeiro = false;

    public formGroup = this.formBuilder.group({
        numero: ['numero', Validators.required],
        serie: ['serie', Validators.required],
        numeroDocumento: ['numeroDocumento', Validators.required],
        filiacaoMae: ['filiacaoMae', Validators.required],
        filiacaoPai: ['filiacaoPai', Validators.required],
    });

    public get numero() { return this.formGroup.get('numero'); }
    public get serie() { return this.formGroup.get('serie'); }
    public get numeroDocumento() { return this.formGroup.get('numeroDocumento'); }
    public get filiacaoMae() { return this.formGroup.get('filiacaoMae'); }
    public get filiacaoPai() { return this.formGroup.get('filiacaoPai'); }
    // estrangeiro
    public get chegada() { return this.formGroup.get('chegada'); }
    public get documentoIdentidade() { return this.formGroup.get('documentoIdentidade'); }
    public get expedicao() { return this.formGroup.get('expedicao'); }
    public get estado() { return this.formGroup.get('estado'); }
    public get observacao() { return this.formGroup.get('observacao'); }

    constructor(private funcionarioGovernoService: FuncionarioGovernoService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private formBuilder: FormBuilder,
        private localeService: BsLocaleService,
        private toasterService: ToastrService) { }

    ngOnInit(): void {
        this.localeService.use('pt-br');
        this.funcionarioSelecionado = JSON.parse(localStorage.getItem('selectedFuncionario'));
    }

    estrangeiroChange() {
        if (this.estrangeiro) {
            this.formGroup.addControl('chegada', new FormControl('chegada', Validators.required));
            this.formGroup.addControl('documentoIdentidade', new FormControl('documentoIdentidade', Validators.required));
            this.formGroup.addControl('expedicao', new FormControl('expedicao', Validators.required));
            this.formGroup.addControl('estado', new FormControl('estado', Validators.required));
            this.novaCarteiraTrabalho.estrangeiro = new CriarEstrangeiro();
            this.novaCarteiraTrabalho.estrangeiro.chegada = new Date();
            this.novaCarteiraTrabalho.estrangeiro.expedicao = new Date();
        } else {
            this.formGroup.removeControl('chegada');
            this.formGroup.removeControl('documentoIdentidade');
            this.formGroup.removeControl('expedicao');
            this.formGroup.removeControl('estado');
            this.novaCarteiraTrabalho.estrangeiro = undefined;
        }
    }

    cadastrarCarteiraTrabalho() {
        this.ngxUiLoaderService.start();
        this.novaCarteiraTrabalho.idFuncionario = this.funcionarioSelecionado.id;
        this.funcionarioGovernoService.cadastrarCarteiraTrabalho(this.novaCarteiraTrabalho).subscribe(
            (sucesso) => {
                this.toasterService.success(`CTPS cadastrada com sucesso para o usuário ${this.funcionarioSelecionado.nome}`, 'Sucesso');
                this.novaCarteiraTrabalho = new CriarCarteiraTrabalho();
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
