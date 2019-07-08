import { Component, OnInit } from '@angular/core';
import { NgxUiLoaderService } from 'ngx-ui-loader';

import {
    ContratoTrabalhoDetalhes,
    MessageModel,
    FGTSDetalhes } from '../../../Models';
import { ToastrService } from 'ngx-toastr';
import { UsuarioService } from '../../usuario.service';

@Component({
    selector: 'app-fgts',
    templateUrl: './fgts.component.html'
})
export class FGTSComponent implements OnInit {
    public contratoTrabalho: ContratoTrabalhoDetalhes;
    public fgtsList: Array<FGTSDetalhes> = new Array<FGTSDetalhes>();

    constructor(private toasterService: ToastrService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private usuarioService: UsuarioService) { }

    ngOnInit(): void {
        this.contratoTrabalho = this.usuarioService.getContratoTrabalho();

        this.recuperaFgts();
     }

     recuperaFgts() {
        this.ngxUiLoaderService.start();
        const idContratoTrabalho = this.contratoTrabalho.id;
        this.usuarioService.recuperarFGTS(idContratoTrabalho).subscribe(
            (sucesso) => {
                const fgtsList = sucesso as Array<FGTSDetalhes>;
                this.fgtsList = fgtsList;
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
