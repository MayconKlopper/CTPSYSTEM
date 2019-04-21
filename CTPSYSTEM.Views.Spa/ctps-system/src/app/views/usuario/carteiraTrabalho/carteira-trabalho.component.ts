import { Component, OnInit, Input } from '@angular/core';
import { CarteiraTrabalhoDetalhes } from '../../Models';

@Component({
    selector: 'app-carteira-trabalho',
    templateUrl: './carteira-trabalho.component.html'
})
export class CarteiraTrabalhoComponent implements OnInit {
    @Input() public carteiraTrabalho: CarteiraTrabalhoDetalhes;

    constructor() { }

    ngOnInit(): void { }
}
