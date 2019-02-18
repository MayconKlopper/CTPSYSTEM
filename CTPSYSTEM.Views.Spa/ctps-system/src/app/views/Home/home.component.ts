import { Component, OnInit } from '@angular/core';
import { CarteiraTrabalho } from '../Models';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
    public collapseOne = true;
    public collapseTwo = true;
    public collapseThree = true;
    public collapseFour = true;
    public carteiraTrabalho: CarteiraTrabalho;

    constructor() { }

    ngOnInit(): void {
        this.carteiraTrabalho = {
            nomeFuncionario: 'Maycon Klopper de Carvalho',
            numero: 59181,
            serie: '176RJ',
            numeroDocumento: 'Ra: 29.313.980-4 19101112 DIC',
            dataEmissao: new Date('2013-02-22'),
            foto: '../../../assets/avatars/1.jpg',
            filiacaoPai: 'Marcio José de Carvalho',
            filiacaoMae: 'Fernanda Pereira Klopper de Carvalho',
            ativo: true
        };
     }
}
