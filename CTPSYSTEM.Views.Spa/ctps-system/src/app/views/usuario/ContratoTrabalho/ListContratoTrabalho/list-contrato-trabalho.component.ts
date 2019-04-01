import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

import {
    ContratoTrabalhoDetalhes,
    User, 
    MessageModel} from '../../../Models';
import { UsuarioService } from '../../usuario.service';
import { AccountService } from '../../../account.service';

@Component({
    selector: 'app-list-contrato-trabalho',
    templateUrl: './list-contrato-trabalho.component.html'
})
export class ListContratoTrabalhoComponent implements OnInit {
    public contratoTrabalhoList: Array<ContratoTrabalhoDetalhes>;
    public usuarioLogado: User;

    constructor(private usuarioService: UsuarioService,
        private accountService: AccountService,
        private toasterservice: ToastrService) {
            this.usuarioLogado = this.accountService.recuperausuarioLogado();
     }

    ngOnInit(): void {
        this.recuperaContratoTrabalho();
     }

     recuperaContratoTrabalho() {
         const idCarteiraTrabalho = this.usuarioLogado.funcionario.idCarteiraTrabalho;
         this.usuarioService.recuperaContratoTrabaho(idCarteiraTrabalho).subscribe(
             (sucesso) => {
                const contratoTrabalhoList = sucesso as Array<ContratoTrabalhoDetalhes>;
                this.contratoTrabalhoList = contratoTrabalhoList;
             },
             (erro) => {
                const mensagemErro = erro as MessageModel;
                this.toasterservice.error(mensagemErro.texto, 'Erro');
             }
         );
     }
}
