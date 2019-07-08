import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { NgxUiLoaderService } from 'ngx-ui-loader';

import {
    User,
    MessageModel,
    FuncionarioDetalhes,
    Roles} from '../../../Models';
import { EmpresaService } from '../../empresa.service';
import { AccountService } from '../../../account.service';
import { FuncionarioGovernoService } from '../../../funcionarioGoverno/funcionarioGoverno.service';

@Component({
    selector: 'app-listagem-funcionario',
    templateUrl: './listagem-funcionario.component.html'
})
export class ListagemFuncionarioComponent implements OnInit {
    public funcionarioList: Array<FuncionarioDetalhes> = Array<FuncionarioDetalhes>();
    public usuarioLogado: User;

    constructor(private empresaService: EmpresaService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private funcionarioGovernoService: FuncionarioGovernoService,
        private accountService: AccountService,
        private toasterService: ToastrService) {
            this.usuarioLogado = this.accountService.recuperausuarioLogado();
        }

    ngOnInit(): void {
        if (this.usuarioLogado.role[0] === Roles.Empresa) {
            this.recuperaFuncionariosEmpresa();
        }
        else if (this.usuarioLogado.role[0] === Roles.Funcionario) {
            this.recuperaFuncionariosFuncionarioGoverno();
        }
    }

    recuperaFuncionariosEmpresa() {
        this.ngxUiLoaderService.start();
        const idEmpresa = this.usuarioLogado.empresa.id;
        this.empresaService.recuperaFuncionarios(idEmpresa).subscribe(
            (sucesso) => {
                const funcionarioList = sucesso as Array<FuncionarioDetalhes>;
                this.funcionarioList = funcionarioList;
            },
            (erro) => {
                const mensagemErro = erro as MessageModel;
                this.toasterService.error(mensagemErro.texto, 'Erro');
                this.ngxUiLoaderService.stop();
            },
            () => { this.ngxUiLoaderService.stop(); }
        );
    }

    recuperaFuncionariosFuncionarioGoverno() {
        this.ngxUiLoaderService.start();
        this.funcionarioGovernoService.recuperaFuncionarios().subscribe(
            (sucesso) => {
                const funcionarioList = sucesso as Array<FuncionarioDetalhes>;
                this.funcionarioList = funcionarioList;
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
