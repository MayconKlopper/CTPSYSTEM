import { Component, OnInit } from '@angular/core';
import { EmpresaDetalhes, EstadoSigla } from '../../../Models';

@Component({
    selector: 'app-listagem-empresa',
    templateUrl: './listagem-empresa.component.html'
})
export class ListagemEmpresaComponent implements OnInit {
    public empresaList: Array<EmpresaDetalhes>;

    constructor() { }

    ngOnInit(): void {
        this.empresaList = [
            {
                id: 1,
                CNPJ: '88391514000166',
                nomeFantasia: 'MKC Software',
                razaoSocial: 'MKC Software',
                seguimento: 'Desenvolvimento de Software',
                estado: 'Rio de janeiro',
                siglaEstado: EstadoSigla.RJ,
                cidade: 'São Gonçalo',
                rua: 'Rua Raul Silva',
                numero: 230,
                sala: '1995'
            },
            {
                id: 2,
                CNPJ: '95260274000126',
                nomeFantasia: 'Clara e Isaac Marketing Ltda',
                razaoSocial: 'Clara e Isaac Marketing Ltda',
                seguimento: 'Marketing',
                estado: 'São Paulo',
                siglaEstado: EstadoSigla.SP,
                cidade: 'Piracicaba',
                rua: 'Rua Aristides Balbino',
                numero: 560,
                sala: '1302'
            },
            {
                id: 3,
                CNPJ: '79385057000106',
                nomeFantasia: 'Emanuel e Lorena Advocacia Ltda',
                razaoSocial: 'Emanuel e Lorena Advocacia Ltda',
                seguimento: 'Advocacia',
                estado: 'Rio Grande do Norte',
                siglaEstado: EstadoSigla.RN,
                cidade: 'Sítio Novo',
                rua: 'Rua José Ferreira de Lima 51-A',
                numero: 157,
                sala: '119'
            }
        ];
    }
}
