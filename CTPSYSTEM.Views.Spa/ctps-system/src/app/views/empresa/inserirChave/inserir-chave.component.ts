import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { NgxUiLoaderService } from 'ngx-ui-loader';
import { Router } from '@angular/router';

import { HashService } from '../../hashService.service';
import { HashDetalhes, FuncionarioDetalhes, MessageModel } from '../../Models';
import { EmpresaService } from '../empresa.service';

@Component({
    selector: 'app-inserir-chave',
    templateUrl: './inserir-chave.component.html'
})
export class InserirChaveComponent implements OnInit {
    public hashModel: HashDetalhes = new HashDetalhes();
    public funcionarioSelecionado: FuncionarioDetalhes;

    public formGroup = this.formBuilder.group({
        chave: ['chave', Validators.required]
    });

    public get chave() { return this.formGroup.get('chave'); }

    constructor(private hashService: HashService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private empresaService: EmpresaService,
        private toasterService: ToastrService,
        private formBuilder: FormBuilder,
        private router: Router) { }

    ngOnInit(): void {
        this.funcionarioSelecionado = this.empresaService.recuperaFuncinarioSelecionado();
    }

    public inserirChave() {
        this.ngxUiLoaderService.start();
        this.hashModel.idCarteiraTrabalho = this.funcionarioSelecionado.idCarteiraTrabalho;
        this.hashModel.idFuncionario = this.funcionarioSelecionado.id;
        this.hashService.verificarValidadeHash(this.hashModel).subscribe(
            (sucesso) => {
                localStorage.setItem('hashValido', 'true');
                this.router.navigate(['./criar-contribuicao-sindical']);
            },
            (erro) => {
                const mensagemErro = erro as MessageModel;
                this.toasterService.error(mensagemErro.texto, 'Erro');
                localStorage.setItem('hashValido', 'false');
                this.ngxUiLoaderService.stop();
            },
            () => { this.ngxUiLoaderService.stop(); }
        );
    }
}
