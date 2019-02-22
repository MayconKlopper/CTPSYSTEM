import { Component, OnInit } from '@angular/core';
import { Internacao } from '../../Models';

@Component({
    selector: 'app-internacao',
    templateUrl: './internacao.component.html',
    styleUrls: ['./internacao.component.scss']
})
export class InternacaoComponent implements OnInit {
    public internacaoList: Array<Internacao>;

    constructor() { }

    ngOnInit(): void {
        this.internacaoList = [
            {
                hospital: 'Hospital de icaraí',
                registro: 'h47f6gh47',
                matricula: '745836262',
                dataInternacao: new Date('2015-01-01'),
                dataAlta: new Date('2015-01-30')
            },
            {
                hospital: 'Hospital de São Gonçalo',
                registro: 'sadfas3423',
                matricula: '657643',
                dataInternacao: new Date('2018-10-01'),
                dataAlta: new Date('2015-11-30')
            }
        ];
     }
}
