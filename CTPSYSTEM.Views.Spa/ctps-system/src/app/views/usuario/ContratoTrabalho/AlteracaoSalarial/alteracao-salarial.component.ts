import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { NgxUiLoaderService } from 'ngx-ui-loader';

import { UsuarioService } from '../../usuario.service';
import { ContratoTrabalhoDetalhes,
    AlteracaoSalarialDetalhes,
    MessageModel } from '../../../Models';

@Component({
    selector: 'app-alteracao-salarial',
    templateUrl: './alteracao-salarial.component.html'
})
export class AlteracaoSalarialComponent implements OnInit {
    public contratoTrabalho: ContratoTrabalhoDetalhes;
    public alteracaoSalarialList: Array<AlteracaoSalarialDetalhes> = new Array<AlteracaoSalarialDetalhes>();

    constructor(private toasterService: ToastrService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private usuarioService: UsuarioService) { }

    ngOnInit(): void {
        this.contratoTrabalho = this.usuarioService.getContratoTrabalho();
        this.recuperaAlteracaoSalariall();
    }

    recuperaAlteracaoSalariall() {
        this.ngxUiLoaderService.start();
        const idContratoTrabalho = this.contratoTrabalho.id;
        this.usuarioService.recuperarAlteracaoSalarial(idContratoTrabalho).subscribe(
            (sucesso) => {
                const alteracaoSalarialList = sucesso as Array<AlteracaoSalarialDetalhes>;
                this.alteracaoSalarialList = alteracaoSalarialList;
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
