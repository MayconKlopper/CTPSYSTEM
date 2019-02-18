import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// Import Containers
import { DefaultLayoutComponent } from './containers';

import { P404Component } from './views/error/404.component';
import { P500Component } from './views/error/500.component';
import { LoginComponent } from './views/login/login.component';
import { RegisterComponent } from './views/register/register.component';

// Componentes da aplicação
import { GerarChaveComponent } from './views/GerarChave/gerar-chave.component';
import { HomeComponent } from './views/Home/home.component';
import { LicencaComponent } from './views/licenca/licenca.component';
import { InternacaoComponent } from './views/Internacao/internacao.component';
import { ListContratoTrabalhoComponent } from './views/ContratoTrabalho/ListContratoTrabalho/list-contrato-trabalho.component';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'home',
    pathMatch: 'full',
  },
  {
    path: '404',
    component: P404Component,
    data: {
      title: 'Page 404'
    }
  },
  {
    path: '500',
    component: P500Component,
    data: {
      title: 'Page 500'
    }
  },
  {
    path: 'login',
    component: LoginComponent,
    data: {
      title: 'Login Page'
    }
  },
  {
    path: 'register',
    component: RegisterComponent,
    data: {
      title: 'Register Page'
    }
  },
  {
    path: '',
    component: DefaultLayoutComponent,
    data: {
      title: 'Home'
    },
    children: [
      {
        path: 'home',
        component: HomeComponent
      },
      {
        path: 'gerar-chave',
        component: GerarChaveComponent,
        data: {
          title: 'Gerar Chave de Acesso'
        }
      },
      {
        path: 'licencas',
        component: LicencaComponent,
        data: {
          title: 'Licenças'
        }
      },
      {
        path: 'internacoes',
        component: InternacaoComponent,
        data: {
          title: 'Internações'
        }
      },
      {
        path: 'contrato-trabalho',
        component: ListContratoTrabalhoComponent,
        data: {
          title: 'Contratos de Trabalho'
        },
        children: [

        ]
      }
    ]
  },
  { path: '**', component: P404Component }
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule {}
