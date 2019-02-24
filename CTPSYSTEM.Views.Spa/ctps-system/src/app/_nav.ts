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

export const navItems: NavData[] = [
  {
    name: 'CTPS System',
    url: '/',
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
    name: 'Observações Gerais',
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
