import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { NgxUiLoaderService } from 'ngx-ui-loader';
import { ToastrService } from 'ngx-toastr';
import { BsLocaleService } from 'ngx-bootstrap/datepicker';
import { defineLocale } from 'ngx-bootstrap/chronos';
import { ptBrLocale } from 'ngx-bootstrap/locale';
defineLocale('pt-br', ptBrLocale);

import {
    CriarLicenca,
    FuncionarioDetalhes,
    MessageModel} from '../../../Models';
import { EmpresaService } from '../../empresa.service';

@Component({
    selector: 'app-criar-licenca',
    templateUrl: './criar-licenca.component.html'
})
export class CriarLicencaComponent implements OnInit {
    public selectedFuncionario: FuncionarioDetalhes;
    public novaLicenca: CriarLicenca = new CriarLicenca;

    public formGroup = this.formBuilder.group({
        dataInicio: ['dataInicio', Validators.required],
        dataTermino: ['dataTermino', Validators.required],
        codigoPosto: ['codigoPosto', Validators.required],
        motivo: ['motivo', Validators.required]
    });

    public get dataInicio() { return this.formGroup.get('dataInicio'); }
    public get dataTermino() { return this.formGroup.get('dataTermino'); }
    public get codigoPosto() { return this.formGroup.get('codigoPosto'); }
    public get motivo() { return this.formGroup.get('motivo'); }

    constructor(private empresaService: EmpresaService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private toasterService: ToastrService,
        private formBuilder: FormBuilder,
        private localeService: BsLocaleService) { }

    ngOnInit(): void {
        this.localeService.use('pt-br');
        this.novaLicenca.dataInicio = new Date();
        this.novaLicenca.dataTermino = new Date();
        this.selectedFuncionario = this.empresaService.recuperaFuncinarioSelecionado();
    }

    criarLicenca() {
        this.ngxUiLoaderService.start();
        this.novaLicenca.idCarteiratrabalho = this.selectedFuncionario.idCarteiraTrabalho;
        this.empresaService.cadastrarLicenca(this.novaLicenca).subscribe(
            (sucesso) => {
                this.toasterService.success(`Registro de Licença criado com sucesso para o funcionário ${this.selectedFuncionario.nome}`, 'Sucesso');
                this.novaLicenca = new CriarLicenca();
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
