import { Component, OnInit } from '@angular/core';
import { EmpresaHistorico, EstadoSigla } from '../../../Models';

@Component({
    selector: 'app-historico-empresa',
    templateUrl: './historico-empresa.component.html',
    styleUrls: ['./historico-empresa.component.scss']
})
export class HistoricoEmpresaComponent implements OnInit {
    public historicoEmpresaList: Array<EmpresaHistorico>;

    constructor() { }

    ngOnInit(): void {
        this.historicoEmpresaList = [
            {
                CNPJ: '14.461.349/0001-35',
                nomeFantasia: 'Pedro Pla Homedes Neto Fotografia ME',
                razaoSocial: 'Pedro Pla Homedes Neto Fotografia ME',
                data: new Date('2014/09/30'),
                seguimento: 'Comércio varejista de artigos fotográficos',
                estado: 'Rio de janeiro',
                siglaEstado: EstadoSigla.RJ,
                cidade: 'Niterói',
                rua: 'Gavião Peixoto',
                numero: 71,
                sala: ''
            },
            {
                CNPJ: '12.281.988/0001-93',
                nomeFantasia: 'Valorem Empreendimentos e Serviços LTDA',
                razaoSocial: 'Valorem Empreendimentos e Serviços LTDA',
                data: new Date('2017/07/11'),
                seguimento: '',
                estado: 'Rio de janeiro',
                siglaEstado: EstadoSigla.RJ,
                cidade: 'Niterói',
                rua: 'Rua Visconde de Itaboraí',
                numero: 166,
                sala: '401'
            },
            {
                CNPJ: '14.826.912/0001-21',
                nomeFantasia: 'OG Intcom Soluções em TI S.A',
                razaoSocial: 'OG Intcom Soluções em TI S.A',
                data: new Date('2019/01/11'),
                seguimento: '',
                estado: 'Rio de janeiro',
                siglaEstado: EstadoSigla.RJ,
                cidade: 'Rio de Janeiro',
                rua: 'Av Pastor Martin Luther King',
                numero: 126,
                sala: 'Bloco 09; Torre 02'
            }
        ];
    }
}
