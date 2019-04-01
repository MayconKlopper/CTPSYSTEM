import { Component, OnInit, Input } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';

import { FuncionarioDetalhes, DesvincularFuncionario, MessageModel } from '../../Models';
import { EmpresaService } from '../empresa.service';

@Component({
    selector: 'app-funcionario',
    templateUrl: './funcionario.component.html'
})
export class FuncionarioComponent implements OnInit {
    @Input() public funcionario: FuncionarioDetalhes;
    @Input() public showSelectButton = false;

    constructor(private toasterService: ToastrService,
        private router: Router,
        private empresaService: EmpresaService) { }

    ngOnInit(): void { }

    public selectFuncionario() {
        localStorage.setItem('selectedFuncionario', JSON.stringify(this.funcionario));
        this.toasterService.info(`Funcionário ${this.funcionario.nome} selecionado`, 'Informação');
    }

    public encerrarContratoTrabalho() {
        const desvincularFuncionarioModel: DesvincularFuncionario = {
            idFuncionario: this.funcionario.id,
            idContratoTrabalho: this.funcionario.idContratoTrabalho
        };

        this.empresaService.desvincularFuncionario(desvincularFuncionarioModel).subscribe(
            (sucesso) => {
                const mensagemSucesso = sucesso as MessageModel;
                this.toasterService.success(mensagemSucesso.texto, 'Sucesso');
                localStorage.setItem('selectedFuncionario', null);
                window.location.reload();
            },
            (erro) => {
                const mensagemErro = erro as MessageModel;
                this.toasterService.error(mensagemErro.texto, 'Erro');
            }
        );
    }

    public criarContratoTrabalho() {
        localStorage.setItem('selectedFuncionario', JSON.stringify(this.funcionario));
        this.router.navigate(['./criar-contrato-trabalho']);
    }
}
