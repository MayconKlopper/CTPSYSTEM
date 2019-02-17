import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-gerar-chave',
    templateUrl: './gerar-chave.component.html',
    styleUrls: ['./gerar-chave.component.scss']
})
export class GerarChaveComponent implements OnInit {
    chave = '';

    constructor() { }

    ngOnInit(): void { }

    private gerarChave() {
        this.chave = 'd41d8cd98f00b204e9800998ecf8427e';
    }
}
