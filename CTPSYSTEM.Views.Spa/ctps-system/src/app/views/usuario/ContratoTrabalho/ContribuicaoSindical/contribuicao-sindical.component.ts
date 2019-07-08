import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgxUiLoaderService } from 'ngx-ui-loader';

import {
    ContratoTrabalhoDetalhes,
    ContribuicaoSindicalDetalhes,
    MessageModel } from '../../../Models';
import { UsuarioService } from '../../usuario.service';
import { ToastrService } from 'ngx-toastr';

@Component({
    selector: 'app-contribuicao-sindical',
    templateUrl: './contribuicao-sindical.component.html'
})
export class ContribuicaoSindicalComponent implements OnInit {
    public contratoTrabalho: ContratoTrabalhoDetalhes;
    public contribuicaoSindicalList: Array<ContribuicaoSindicalDetalhes> = new Array<ContribuicaoSindicalDetalhes>();

    constructor(private router: Router,
        private ngxUiLoaderService: NgxUiLoaderService,
        private usuarioService: UsuarioService,
        private toasterService: ToastrService) {}

    ngOnInit(): void {
        this.contratoTrabalho = this.usuarioService.getContratoTrabalho();
        this.recuperaContribuicaoSindical();
     }

     recuperaContribuicaoSindical() {
        this.ngxUiLoaderService.start();
         const idContratoTrabalho = this.contratoTrabalho.id;
         this.usuarioService.recuperarContribuicaoSindical(idContratoTrabalho).subscribe(
             (sucesso) => {
                const contribuicaoSindicalList = sucesso as Array<ContribuicaoSindicalDetalhes>;
                this.contribuicaoSindicalList = contribuicaoSindicalList;
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
