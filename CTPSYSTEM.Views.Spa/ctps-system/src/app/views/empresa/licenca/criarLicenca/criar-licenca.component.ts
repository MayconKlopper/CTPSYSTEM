import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
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
    private selectedFuncionario: FuncionarioDetalhes;
    public novaLicenca: CriarLicenca = new CriarLicenca;

    public formGroup = this.formBuilder.group({
        dataInicio: ['dataInicio', Validators.required],
        dataTermino: ['dataTermino', Validators.required],
        codigoPosto: ['codigoPosto', Validators.required],
        Motivo: ['remuneracao', Validators.required]
    });

    public get dataInicio() { return this.formGroup.get('dataInicio'); }
    public get dataTermino() { return this.formGroup.get('dataTermino'); }
    public get codigoPosto() { return this.formGroup.get('codigoPosto'); }
    public get Motivo() { return this.formGroup.get('Motivo'); }

    constructor(private empresaService: EmpresaService,
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
        this.novaLicenca.idCarteiratrabalho = this.selectedFuncionario.idCarteiraTrabalho;
        this.empresaService.cadastrarLicenca(this.novaLicenca).subscribe(
            (sucesso) => {
                this.toasterService.success(`Registro de Licença criado com sucesso para o funcionário ${this.selectedFuncionario.nome}`, 'Sucesso');
            },
            (erro) => {
                const mensagemErro = erro as MessageModel;
                this.toasterService.error(mensagemErro.texto, 'Erro');
            }
        );
    }
}