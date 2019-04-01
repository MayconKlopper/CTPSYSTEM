import { Component, OnInit, Input } from '@angular/core';

import { EmpresaDetalhes } from '../../Models';

@Component({
    selector: 'app-empresa',
    templateUrl: './empresa.component.html'
})
export class EmpresaComponent implements OnInit {
    @Input() empresa: EmpresaDetalhes;

    constructor() { }

    ngOnInit(): void { }
}
