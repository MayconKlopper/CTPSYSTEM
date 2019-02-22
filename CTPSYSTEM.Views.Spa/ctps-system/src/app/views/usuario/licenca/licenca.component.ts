import { Component, OnInit } from '@angular/core';
import { Licenca } from '../../Models';

@Component({
    selector: 'app-licenca',
    templateUrl: './licenca.component.html',
    styleUrls: ['./licenca.component.scss']
})
export class LicencaComponent implements OnInit {
public licencaList: Array<Licenca>;

    constructor() {

     }

    ngOnInit(): void {
        this.licencaList = [
            {   dataInicio: new Date('01/01/2019'),
                dataTermino: new Date('01/10/2019'),
                dias: 10,
                codigoPosto: 58986,
                motivo: ''
            },
            {   dataInicio: new Date('10/10/2015'),
                dataTermino: new Date('10/20/2015'),
                dias: 10,
                codigoPosto: 6898784,
                // tslint:disable-next-line:max-line-length
                motivo: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.'
            }
        ];
     }
}
