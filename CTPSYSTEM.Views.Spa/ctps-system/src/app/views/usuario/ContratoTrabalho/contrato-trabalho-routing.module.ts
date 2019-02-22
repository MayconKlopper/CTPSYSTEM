import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';

import { ContratoTrabalhoComponent } from './contrato-trabalho.component';
import { ContribuicaoSindicalComponent } from './ContribuicaoSindical/contribuicao-sindical.component';
import { AlteracaoSalarialComponent } from './AlteracaoSalarial/alteracao-salarial.component';
import { FeriasComponent } from './Ferias/ferias.component';
import { FGTSComponent } from './FGTS/fgts.component';
import { ObservacaoGeralComponent } from './observacaoGeral/observacao-geral.component';

const routes: Routes = [
    { path: '', component: ContratoTrabalhoComponent, data: { title: 'Contratos de Trabalho' }   },
    { path: 'contribuicao-sindical', component: ContribuicaoSindicalComponent, data: { title: 'Contribuições Sindicais' } },
    { path: 'alteracao-salarial', component: AlteracaoSalarialComponent, data: { title: 'Alterações Salariais' } },
    { path: 'ferias', component: FeriasComponent, data: { title: 'Férias' } },
    { path: 'fgts', component: FGTSComponent, data: { title: 'FGTS' } },
    { path: 'observacao-geral', component: ObservacaoGeralComponent, data: { title: 'Observações Gerais' } },

    //{ path: 'path/:routeParam', component: MyComponent },
    //{ path: 'staticPath', component: ... },
    //{ path: '**', component: ... },
    //{ path: 'oldPath', redirectTo: '/staticPath' },
    //{ path: ..., component: ..., data: { message: 'Custom' }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class ContratoTrabalhoRoutingModule {}
