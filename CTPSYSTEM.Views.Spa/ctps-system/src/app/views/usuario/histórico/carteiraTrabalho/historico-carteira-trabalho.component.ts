import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { NgxUiLoaderService } from 'ngx-ui-loader';

import {
    CarteiraTrabalhoDetalhes,
    User,
    MessageModel} from '../../../Models';
import { UsuarioService } from '../../usuario.service';
import { AccountService } from '../../../account.service';

@Component({
    selector: 'app-historico-carteira-trabalho',
    templateUrl: './historico-carteira-trabalho.component.html'
})
export class HistoricoCarteiraTraballhoComponent implements OnInit {
    public carteiraTrabalhoList: Array<CarteiraTrabalhoDetalhes> = Array<CarteiraTrabalhoDetalhes>();
    public usuarioLogado: User;

    constructor(private usuarioService: UsuarioService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private accountService: AccountService,
        private toasterservice: ToastrService) {
            this.usuarioLogado = this.accountService.recuperausuarioLogado();
     }

    ngOnInit(): void {
        this.recuperaCarteiraTrabalhoHistorico();
    }

    recuperaCarteiraTrabalhoHistorico() {
        this.ngxUiLoaderService.start();
        const idFuncionario = this.usuarioLogado.funcionario.id;
        this.usuarioService.recuperarCarteiraTrabalhoHistorico(idFuncionario).subscribe(
            (sucesso) => {
                const carteiraTrabalhoList = sucesso as Array<CarteiraTrabalhoDetalhes>;
                this.carteiraTrabalhoList = carteiraTrabalhoList;
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
