import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

import { EmpresaDetalhes, MessageModel } from '../../../Models';
import { FuncionarioGovernoService } from '../../funcionarioGoverno.service';

@Component({
    selector: 'app-listagem-empresa',
    templateUrl: './listagem-empresa.component.html'
})
export class ListagemEmpresaComponent implements OnInit {
    public empresaList: Array<EmpresaDetalhes>;

    constructor(private funcionarioGovernoService: FuncionarioGovernoService,
        private toasterService: ToastrService) { }

    ngOnInit(): void {
        this.recuperaEmpresas();
    }

    recuperaEmpresas() {
        this.funcionarioGovernoService.recuperaEmpresas().subscribe(
            (sucesso) => {
                const funcionarioList = sucesso as Array<EmpresaDetalhes>;
                this.empresaList = funcionarioList;
            },
            (erro) => {
                const mensagemErro = erro as MessageModel;
                this.toasterService.error(mensagemErro.texto, 'Erro');
            }
        );
    }
}
