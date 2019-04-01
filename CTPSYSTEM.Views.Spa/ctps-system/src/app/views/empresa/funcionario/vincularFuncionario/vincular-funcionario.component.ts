import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

import {
    VincularFuncionario,
    User,
    MessageModel} from '../../../Models';
import { ToastrService } from 'ngx-toastr';
import { EmpresaService } from '../../empresa.service';
import { AccountService } from '../../../account.service';

@Component({
    selector: 'app-vincular-funcionario',
    templateUrl: './vincular-funcionario.component.html'
})
export class VincularFuncionarioComponent implements OnInit {
    public vincularFuncionarioModel: VincularFuncionario = new VincularFuncionario();
    private usuarioLogado: User;

    public formGroup = this.formBuilder.group({
        cpf: ['cpf', Validators.required],
        hashCode: ['hashCode', Validators.required]
    });

    public get cpf() { return this.formGroup.get('cpf'); }
    public get hashCode() { return this.formGroup.get('hashCode'); }

    constructor(private toasterService: ToastrService,
        private empresaService: EmpresaService,
        private accountService: AccountService,
        private formBuilder: FormBuilder) {
            this.usuarioLogado = this.accountService.recuperausuarioLogado();
        }

    ngOnInit(): void { }

    vincularFuncionario() {
        this.vincularFuncionarioModel.idEmpresa = this.usuarioLogado.empresa.id;
        this.empresaService.vincularFuncionario(this.vincularFuncionarioModel).subscribe(
            (sucesso) => {
                const mensagemSucesso = sucesso as MessageModel;
                this.toasterService.success(mensagemSucesso.texto, 'Sucesso');
            },
            (erro) => {
                const mensagemErro = erro as MessageModel;
                this.toasterService.error(mensagemErro.texto, 'Erro');
            }
        );
    }
}
