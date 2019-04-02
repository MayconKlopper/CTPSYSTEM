export interface NavData {
  name?: string;
  url?: string;
  icon?: string;
  badge?: any;
  title?: boolean;
  children?: any;
  variant?: string;
  attributes?: object;
  divider?: boolean;
  class?: string;
}

export const navUsuario: NavData[] = [
  {
    name: 'CTPS System',
    url: '/home',
    icon: 'icon-notebook'
  },
  {
    title: true,
    name: 'CTPS'
  },
  {
    name: 'Gerar Chave',
    url: '/gerar-chave',
    icon: 'icon-key'
  },
  {
    name: 'Licenças',
    url: '/licencas',
    icon: 'fa fa-calendar-times-o'
  },
  {
    name: 'Internações',
    url: '/internacoes',
    icon: 'fa fa-heartbeat'
  },
  {
    title: true,
    name: 'Contrato de Trabalho'
  },
  {
    name: 'Contratos de Trabalho',
    url: '/contrato-trabalho',
    icon: 'icon-book-open'
  },
  {
    name: 'Contribuições Sindicais',
    url: '/contrato-trabalho/contribuicao-sindical',
    icon: 'icon-calculator'
  },
  {
    name: 'Alterações Salariais',
    url: '/contrato-trabalho/alteracao-salarial',
    icon: 'icon-note'
  },
  {
    name: 'Férias',
    url: '/contrato-trabalho/ferias',
    icon: 'fa fa-calendar-check-o'
  },
  {
    name: 'FGTS',
    url: '/contrato-trabalho/fgts',
    icon: 'fa fa-dollar'
  },
  {
    name: 'Anotações Gerais',
    url: '/contrato-trabalho/observacao-geral',
    icon: 'fa fa-sticky-note-o'
  },
  {
    title: true,
    name: 'Históricos'
  },
  {
    name: 'CTPS',
    url: '/historico/carteira-trabalho',
    icon: 'fa fa-book'
  },
  {
    name: 'Empresas Vinculadas',
    url: '/historico/empresa',
    icon: 'fa fa-building'
  }
];

export const navEmpresa: NavData[] = [
  {
    name: 'CTPS System',
    url: '/home',
    icon: 'icon-notebook'
  },
  {
    title: true,
    name: 'Empresa'
  },
  {
    name: 'Listagem de Funcionários',
    url: '/listagem-funcionario',
    icon: 'fa fa-group'
  },
  {
    name: 'Vincular Funcionário',
    url: '/vincular-funcionario',
    icon: 'fa fa-user'
  },
  {
    name: 'Criar Registro de Contrato de Trabalho',
    url: '/criar-contrato-trabalho',
    icon: 'icon-book-open'
  },
  {
    title: true,
    name: 'Contrato de Trabalho'
  },
  {
    name: 'Criar Registro de  Contribuição Sindical',
    url: '/criar-contribuicao-sindical',
    icon: 'icon-calculator'
  },
  {
    name: 'Criar Registro de Alteração Salarial',
    url: '/criar-alteracao-salarial',
    icon: 'icon-note'
  },
  {
    name: 'Criar Registro de Férias',
    url: '/criar-ferias',
    icon: 'fa fa-calendar-check-o'
  },
  {
    name: 'Criar Registro de FGTS',
    url: '/criar-FGTS',
    icon: 'fa fa-dollar'
  },
  {
    name: 'Criar Registro de Anotação Geral',
    url: '/criar-anotacao-geral',
    icon: 'icon-note'
  },
  {
    title: true,
    name: 'Carteira de Trabalho'
  },
  {
    name: 'Criar Registro de licença',
    url: '/criar-licenca',
    icon: 'fa fa-calendar-times-o'
  },
  {
    name: 'Criar Registro de Internação',
    url: '/criar-internacao',
    icon: 'fa fa-heartbeat'
  },
  {
    title: true,
    name: 'Históricos'
  },
  {
    name: 'Funcionários',
    url: '/historico-funcionario',
    icon: 'fa fa-group'
  }
];

export const navFuncionario: NavData[] = [
  {
    name: 'CTPS System',
    url: '/home',
    icon: 'icon-notebook'
  },
  {
    title: true,
    name: 'Administrador'
  },
  {
    name: 'Listagem de Usuários',
    url: '/listagem-funcionario',
    icon: 'fa fa-group'
  },
  {
    name: 'Listagem de Empresas',
    url: '/listagem-empresa',
    icon: 'fa fa-building'
  },
  {
    name: 'Cadastrar CTPS',
    url: '/cadastrar-CTPS',
    icon: 'icon-book-open'
  },
  {
    name: 'Cadastrar usuário',
    url: '/registrar-cidadao',
    icon: 'fa fa-user-o'
  },
  {
    name: 'Cadastrar Empresa',
    url: '/registrar-empresa',
    icon: 'fa fa-building'
  }
];
