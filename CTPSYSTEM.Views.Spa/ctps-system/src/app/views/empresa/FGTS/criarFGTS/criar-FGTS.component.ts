import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { BsLocaleService } from 'ngx-bootstrap/datepicker';
import { NgxUiLoaderService } from 'ngx-ui-loader';

import {
    FuncionarioDetalhes,
    CriarFGTS,
    MessageModel, 
    EstadoSigla} from '../../../Models';
import { EmpresaService } from '../../empresa.service';
import { UtilsService } from '../../../../Helpers/utils.service';

@Component({
    selector: 'app-criar-fgts',
    templateUrl: './criar-FGTS.component.html'
})
export class CriarFGTSComponent implements OnInit {
    public selectedFuncionario: FuncionarioDetalhes;
    public novoFGTS: CriarFGTS = new CriarFGTS();
    public estadoSiglaList;

    public formGroup = this.formBuilder.group({
        opcao: ['opcao', Validators.required],
        bancoDepositario: ['bancoDepositario', Validators.required],
        praca: ['praca', Validators.required],
        estado: ['estado', Validators.required]
    });

    public get opcao() { return this.formGroup.get('opcao'); }
    public get bancoDepositario() { return this.formGroup.get('bancoDepositario'); }
    public get praca() { return this.formGroup.get('praca'); }
    public get estado() { return this.formGroup.get('estado'); }

    constructor(private empresaService: EmpresaService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private toasterService: ToastrService,
        private utilsService: UtilsService,
        private formBuilder: FormBuilder,
        private localeService: BsLocaleService) { }

    ngOnInit(): void {
        this.localeService.use('pt-br');
        this.novoFGTS.opcao = new Date();
        this.selectedFuncionario = this.empresaService.recuperaFuncinarioSelecionado();
        this.estadoSiglaList = this.utilsService.transformaEnumParaVetor(EstadoSigla);
    }

    selectEstado(value: string) {
        this.novoFGTS.Estado = value;
    }

    criarFGTS() {
        this.ngxUiLoaderService.start();
        this.novoFGTS.idContratoTrabalho = this.selectedFuncionario.idContratoTrabalho;
        this.empresaService.cadastrarFGTS(this.novoFGTS).subscribe(
            (sucesso) => {
                this.toasterService.success(`O Registro de FGTS foi criado com sucesso para o funcionário ${this.selectedFuncionario.nome}`, 'Sucesso');
                this.novoFGTS = new CriarFGTS();
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
