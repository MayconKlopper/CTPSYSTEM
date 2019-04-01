import { Component, OnInit, Input } from '@angular/core';
import { Router } from '@angular/router';
import { ContratoTrabalhoDetalhes } from '../../Models';
import { ToastrService } from 'ngx-toastr';

@Component({
    selector: 'app-contrato-trabalho',
    templateUrl: './contrato-trabalho.component.html'
})
export class ContratoTrabalhoComponent implements OnInit {
    @Input() public contratoTrabalho: ContratoTrabalhoDetalhes;
    @Input() public showSelectButton = false;

    constructor(private router: Router,
        private toasterService: ToastrService) { }

    ngOnInit(): void {

     }

    public selectContratoTrabalho() {
        localStorage.setItem('selectedContratoTrabalho', JSON.stringify(this.contratoTrabalho));
        this.router.navigate(['./contrato-trabalho/contribuicao-sindical']);
        // tslint:disable-next-line:max-line-length
        this.toasterService.info(`Contrato de trabalho ${this.contratoTrabalho.cargo} - ${this.contratoTrabalho.nomeEmpresa} selecionado`, 'Informação');
    }
}
