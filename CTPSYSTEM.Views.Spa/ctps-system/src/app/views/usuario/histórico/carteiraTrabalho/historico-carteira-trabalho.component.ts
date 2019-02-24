import { Component, OnInit } from '@angular/core';
import { CarteiraTrabalho } from '../../../Models';

@Component({
    selector: 'app-historico-carteira-trabalho',
    templateUrl: './historico-carteira-trabalho.component.html',
    styleUrls: ['./historico-carteira-trabalho.component.scss']
})
export class HistoricoCarteiraTraballhoComponent implements OnInit {
    public carteiraTrabalhoList: Array<CarteiraTrabalho>;

    constructor() { }

    ngOnInit(): void {
        this.carteiraTrabalhoList = [
            {
                nomeFuncionario: 'Maycon Klopper de Carvalho',
                numero: 59181,
                serie: '176RJ',
                numeroDocumento: 'Ra: 29.313.980-4 19101112 DIC',
                dataEmissao: new Date('2013-02-22'),
                foto: '../../../assets/avatars/1.jpg',
                filiacaoPai: 'Marcio José de Carvalho',
                filiacaoMae: 'Fernanda Pereira Klopper de Carvalho',
                ativo: false
            },
            {
                nomeFuncionario: 'Maycon Klopper de Carvalho',
                numero: 56987,
                serie: '169RJ',
                numeroDocumento: 'Ra: 29.313.980-4 19101112 DIC',
                dataEmissao: new Date('2018-06-20'),
                foto: '../../../assets/avatars/1.jpg',
                filiacaoPai: 'Marcio José de Carvalho',
                filiacaoMae: 'Fernanda Pereira Klopper de Carvalho',
                ativo: false
            }
        ];
    }
}
