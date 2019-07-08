import { Component, OnInit } from '@angular/core';
import { UsuarioService } from '../usuario.service';
import { ToastrService } from 'ngx-toastr';
import { NgxUiLoaderService } from 'ngx-ui-loader';

import {
    CriarHash,
    MessageModel,
    User} from '../../Models';
import { HashService } from '../../hashService.service';

@Component({
    selector: 'app-gerar-chave',
    templateUrl: './gerar-chave.component.html'
})
export class GerarChaveComponent implements OnInit {
    public chave = '';
    public criarHash: CriarHash = new CriarHash();
    public usuarioLogado: User;

    constructor(private usuarioService: UsuarioService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private toasterservice: ToastrService,
        private hashService: HashService) { }

    ngOnInit(): void {
        this.usuarioLogado = JSON.parse(localStorage.getItem('usuarioLogado'));
    }

    gerarChave() {
        this.ngxUiLoaderService.start();
        this.criarHash.idFuncionario = this.usuarioLogado.funcionario.id;
        this.criarHash.idCarteiraTrabalho = this.usuarioLogado.funcionario.idCarteiraTrabalho;
        this.hashService.gerarChave(this.criarHash).subscribe(
            (sucesso) => {
                const chave = sucesso as string;
                this.chave = chave;
            },
            (erro) => {
                const mensagemErro = erro as MessageModel;
                this.toasterservice.error(mensagemErro.texto, 'Erro');
                this.ngxUiLoaderService.stop();
            },
            () => { this.ngxUiLoaderService.stop(); }
        );
    }
}
