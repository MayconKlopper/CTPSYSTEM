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
import { HistoricoCarteiraTraballhoComponent } from './views/usuario/histórico/carteiraTrabalho/historico-carteira-trabalho.component';
import { HistoricoEmpresaComponent } from './views/usuario/histórico/empresa/historico-empresa.component';
import { RegistrarCidadaoComponent } from './views/register/registrar-cidadao.component';
import { RegistrarEmpresarComponent } from './views/register/registrar-empresa.component';
import { FuncionarioComponent } from './views/empresa/funcionario/funcionario.component';
import { ListagemFuncionarioComponent } from './views/empresa/funcionario/listFuncionario/listagem-funcionario.component';
import { EmpresaComponent } from './views/funcionarioGoverno/Empresa/empresa.component';
import { ListagemEmpresaComponent } from './views/funcionarioGoverno/Empresa/listEmpresa/listagem-empresa.component';
import { CriarCarteiraTrabalhoComponent } from './views/funcionarioGoverno/carteiraTrabalho/criarCarteiraTrabalho/criar-carteira-trabalho.component';
import { CriarContratoTrabalhoComponent } from './views/empresa/contratoTrabalho/criarContratoTrabalho/criar-contrato-trabalho.component';
import { CriarContribuicaoSindicalComponent } from './views/empresa/contribuicaoSIndical/criarContribuicaoSIndical/criar-contribuicao-sindical.component';
import { CriarAlteracaoSalarialComponent } from './views/empresa/alteracaoSalarial/criarAlteracaoSalarial/criar-alteracao-salarial.component';
import { CriarFeriasComponent } from './views/empresa/ferias/criarFerias/criar-ferias.component';
import { CriarAnotacaoGeralComponent } from './views/empresa/anotacaoGeral/criarAnotacaoGeral/criar-anotacao-geral.component';
import { CriarFGTSComponent } from './views/empresa/FGTS/criarFGTS/criar-FGTS.component';
import { CriarLicencaComponent } from './views/empresa/licenca/criarLicenca/criar-licenca.component';
import { CriarInternacaoComponent } from './views/empresa/internacao/criarInternacao/criar-internacao.component';
import { VincularFuncionarioComponent } from './views/empresa/funcionario/vincularFuncionario/vincular-funcionario.component';
// import serviços aplicação
import { HttpClient } from '@angular/common/http';
import { UsuarioService } from './views/usuario/usuario.service';
import { AccountService } from './views/account.service';
import { JwtInterceptor } from './Helpers/jwt-interceptor.service';
import { ErrorInterceptor } from './Helpers/Error-interceptor.service';

// Import routing module
import { AppRoutingModule } from './app.routing';

// Import 3rd party components
import {NgxMaskModule} from 'ngx-mask';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { ChartsModule } from 'ng2-charts/ng2-charts';
import { CollapseModule } from 'ngx-bootstrap/collapse';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS  } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { InserirChaveComponent } from './views/empresa/inserirChave/inserir-chave.component';

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
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    NgxMaskModule.forRoot(),
    BrowserAnimationsModule,
    BsDatepickerModule.forRoot(),
    ToastrModule.forRoot({
      positionClass: 'toast-top-right',
      preventDuplicates: true,
      timeOut: 30000
    })
  ],
  declarations: [
    AppComponent,
    ...APP_CONTAINERS,
    P404Component,
    P500Component,
    LoginComponent,
    RegistrarCidadaoComponent,
    RegistrarEmpresarComponent,
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
    FGTSComponent,
    HistoricoCarteiraTraballhoComponent,
    HistoricoEmpresaComponent,
    FuncionarioComponent,
    ListagemFuncionarioComponent,
    EmpresaComponent,
    ListagemEmpresaComponent,
    CriarCarteiraTrabalhoComponent,
    CriarContratoTrabalhoComponent,
    CriarContribuicaoSindicalComponent,
    CriarAlteracaoSalarialComponent,
    CriarFGTSComponent,
    CriarFeriasComponent,
    CriarAnotacaoGeralComponent,
    CriarLicencaComponent,
    CriarInternacaoComponent,
    VincularFuncionarioComponent,
    InserirChaveComponent
  ],
  providers: [
    HttpClient,
    UsuarioService,
    AccountService,
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
    { provide: LocationStrategy, useClass: HashLocationStrategy }
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
