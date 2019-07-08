import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { NgxUiLoaderService } from 'ngx-ui-loader';

import {
    CriarAnotacaoGeral,
    FuncionarioDetalhes,
    MessageModel
} from '../../../Models';
import { EmpresaService } from '../../empresa.service';

@Component({
    selector: 'app-criar-anotacao-geral',
    templateUrl: './criar-anotacao-geral.component.html'
})
export class CriarAnotacaoGeralComponent implements OnInit {
    public selectedFuncionario: FuncionarioDetalhes;
    public novaAnotacaoGeral: CriarAnotacaoGeral = new CriarAnotacaoGeral();

    public formGroup = this.formBuilder.group({
        texto: ['texto', Validators.required],
    });

    public get texto() { return this.formGroup.get('texto'); }

    constructor(private empresaService: EmpresaService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private toasterService: ToastrService,
        private formBuilder: FormBuilder) { }

    ngOnInit(): void {
        this.selectedFuncionario = this.empresaService.recuperaFuncinarioSelecionado();
    }

    criarAnotacaoGeral() {
        this.ngxUiLoaderService.start();
        this.novaAnotacaoGeral.idContratoTrabalho = this.selectedFuncionario.idContratoTrabalho;
        this.empresaService.cadastrarAnotacaoGeral(this.novaAnotacaoGeral).subscribe(
            (sucesso) => {
                this.toasterService.success(`Anotação Geral criada com sucesso para o funcionário ${this.selectedFuncionario.nome}`, 'Sucesso');
                this.novaAnotacaoGeral = new CriarAnotacaoGeral();
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
