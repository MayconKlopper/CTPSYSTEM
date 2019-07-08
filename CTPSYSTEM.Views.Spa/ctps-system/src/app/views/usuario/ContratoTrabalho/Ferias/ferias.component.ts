import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { NgxUiLoaderService } from 'ngx-ui-loader';

import {
    ContratoTrabalhoDetalhes,
    FeriasDetalhes,
    MessageModel } from '../../../Models';
import { UsuarioService } from '../../usuario.service';

@Component({
    selector: 'app-ferias',
    templateUrl: './ferias.component.html'
})
export class FeriasComponent implements OnInit {
    public contratoTrabalho: ContratoTrabalhoDetalhes;
    public feriasList: Array<FeriasDetalhes> = new Array<FeriasDetalhes>();

    constructor(private toasterService: ToastrService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private usuarioService: UsuarioService) { }

    ngOnInit(): void {
        this.contratoTrabalho = this.usuarioService.getContratoTrabalho();
        this.recuperaFerias();
     }

     recuperaFerias() {
        this.ngxUiLoaderService.start();
        const idContratoTrabalho = this.contratoTrabalho.id;
        this.usuarioService.recuperarFerias(idContratoTrabalho).subscribe(
            (sucesso) => {
                const feriasList = sucesso as Array<FeriasDetalhes>;
                this.feriasList = feriasList;
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
