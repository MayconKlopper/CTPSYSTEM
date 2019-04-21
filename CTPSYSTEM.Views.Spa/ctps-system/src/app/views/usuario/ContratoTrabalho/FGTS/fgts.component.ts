import { Component, OnInit } from '@angular/core';

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
    public fgtsList: Array<FGTSDetalhes>;

    constructor(private toasterService: ToastrService,
        private usuarioService: UsuarioService) { }

    ngOnInit(): void {
        this.contratoTrabalho = this.usuarioService.getContratoTrabalho();

        this.recuperaFgts();
     }

     recuperaFgts() {
        const idContratoTrabalho = this.contratoTrabalho.id;
        this.usuarioService.recuperarFGTS(idContratoTrabalho).subscribe(
            (sucesso) => {
                const fgtsList = sucesso as Array<FGTSDetalhes>;
                this.fgtsList = fgtsList;
            },
            (erro) => {
                const mensagemErro = erro as MessageModel;
                this.toasterService.error(mensagemErro.texto, 'Erro');
            }
        );
     }
}
