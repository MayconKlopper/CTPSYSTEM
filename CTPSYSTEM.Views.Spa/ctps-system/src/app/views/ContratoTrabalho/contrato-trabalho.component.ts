import { Component, OnInit } from '@angular/core';
import { ContratoTrabalho } from '../Models';

@Component({
    selector: 'app-contrato-trabalho',
    templateUrl: './contrato-trabalho.component.html',
    styleUrls: ['./contrato-trabalho.component.scss']
})
export class ContratoTrabalhoComponent implements OnInit {
    public contratoTrabalhoList: Array<ContratoTrabalho>;

    constructor() { }

    ngOnInit(): void {
        this.contratoTrabalhoList = [
            {
                id: 1,
                idEmpresa: 1,
                cargo: 'Vendedor',
                CBONumero: 521105,
                dataAdmissao: new Date('2013-10-01'),
                dataSaida: new Date('2014-09-30'),
                remuneracao: 678.00,
                remuneracaoExtenso: 'seiscentos e setenta e oito reais',
                flsFicha: 0,
                registroNumero: 0,
                ativo: false
            },
            {
                id: 2,
                idEmpresa: 2,
                cargo: 'Programador júnior',
                CBONumero: 0,
                dataAdmissao: new Date('2016-03-14'),
                dataSaida: new Date('2017-07-11'),
                remuneracao: 1900.00,
                remuneracaoExtenso: 'um mil e novecentos reais',
                flsFicha: 0,
                registroNumero: 0,
                ativo: false
            },
            {
                id: 3,
                idEmpresa: 3,
                cargo: 'Programador',
                CBONumero: 317110,
                dataAdmissao: new Date('2017-07-12'),
                dataSaida: new Date('2019-01-11'),
                remuneracao: 2000.00,
                remuneracaoExtenso: 'Dois mil Reais',
                flsFicha: 0,
                registroNumero: 0,
                ativo: false
            },
            {
                id: 4,
                idEmpresa: 4,
                cargo: 'Analista de Sistemas júnior 4',
                CBONumero: 212405,
                dataAdmissao: new Date('2019-01-21'),
                dataSaida: null,
                remuneracao: 5000.00,
                remuneracaoExtenso: 'Cinco Mil Reais',
                flsFicha: 0,
                registroNumero: 0,
                ativo: true
            }
        ];
     }
}
