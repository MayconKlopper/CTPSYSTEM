import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

import { FuncionarioHistorico, User, MessageModel } from '../../../Models';
import { EmpresaService } from '../../empresa.service';
import { AccountService } from '../../../account.service';

@Component({
    selector: 'app-historico-funcionario',
    templateUrl: './historico-funcionario.component.html'
})
export class HistoricoFuncionarioComponent implements OnInit {
    public funcionarioList: Array<FuncionarioHistorico> = Array<FuncionarioHistorico>();
    public usuarioLogado: User;

    constructor(private empresaService: EmpresaService,
        private accountService: AccountService,
        private toasterService: ToastrService) {
            this.usuarioLogado = this.accountService.recuperausuarioLogado();
        }

        ngOnInit(): void {
            const idEmpresa = this.usuarioLogado.empresa.id;
            this.recuperaFuncionarioHistorico(idEmpresa);
        }

        public recuperaFuncionarioHistorico(idEmpresa: number) {
            this.empresaService.recuperaFuncionarioHistorico(idEmpresa).subscribe(
                (sucesso) => {
                    this.funcionarioList = sucesso as Array<FuncionarioHistorico>;
                },
                (erro) => {
                    const mensagemErro = erro as MessageModel;
                    this.toasterService.error(mensagemErro.texto, 'Erro');
                }
            );
        }
}
