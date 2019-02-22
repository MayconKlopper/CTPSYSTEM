import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { ContratoTrabalho, ContribuicaoSindical } from '../../../Models';
import { UsuarioService } from '../../usuario.component.service';

@Component({
    selector: 'app-contribuicao-sindical',
    templateUrl: './contribuicao-sindical.component.html',
    styleUrls: ['./contribuicao-sindical.component.scss'],
    providers: [ UsuarioService ]
})
export class ContribuicaoSindicalComponent implements OnInit {
    public contratoTrabalho: ContratoTrabalho;
    public contribuicaoSindicalList: Array<ContribuicaoSindical>;

    constructor(private router: Router, private usuarioService: UsuarioService) { }

    ngOnInit(): void {
        if (!localStorage.getItem('selectedContratoTrabalho')) {
            this.router.navigate(['./contrato-trabalho']);
        }

        this.contratoTrabalho = this.usuarioService.getContratoTrabalho();

        this.contribuicaoSindicalList = [
            {
                id: 1,
                idContratoTrabalho: this.contratoTrabalho.id,
                valorContribuicao: 280.90,
                nomeSindicato: 'Sindicato dos sugadores de dinheiro',
                ano: 2019
            },
            {
                id: 2,
                idContratoTrabalho: this.contratoTrabalho.id,
                valorContribuicao: 200.60,
                nomeSindicato: 'Sindicato dos sugadores de dinheiro',
                ano: 2018
            },
            {
                id: 3,
                idContratoTrabalho: this.contratoTrabalho.id,
                valorContribuicao: 126.66,
                nomeSindicato: 'Sindicato dos sugadores de dinheiro',
                ano: 2017
            }
        ]
     }
}
