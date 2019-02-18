import { Component, OnInit, Input } from '@angular/core';
import { ContratoTrabalho } from '../Models';

@Component({
    selector: 'app-contrato-trabalho',
    templateUrl: './contrato-trabalho.component.html',
    styleUrls: ['./contrato-trabalho.component.scss']
})
export class ContratoTrabalhoComponent implements OnInit {
    @Input() public contratoTrabalho: ContratoTrabalho;

    constructor() { }

    ngOnInit(): void {

     }
}
