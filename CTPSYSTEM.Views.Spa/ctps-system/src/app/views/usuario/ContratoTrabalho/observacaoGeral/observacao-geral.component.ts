import { Component, OnInit } from '@angular/core';
import { NgxUiLoaderService } from 'ngx-ui-loader';

import { UsuarioService } from '../../usuario.service';
import {
    ContratoTrabalhoDetalhes,
    AnotacaoGeralDetalhes,
    MessageModel } from '../../../Models';
import { ToastrService } from 'ngx-toastr';

@Component({
    selector: 'app-observacao-geral',
    templateUrl: './observacao-geral.component.html'
})
export class ObservacaoGeralComponent implements OnInit {
    public contratoTrabalho: ContratoTrabalhoDetalhes;
    public anotacaoGeralList: Array<AnotacaoGeralDetalhes> = new Array<AnotacaoGeralDetalhes>();

    constructor(private toasterService: ToastrService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private usuarioService: UsuarioService) { }

    ngOnInit(): void {
        this.contratoTrabalho = this.usuarioService.getContratoTrabalho();
         this.recuperaAnotacaoGeral();
    }

    recuperaAnotacaoGeral() {
        this.ngxUiLoaderService.start();
        const idContratoTrabalho = this.contratoTrabalho.id;
        this.usuarioService.recuperarAnotacaoGeral(idContratoTrabalho).subscribe(
            (sucesso) => {
                const anotacaoGeralList = sucesso as Array<AnotacaoGeralDetalhes>;
                this.anotacaoGeralList = anotacaoGeralList;
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
