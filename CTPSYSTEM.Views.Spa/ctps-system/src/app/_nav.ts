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
    name: 'Portador da CTPS'
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
    name: 'Contratos de Trabalho',
    url: '/contratoTrabalho',
    icon: 'icon-book-open'
  },
  {
    name: 'Contribuições Sindicais',
    url: '/contribuicaoSindical',
    icon: 'icon-calculator'
  },
  {
    name: 'Alterações Salariais',
    url: '/alteracaoSalarial',
    icon: 'icon-note'
  },
  {
    name: 'Férias',
    url: '/ferias',
    icon: 'fa fa-calendar-check-o'
  },
  {
    name: 'FGTS',
    url: '/fgts',
    icon: 'fa fa-dollar'
  },
  {
    name: 'Observações Gerais',
    url: '/observacaoGeral',
    icon: 'fa fa-sticky-note-o'
  },
  {
    title: true,
    name: 'Históricos'
  },
  {
    name: 'CTPS',
    url: '/historico/ctps',
    icon: 'fa fa-book'
  },
  {
    name: 'Empresas Vinculadas',
    url: '/historico/empresaVinculada',
    icon: 'fa fa-building'
  }
];
