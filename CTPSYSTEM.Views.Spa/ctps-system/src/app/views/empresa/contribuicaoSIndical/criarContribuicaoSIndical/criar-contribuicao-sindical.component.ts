import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { NgxUiLoaderService } from 'ngx-ui-loader';

import { FuncionarioDetalhes,
    CriarContribuicaoSindical,
    MessageModel} from '../../../Models';
import { EmpresaService } from '../../empresa.service';

@Component({
    selector: 'app-criar-contribuicao-sindical',
    templateUrl: './criar-contribuicao-sindical.component.html'
})
export class CriarContribuicaoSindicalComponent implements OnInit {
    public selectedFuncionario: FuncionarioDetalhes;
    public novaContribuicaoSindical: CriarContribuicaoSindical = new CriarContribuicaoSindical();

    public formGroup = this.formBuilder.group({
        nomeSindicato: ['nomeSindicato', Validators.required],
        valorContribuicao: ['valorContribuicao', Validators.required],
        ano: ['ano', Validators.required]
    });

    public get nomeSindicato() { return this.formGroup.get('nomeSindicato'); }
    public get valorContribuicao() { return this.formGroup.get('valorContribuicao'); }
    public get ano() { return this.formGroup.get('ano'); }

    constructor(private empresaService: EmpresaService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private toasterService: ToastrService,
        private formBuilder: FormBuilder) { }

    ngOnInit(): void {
        this.selectedFuncionario = this.empresaService.recuperaFuncinarioSelecionado();
    }

    criarContribuicaoSindical() {
        this.ngxUiLoaderService.start();
        this.novaContribuicaoSindical.idContratoTrabalho = this.selectedFuncionario.idContratoTrabalho;
        this.empresaService.cadastrarContribuicaoSindical(this.novaContribuicaoSindical).subscribe(
            (sucesso) => {
                const mensagemSucesso = sucesso as MessageModel;
                this.toasterService.success(`Contribuição Sindical criado com sucesso para o Funcionário ${this.selectedFuncionario.nome}`, 'Sucesso');
                this.novaContribuicaoSindical = new CriarContribuicaoSindical();
            },
            (erro) => {
                const mensagemErro = erro as MessageModel;
                this.toasterService.error(mensagemErro.texto, 'Erro');
                this.ngxUiLoaderService.stop();
            },
            () => { this.ngxUiLoaderService.stop(); }
        );
    }
}
