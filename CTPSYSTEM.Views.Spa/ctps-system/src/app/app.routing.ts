import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// Import Containers
import { DefaultLayoutComponent } from './containers';

import { P404Component } from './views/error/404.component';
import { P500Component } from './views/error/500.component';
import { LoginComponent } from './views/login/login.component';
import { RegisterComponent } from './views/register/register.component';

// Componentes da aplicação
import { GerarChaveComponent } from './views/usuario/GerarChave/gerar-chave.component';
import { HomeComponent } from './views/Home/home.component';
import { LicencaComponent } from './views/usuario/licenca/licenca.component';
import { InternacaoComponent } from './views/usuario/Internacao/internacao.component';
import { ListContratoTrabalhoComponent } from './views/usuario/ContratoTrabalho/ListContratoTrabalho/list-contrato-trabalho.component';
import { ContribuicaoSindicalComponent } from './views/usuario/ContratoTrabalho/ContribuicaoSindical/contribuicao-sindical.component';
import { AlteracaoSalarialComponent } from './views/usuario/ContratoTrabalho/AlteracaoSalarial/alteracao-salarial.component';
import { FeriasComponent } from './views/usuario/ContratoTrabalho/Ferias/ferias.component';
import { FGTSComponent } from './views/usuario/ContratoTrabalho/FGTS/fgts.component';
import { ObservacaoGeralComponent } from './views/usuario/ContratoTrabalho/observacaoGeral/observacao-geral.component';

export const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full', },
  { path: '404', component: P404Component, data: { title: 'Page 404' } },
  { path: '500', component: P500Component, data: { title: 'Page 500' } },
  { path: 'login', component: LoginComponent, data: { title: 'Login Page' } },
  { path: 'register', component: RegisterComponent, data: { title: 'Register Page' } },
  { path: '', component: DefaultLayoutComponent, data: { title: 'Home' },
    children: [
      { path: 'home', component: HomeComponent },
      { path: 'gerar-chave', component: GerarChaveComponent, data: { title: 'Gerar Chave de Acesso' } },
      { path: 'licencas', component: LicencaComponent, data: { title: 'Licenças' } },
      { path: 'internacoes', component: InternacaoComponent, data: { title: 'Internações' } },
      { path: 'contrato-trabalho', data: { title: 'Contratos de Trabalho' },
        children: [
          { path: '',
            children: [
              { path: '', component: ListContratoTrabalhoComponent },
              { path: 'contribuicao-sindical', component: ContribuicaoSindicalComponent, data: { title: 'Contribuições Sindicais' } },
              { path: 'alteracao-salarial', component: AlteracaoSalarialComponent, data: { title: 'Alterações Salariais' } },
              { path: 'ferias', component: FeriasComponent, data: { title: 'Férias' } },
              { path: 'fgts', component: FGTSComponent, data: { title: 'FGTS' } },
              { path: 'observacao-geral', component: ObservacaoGeralComponent, data: { title: 'Observações Gerais' } }
            ]
          },
        ]
      }
    ]
  },
  { path: '**', component: P404Component }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
