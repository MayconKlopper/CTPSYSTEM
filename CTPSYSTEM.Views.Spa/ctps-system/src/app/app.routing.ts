import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// Import Containers
import { DefaultLayoutComponent } from './containers';

import { P404Component } from './views/error/404.component';
import { P500Component } from './views/error/500.component';
import { LoginComponent } from './views/login/login.component';

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
import { HistoricoCarteiraTraballhoComponent } from './views/usuario/histórico/carteiraTrabalho/historico-carteira-trabalho.component';
import { HistoricoEmpresaComponent } from './views/usuario/histórico/empresa/historico-empresa.component';
import { RegistrarCidadaoComponent } from './views/register/registrar-cidadao.component';
import { RegistrarEmpresarComponent } from './views/register/registrar-empresa.component';
import { ListagemFuncionarioComponent } from './views/empresa/funcionario/listFuncionario/listagem-funcionario.component';
import { ListagemEmpresaComponent } from './views/funcionarioGoverno/Empresa/listEmpresa/listagem-empresa.component';
import { CriarCarteiraTrabalhoComponent } from './views/funcionarioGoverno/carteiraTrabalho/criarCarteiraTrabalho/criar-carteira-trabalho.component';
import { CriarContratoTrabalhoComponent } from './views/empresa/contratoTrabalho/criarContratoTrabalho/criar-contrato-trabalho.component';
import { CriarContribuicaoSindicalComponent } from './views/empresa/contribuicaoSIndical/criarContribuicaoSIndical/criar-contribuicao-sindical.component';
import { CriarAlteracaoSalarialComponent } from './views/empresa/alteracaoSalarial/criarAlteracaoSalarial/criar-alteracao-salarial.component';
import { CriarFeriasComponent } from './views/empresa/ferias/criarFerias/criar-ferias.component';
import { CriarAnotacaoGeralComponent } from './views/empresa/anotacaoGeral/criarAnotacaoGeral/criar-anotacao-geral.component';
import { CriarLicencaComponent } from './views/empresa/licenca/criarLicenca/criar-licenca.component';
import { CriarInternacaoComponent } from './views/empresa/internacao/criarInternacao/criar-internacao.component';
import { VincularFuncionarioComponent } from './views/empresa/funcionario/vincularFuncionario/vincular-funcionario.component';
import { CriarFGTSComponent } from './views/empresa/FGTS/criarFGTS/criar-FGTS.component';
import { GuardService } from './views/guard/guard.service';
import { HashGuardService } from './views/guard/HashGuard.service';
import { InserirChaveComponent } from './views/empresa/inserirChave/inserir-chave.component';
import { HistoricoFuncionarioComponent } from './views/empresa/funcionario/historico/historico-funcionario';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'login',
    pathMatch: 'full'
  },
  {
    path: '404',
    component: P404Component,
    data: { title: 'Page 404' }
  },
  {
    path: '500',
    component: P500Component,
    data: { title: 'Page 500' }
  },
  {
    path: 'login',
    component: LoginComponent,
    data: { title: 'Login Page' }
  },
  {
    path: 'registrar-cidadao',
    component: RegistrarCidadaoComponent,
    data: { title: 'Registrar Cidadão' }
  },
  {
    path: 'registrar-empresa',
    component: RegistrarEmpresarComponent,
    data: { title: 'Registrar Empresa' }
  },
  {
    path: '',
    component: DefaultLayoutComponent,
    data: { title: 'Home' },
    canActivate: [GuardService],
    children: [
      { path: 'home', component: HomeComponent },
      // Rotas do perfil de usuário
      { path: 'gerar-chave', component: GerarChaveComponent, data: { title: 'Gerar Chave de Acesso' } },
      { path: 'licencas', component: LicencaComponent, data: { title: 'Licenças' } },
      { path: 'internacoes', component: InternacaoComponent, data: { title: 'Internações' } },
      {
        path: 'historico', data: { title: 'Histórico' },
        children: [
          {
            path: '',
            children: [
              { path: '', component: HistoricoCarteiraTraballhoComponent },
              // tslint:disable-next-line:max-line-length
              { path: 'carteira-trabalho', component: HistoricoCarteiraTraballhoComponent, data: { title: 'Histórico de Carteiras de Trabalho' } },
              { path: 'empresa', component: HistoricoEmpresaComponent, data: { title: 'Histórico de Empresas' } }
            ]
          }
        ]
      },
      {
        path: 'contrato-trabalho', data: { title: 'Contratos de Trabalho' },
        children: [
          {
            path: '',
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
      },
      // Rotas do perfil de empresa
      {
        path: 'inserir-chave',
        component: InserirChaveComponent,
        data: { title: 'Inserir Chave' }
      },
      {
        path: 'listagem-funcionario',
        component: ListagemFuncionarioComponent,
        data: { title: 'Listagem de funcionários' }
      },
      {
        path: 'criar-contrato-trabalho',
        canActivate: [HashGuardService],
        component: CriarContratoTrabalhoComponent,
        data: { title: 'Cadastrar Contrato de Trabalho' }
      },
      {
        path: 'criar-contribuicao-sindical',
        canActivate: [HashGuardService],
        component: CriarContribuicaoSindicalComponent,
        data: { title: 'Cadastrar Contribuição SIndical' }
      },
      {
        path: 'criar-alteracao-salarial',
        canActivate: [HashGuardService],
        component: CriarAlteracaoSalarialComponent,
        data: { title: 'Cadastrar Alteração Salarial' }
      },
      {
        path: 'criar-ferias',
        canActivate: [HashGuardService],
        component: CriarFeriasComponent,
        data: { title: 'Cadastrar Férias' }
      },
      {
        path: 'criar-anotacao-geral',
        canActivate: [HashGuardService],
        component: CriarAnotacaoGeralComponent,
        data: { title: 'Cadastrar Anotação Geral' }
      },
      {
        path: 'criar-FGTS',
        canActivate: [HashGuardService],
        component: CriarFGTSComponent,
        data: { title: 'Cadastrar FGTS' }
      },
      {
        path: 'criar-licenca',
        canActivate: [HashGuardService],
        component: CriarLicencaComponent,
        data: { title: 'Cadastrar Licença' }
      },
      {
        path: 'criar-internacao',
        canActivate: [HashGuardService],
        component: CriarInternacaoComponent,
        data: { title: 'Cadastrar Internação' }
      },
      {
        path: 'vincular-funcionario',
        component: VincularFuncionarioComponent,
        data: { title: 'Vincular Funcionário' }
      },
      {
        path: 'historico-funcionario',
        component: HistoricoFuncionarioComponent,
        data: { title: 'Histórico de Funcionários' }
      },
      // Rotas do perfil de Funcionario do governo
      {
        path: 'listagem-empresa',
        component: ListagemEmpresaComponent,
        data: { title: 'Listagm de Empresas' }
      },
      {
        path: 'cadastrar-CTPS',
        component: CriarCarteiraTrabalhoComponent,
        data: { title: 'Cadastrar CTPS' }
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
