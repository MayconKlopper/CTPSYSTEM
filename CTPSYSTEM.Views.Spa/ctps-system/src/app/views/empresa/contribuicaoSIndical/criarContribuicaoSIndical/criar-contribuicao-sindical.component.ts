import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

import { FuncionarioDetalhes,
    CriarContribuicaoSindical,
    MessageModel} from '../../../Models';
import { EmpresaService } from '../../empresa.service';

@Component({
    selector: 'app-criar-contribuicao-sindical',
    templateUrl: './criar-contribuicao-sindical.component.html'
})
export class CriarContribuicaoSindicalComponent implements OnInit {
    private selectedFuncionario: FuncionarioDetalhes;
    public novaContribuicaoSindical: CriarContribuicaoSindical = new CriarContribuicaoSindical;

    public formGroup = this.formBuilder.group({
        nomeSindicato: ['nomeSindicato', Validators.required],
        valorContribuicao: ['valorContribuicao', Validators.required],
        ano: ['ano', Validators.required]
    });

    public get nomeSindicato() { return this.formGroup.get('nomeSindicato'); }
    public get valorContribuicao() { return this.formGroup.get('valorContribuicao'); }
    public get ano() { return this.formGroup.get('ano'); }

    constructor(private empresaService: EmpresaService,
        private toasterService: ToastrService,
        private formBuilder: FormBuilder) { }

    ngOnInit(): void {
        this.selectedFuncionario = this.empresaService.recuperaFuncinarioSelecionado();
    }

    criarContribuicaoSindical() {
        debugger
        this.novaContribuicaoSindical.idContratoTrabalho = this.selectedFuncionario.idContratoTrabalho;
        this.empresaService.cadastrarContribuicaoSindical(this.novaContribuicaoSindical).subscribe(
            (sucesso) => {
                const mensagemSucesso = sucesso as MessageModel;
                this.toasterService.success(`Contribuição Sindical criado com sucesso para o Funcionário ${this.selectedFuncionario.nome}`, 'Sucesso');
            },
            (erro) => {
                const mensagemErro = erro as MessageModel;
                this.toasterService.error(mensagemErro.texto, 'Erro');
            }
        );
    }
}
