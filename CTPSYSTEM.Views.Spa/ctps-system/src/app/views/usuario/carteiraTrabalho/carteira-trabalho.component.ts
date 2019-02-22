import { Component, OnInit, Input } from '@angular/core';
import { CarteiraTrabalho } from '../../Models';

@Component({
    selector: 'app-carteira-trabalho',
    templateUrl: './carteira-trabalho.component.html',
    styleUrls: ['./carteira-trabalho.component.scss']
})
export class CarteiraTrabalhoComponent implements OnInit {
    @Input() public carteiraTrabalho: CarteiraTrabalho;

    constructor() { }

    ngOnInit(): void { }
}
