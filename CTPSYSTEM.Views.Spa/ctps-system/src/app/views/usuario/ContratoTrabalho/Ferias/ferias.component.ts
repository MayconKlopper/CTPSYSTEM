import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { ContratoTrabalho, Ferias } from '../../../Models';
import { UsuarioService } from '../../usuario.component.service';

@Component({
    selector: 'app-ferias',
    templateUrl: './ferias.component.html',
    styleUrls: ['./ferias.component.scss'],
    providers: [ UsuarioService ]
})
export class FeriasComponent implements OnInit {
    public contratoTrabalho: ContratoTrabalho;
    public feriasList: Array<Ferias>;

    constructor(private router: Router, private usuarioService: UsuarioService) { }

    ngOnInit(): void {
        if (!localStorage.getItem('selectedContratoTrabalho')) {
            this.router.navigate(['./contrato-trabalho']);
        }

        this.contratoTrabalho = this.usuarioService.getContratoTrabalho();

        this.feriasList = [
            {
                id: 1,
                idContratoTrabalho: this.contratoTrabalho.id,
                periodoRelativo: '21/01/2017 - 21/01/2018',
                dataInicio: new Date('2018-01-22'),
                dataTermino: new Date('2018-02-22'),
                dias: 30
            },
            {
                id: 2,
                idContratoTrabalho: this.contratoTrabalho.id,
                periodoRelativo: '23/02/2018 - 23/02/2019',
                dataInicio: new Date('2019-02-24'),
                dataTermino: new Date('2019-03-24'),
                dias: 30
            },
            {
                id: 3,
                idContratoTrabalho: this.contratoTrabalho.id,
                periodoRelativo: '25/03/2019 - 25/03/2020',
                dataInicio: new Date('2020-03-26'),
                dataTermino: new Date('2020-04-26'),
                dias: 30
            }
        ]
     }
}
