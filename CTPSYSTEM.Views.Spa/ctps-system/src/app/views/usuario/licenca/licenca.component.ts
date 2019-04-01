import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

import {
    LicencaDetalhes,
    User,
    MessageModel,
    CarteiraTrabalhoDetalhes } from '../../Models';
import { UsuarioService } from '../usuario.service';
import { AccountService } from '../../account.service';

@Component({
    selector: 'app-licenca',
    templateUrl: './licenca.component.html'
})
export class LicencaComponent implements OnInit {
    public licencaList: Array<LicencaDetalhes>;
    public carteiraTrabalho: CarteiraTrabalhoDetalhes;
    public usuarioLogado: User;

    constructor(private usuarioService: UsuarioService,
        private accountService: AccountService,
        private toasterservice: ToastrService) {
            this.usuarioLogado = this.accountService.recuperausuarioLogado();
     }

    ngOnInit(): void {
        this.carteiraTrabalho = this.usuarioLogado.funcionario.carteiraTrabalho;
        this.recuperaLicenca();
     }

     recuperaLicenca() {
        const idCarteiraTrabalho = this.usuarioLogado.funcionario.idCarteiraTrabalho;
        this.usuarioService.recuperarLicenca(idCarteiraTrabalho).subscribe(
            (sucesso) => {
                const licencaList = sucesso as Array<LicencaDetalhes>;
                this.licencaList = licencaList;
            },
            (erro) => {
                const mensagemErro = erro as MessageModel;
                this.toasterservice.error(mensagemErro.texto, 'Erro');
            }
        );
     }
}
