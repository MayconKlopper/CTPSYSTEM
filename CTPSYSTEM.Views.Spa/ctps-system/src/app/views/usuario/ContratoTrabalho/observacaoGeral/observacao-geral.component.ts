import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { UsuarioService } from '../../usuario.component.service';
import { ContratoTrabalho, AnotacaoGeral } from '../../../Models';

@Component({
    selector: 'app-observacao-geral',
    templateUrl: './observacao-geral.component.html',
    styleUrls: ['./observacao-geral.component.scss'],
    providers: [ UsuarioService ] 
})
export class ObservacaoGeralComponent implements OnInit {
    public contratoTrabalho: ContratoTrabalho;
    public anotacaoGeralList: Array<AnotacaoGeral>;

    constructor(private router: Router, private usuarioService: UsuarioService) { }

    ngOnInit(): void {
        if (!localStorage.getItem('selectedContratoTrabalho')) {
            this.router.navigate(['./contrato-trabalho']);
        }

        this.contratoTrabalho = this.usuarioService.getContratoTrabalho();

        this.anotacaoGeralList = [
            {
                id: 1,
                idContratoTrabalho: this.contratoTrabalho.id,
                texto: 'asdfasdfasdfasdfas'
            },
            {
                id: 2,
                idContratoTrabalho: this.contratoTrabalho.id,
                texto: 'sdgsdfgsdfgsdfgsdfgsdfgsdfgsdfgsdfgsdfgsdfgs'
            },
            {
                id: 3,
                idContratoTrabalho: this.contratoTrabalho.id,
                texto: 'sdfgsdfgsdfgsdfgsdfgsdfgsdfgsdfgfgsfgsfdgsdfgsdfgsfdgsdfgsdfgsdfgsdfgsdf'
            }
        ]
    }
}
