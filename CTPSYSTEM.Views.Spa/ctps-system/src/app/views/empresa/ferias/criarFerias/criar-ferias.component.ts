import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { BsLocaleService } from 'ngx-bootstrap/datepicker';
import { defineLocale } from 'ngx-bootstrap/chronos';
import { ptBrLocale } from 'ngx-bootstrap/locale';
defineLocale('pt-br', ptBrLocale);

import {
    CriarFerias,
    FuncionarioDetalhes,
    MessageModel} from '../../../Models';
import { EmpresaService } from '../../empresa.service';

@Component({
    selector: 'app-criar-ferias',
    templateUrl: './criar-ferias.component.html'
})
export class CriarFeriasComponent implements OnInit {
    public selectedFuncionario: FuncionarioDetalhes;
    public novaFerias: CriarFerias = new CriarFerias;

    public formGroup = this.formBuilder.group({
        periodoRelativo: ['periodoRelativo', Validators.required],
        dataInicio: ['dataInicio', Validators.required],
        dataTermino: ['dataTermino', Validators.required]
    });

    public get periodoRelativo() { return this.formGroup.get('periodoRelativo'); }
    public get dataInicio() { return this.formGroup.get('dataInicio'); }
    public get dataTermino() { return this.formGroup.get('dataTermino'); }

    constructor(private empresaService: EmpresaService,
        private toasterService: ToastrService,
        private formBuilder: FormBuilder,
        private localeService: BsLocaleService) { }

    ngOnInit(): void {
        this.localeService.use('pt-br');
        this.novaFerias.dataInicio = new Date();
        this.novaFerias.dataTermino = new Date();
        this.selectedFuncionario = this.empresaService.recuperaFuncinarioSelecionado();
    }

    criarFerias() {
        this.novaFerias.idContratoTrabalho = this.selectedFuncionario.idContratoTrabalho;
        this.empresaService.cadastrarFerias(this.novaFerias).subscribe(
            (sucesso) => {
                this.toasterService.success(`Registro de férias criado com sucesso para o funcionário ${this.selectedFuncionario.nome}`, 'Sucesso');
            },
            (erro) => {
                const mensagemErro = erro as MessageModel;
                this.toasterService.error(mensagemErro.texto, 'Erro');
            }
        );
    }
}
