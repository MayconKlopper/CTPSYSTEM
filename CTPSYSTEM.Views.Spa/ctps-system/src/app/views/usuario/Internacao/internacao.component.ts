import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { NgxUiLoaderService } from 'ngx-ui-loader';

import {
    InternacaoDetalhes,
    User,
    MessageModel,
    CarteiraTrabalhoDetalhes} from '../../Models';
import { UsuarioService } from '../usuario.service';
import { AccountService } from '../../account.service';

@Component({
    selector: 'app-internacao',
    templateUrl: './internacao.component.html'
})
export class InternacaoComponent implements OnInit {
    public internacaoList: Array<InternacaoDetalhes> = new Array<InternacaoDetalhes>();
    public carteiraTrabalho: CarteiraTrabalhoDetalhes;
    public usuarioLogado: User;

    constructor(private usuarioService: UsuarioService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private accountService: AccountService,
        private toasterservice: ToastrService) {
            this.usuarioLogado = this.accountService.recuperausuarioLogado();
     }

    ngOnInit(): void {
        this.carteiraTrabalho = this.usuarioLogado.funcionario.carteiraTrabalho;
        this.recuperaInternacao();
     }

     recuperaInternacao() {
        this.ngxUiLoaderService.start();
        const idCarteiraTrabalho = this.usuarioLogado.funcionario.idCarteiraTrabalho;
        this.usuarioService.recuperaInternacao(idCarteiraTrabalho).subscribe(
            (sucesso) => {
                const internacaoList = sucesso as Array<InternacaoDetalhes>;
                this.internacaoList = internacaoList;
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
