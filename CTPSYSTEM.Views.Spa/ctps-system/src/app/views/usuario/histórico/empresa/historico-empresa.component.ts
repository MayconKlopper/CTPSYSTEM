import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { NgxUiLoaderService } from 'ngx-ui-loader';

import {
    EmpresaHistorico,
    User,
    MessageModel} from '../../../Models';
import { UsuarioService } from '../../usuario.service';
import { AccountService } from '../../../account.service';

@Component({
    selector: 'app-historico-empresa',
    templateUrl: './historico-empresa.component.html'
})
export class HistoricoEmpresaComponent implements OnInit {
    public historicoEmpresaList: Array<EmpresaHistorico> = new Array<EmpresaHistorico>();
    public usuarioLogado: User;

    constructor(private usuarioService: UsuarioService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private accountService: AccountService,
        private toasterservice: ToastrService) {
            this.usuarioLogado = this.accountService.recuperausuarioLogado();
     }

    ngOnInit(): void {
        this.recuperaEmpresaHistorico();
    }

    recuperaEmpresaHistorico() {
        this.ngxUiLoaderService.start();
        const idFuncionario = this.usuarioLogado.funcionario.id;
        this.usuarioService.recuperarEmpesaHistorico(idFuncionario).subscribe(
            (sucesso) => {
                const historicoEmpresaList = sucesso as Array<EmpresaHistorico>;
                this.historicoEmpresaList = historicoEmpresaList;
            },
            (erro) => {
                const mensagemErro = erro as MessageModel;
                this.toasterservice.error(mensagemErro.texto, 'Erro');
                this.ngxUiLoaderService.stop();
            },
            () => { this.ngxUiLoaderService.stop(); }
        );
    }
}
