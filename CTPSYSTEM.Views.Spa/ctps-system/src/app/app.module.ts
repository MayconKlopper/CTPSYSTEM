import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { LocationStrategy, HashLocationStrategy, CommonModule } from '@angular/common';

import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';
import { PERFECT_SCROLLBAR_CONFIG } from 'ngx-perfect-scrollbar';
import { PerfectScrollbarConfigInterface } from 'ngx-perfect-scrollbar';

const DEFAULT_PERFECT_SCROLLBAR_CONFIG: PerfectScrollbarConfigInterface = {
  suppressScrollX: true
};

import { AppComponent } from './app.component';

// Import containers
import { DefaultLayoutComponent } from './containers';

import { P404Component } from './views/error/404.component';
import { P500Component } from './views/error/500.component';
import { LoginComponent } from './views/login/login.component';
import { RegisterComponent } from './views/register/register.component';

const APP_CONTAINERS = [
  DefaultLayoutComponent
];

import {
  AppAsideModule,
  AppBreadcrumbModule,
  AppHeaderModule,
  AppFooterModule,
  AppSidebarModule
} from '@coreui/angular';

// Imports da aplicação
import { HomeComponent } from './views/Home/home.component';
import { GerarChaveComponent } from './views/usuario/GerarChave/gerar-chave.component';
import { LicencaComponent } from './views/usuario/licenca/licenca.component';
import { InternacaoComponent } from './views/usuario/Internacao/internacao.component';
import { ContratoTrabalhoComponent } from './views/usuario/ContratoTrabalho/contrato-trabalho.component';
import { ListContratoTrabalhoComponent } from './views/usuario/ContratoTrabalho/ListContratoTrabalho/list-contrato-trabalho.component';
import { CarteiraTrabalhoComponent } from './views/usuario/carteiraTrabalho/carteira-trabalho.component';
import { ContribuicaoSindicalComponent } from './views/usuario/ContratoTrabalho/ContribuicaoSindical/contribuicao-sindical.component';
import { AlteracaoSalarialComponent } from './views/usuario/ContratoTrabalho/AlteracaoSalarial/alteracao-salarial.component';
import { ObservacaoGeralComponent } from './views/usuario/ContratoTrabalho/observacaoGeral/observacao-geral.component';
import { FeriasComponent } from './views/usuario/ContratoTrabalho/Ferias/ferias.component';
import { FGTSComponent } from './views/usuario/ContratoTrabalho/FGTS/fgts.component';

// Import routing module
import { AppRoutingModule } from './app.routing';

// Import 3rd party components
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { ChartsModule } from 'ng2-charts/ng2-charts';
import { CollapseModule } from 'ngx-bootstrap/collapse';

@NgModule({
  imports: [
    BrowserModule,
    AppRoutingModule,
    AppAsideModule,
    AppBreadcrumbModule.forRoot(),
    AppFooterModule,
    AppHeaderModule,
    AppSidebarModule,
    PerfectScrollbarModule,
    BsDropdownModule.forRoot(),
    TabsModule.forRoot(),
    ChartsModule,
    CollapseModule,
    CommonModule,
  ],
  declarations: [
    AppComponent,
    ...APP_CONTAINERS,
    P404Component,
    P500Component,
    LoginComponent,
    RegisterComponent,
    GerarChaveComponent,
    HomeComponent,
    LicencaComponent,
    InternacaoComponent,
    ContratoTrabalhoComponent,
    ListContratoTrabalhoComponent,
    CarteiraTrabalhoComponent,
    ContribuicaoSindicalComponent,
    AlteracaoSalarialComponent,
    ObservacaoGeralComponent,
    FeriasComponent,
    FGTSComponent
  ],
  providers: [
    { provide: LocationStrategy, useClass: HashLocationStrategy }
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
