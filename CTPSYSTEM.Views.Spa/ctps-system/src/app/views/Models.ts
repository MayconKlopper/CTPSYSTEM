export class CarteiraTrabalho {
    public nomeFuncionario: string;
    public numero: number;
    public numeroDocumento: string;
    public serie: string;
    public dataEmissao: Date;
    public foto: string;
    public filiacaoPai: string;
    public filiacaoMae: string;
    public ativo: boolean;
}

export class Licenca {
    public dataInicio: Date;
    public dataTermino: Date;
    public dias: number;
    public codigoPosto: number;
    public motivo: string;
}

export class Internacao {
    public hospital: string;
    public registro: string;
    public matricula: string;
    public dataInternacao: Date;
    public dataAlta: Date;
}

export class ContratoTrabalho {
    public id: number;
    public nomeEmpresa: string;
    public cargo: string;
    public CBONumero: number;
    public dataAdmissao: Date;
    public dataSaida?: Date;
    public remuneracao: number;
    public remuneracaoExtenso: string;
    public flsFicha: number;
    public registroNumero: number;
    public ativo: boolean;
}

export class ContribuicaoSindical {
    public id: number;
    public idContratoTrabalho: number;
    public valorContribuicao: number;
    public nomeSindicato: string;
    public ano: number;
}

export class AlteracaoSalarial {
    public id: number;
    public idContratoTrabalho: number;
    public dataAumento: Date;
    public remuneracao: number;
    public remuneracaoExtenso: string;
    public cargo: string;
    public motivo: string;
}

export class Ferias {
    public id: number;
    public idContratoTrabalho: number;
    public periodoRelativo: string;
    public dataInicio: Date;
    public dataTermino: Date;
    public dias: number;
}

export class AnotacaoGeral {
    public id: number;
    public idContratoTrabalho: number;
    public texto: string;
}