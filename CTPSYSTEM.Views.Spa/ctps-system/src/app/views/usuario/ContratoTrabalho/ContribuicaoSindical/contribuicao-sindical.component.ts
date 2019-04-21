import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

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
    public contribuicaoSindicalList: Array<ContribuicaoSindicalDetalhes>;

    constructor(private router: Router,
        private usuarioService: UsuarioService,
        private toasterService: ToastrService) {}

    ngOnInit(): void {
        this.contratoTrabalho = this.usuarioService.getContratoTrabalho();
        this.recuperaContribuicaoSindical();
     }

     recuperaContribuicaoSindical() {
         const idContratoTrabalho = this.contratoTrabalho.id;
         this.usuarioService.recuperarContribuicaoSindical(idContratoTrabalho).subscribe(
             (sucesso) => {
                const contribuicaoSindicalList = sucesso as Array<ContribuicaoSindicalDetalhes>;
                this.contribuicaoSindicalList = contribuicaoSindicalList;
             },
             (erro) => {
                const mensagemErro = erro as MessageModel;
                this.toasterService.error(mensagemErro.texto, 'Erro');
             }
         );
     }
}
