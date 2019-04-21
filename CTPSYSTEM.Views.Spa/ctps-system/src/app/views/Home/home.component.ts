import { Component, OnInit } from '@angular/core';

import { CarteiraTrabalhoDetalhes, User, MessageModel, Roles } from '../Models';
import { AccountService } from '../account.service';
import { UsuarioService } from '../usuario/usuario.service';
import { ToastrService } from 'ngx-toastr';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {
    public collapseOne = true;
    public collapseTwo = true;
    public collapseThree = true;
    public collapseFour = true;
    public carteiraTrabalho: CarteiraTrabalhoDetalhes;
    public usuarioLogado: User;

    constructor(private accountService: AccountService,
        private usuarioService: UsuarioService,
        private toasterservice: ToastrService) {
        this.usuarioLogado = this.accountService.recuperausuarioLogado();
    }

    ngOnInit(): void {
        if (this.usuarioLogado.role[0] === Roles.Usuario) {
            this.carteiraTrabalho = this.usuarioLogado.funcionario.carteiraTrabalho;
        }
     }
}
