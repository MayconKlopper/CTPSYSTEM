import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { UsuarioService } from '../../usuario.component.service';
import { ContratoTrabalho, AlteracaoSalarial } from '../../../Models';

@Component({
    selector: 'app-alteracao-salarial',
    templateUrl: './alteracao-salarial.component.html',
    styleUrls: ['./alteracao-salarial.component.scss'],
    providers: [ UsuarioService ]
})
export class AlteracaoSalarialComponent implements OnInit {
    public contratoTrabalho: ContratoTrabalho;
    public alteracaoSalarialList: Array<AlteracaoSalarial>;

    constructor(private router: Router, private usuarioService: UsuarioService) { }

    ngOnInit(): void {
        if (!localStorage.getItem('selectedContratoTrabalho')) {
            this.router.navigate(['./contrato-trabalho']);
        }

        this.contratoTrabalho = this.usuarioService.getContratoTrabalho();

        this.alteracaoSalarialList = [
            {
                id: 1,
                idContratoTrabalho: this.contratoTrabalho.id,
                dataAumento: new Date('2017-03-10'),
                remuneracao: 5120.97,
                remuneracaoExtenso: 'cinco mil cento e vinte reais e noventa e sete centavos',
                cargo: 'ANALISTA JUNIOR 4',
                motivo: 'Dissídio anual'
            },
            {
                id: 2,
                idContratoTrabalho: this.contratoTrabalho.id,
                dataAumento: new Date('2018-03-10'),
                remuneracao: 5400.00,
                remuneracaoExtenso: 'cinco mil e quatrocentos',
                cargo: 'ANALISTA JUNIOR 4',
                motivo: 'Dissídio anual'
            },
            {
                id: 3,
                idContratoTrabalho: this.contratoTrabalho.id,
                dataAumento: new Date('2019-10-05'),
                remuneracao: 7000.00,
                remuneracaoExtenso: 'sete mil reais',
                cargo: 'ANALISTA PLANO 1',
                motivo: 'Promoção'
            }
        ]
    }
}
