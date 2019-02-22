import { Component, OnInit, Input } from '@angular/core';
import { Router } from '@angular/router';
import { ContratoTrabalho } from '../../Models';
import { routerNgProbeToken } from '@angular/router/src/router_module';

@Component({
    selector: 'app-contrato-trabalho',
    templateUrl: './contrato-trabalho.component.html',
    styleUrls: ['./contrato-trabalho.component.scss']
})
export class ContratoTrabalhoComponent implements OnInit {
    @Input() public contratoTrabalho: ContratoTrabalho;
    @Input() public showSelectButton = false;

    constructor(private router: Router) { }

    ngOnInit(): void {

     }

    public selectContratoTrabalho(selectedContratoTrabalho: ContratoTrabalho) {
        localStorage.setItem('selectedContratoTrabalho', JSON.stringify(selectedContratoTrabalho));
        this.router.navigate(['./contrato-trabalho/contribuicao-sindical']);
    }
}
