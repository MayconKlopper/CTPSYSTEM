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

export class Empresa {
    public id: number;
    public CNPJ: string;
    public nomeFantasia: string;
    public razaoSocial: string;
    public seguimento: string;
    public estado: string;
    public siglaEstado: EstadoSigla;
    public cidade: string;
    public rua: string;
    public numero: number;
    public sala: string;
}

export class EmpresaHistorico {
    public CNPJ: string;
    public nomeFantasia: string;
    public razaoSocial: string;
    public seguimento: string;
    public estado: string;
    public siglaEstado: EstadoSigla;
    public cidade: string;
    public rua: string;
    public numero: number;
    public sala: string;
    public data: Date;
}

// ENUMS
export enum EstadoSigla {
    /// <summary>
        /// Acre
        /// </summary>
        AC = 1,

        /// <summary>
        /// Alagoas
        /// </summary>
        AL = 2,

        /// <summary>
        /// Amapá
        /// </summary>
        AP = 3,

        /// <summary>
        /// Amazonas
        /// </summary>
        AM = 4,

        /// <summary>
        /// Bahia
        /// </summary>
        BA = 5,

        /// <summary>
        /// Ceará
        /// </summary>
        CE = 6,

        /// <summary>
        /// Distrito federal
        /// </summary>
        DF = 7,

        /// <summary>
        /// Espírito Santo
        /// </summary>
        ES = 8,

        /// <summary>
        /// Goiás
        /// </summary>
        GO = 9,

        /// <summary>
        /// Maranhão
        /// </summary>
        MA = 10,

        /// <summary>
        /// Mato Grosso
        /// </summary>
        MT = 11,

        /// <summary>
        /// Mato Grosso do Sul
        /// </summary>
        MS = 12,

        /// <summary>
        /// Minas Gerais
        /// </summary>
        MG = 13,

        /// <summary>
        /// Pará
        /// </summary>
        PA = 14,

        /// <summary>
        /// Paraíba
        /// </summary>
        PB = 15,

        /// <summary>
        /// Paraná
        /// </summary>
        PR = 16,

        /// <summary>
        /// Pernambuco
        /// </summary>
        PE = 17,

        /// <summary>
        /// Piauí
        /// </summary>
        PI = 18,

        /// <summary>
        /// Roraima
        /// </summary>
        RR = 19,

        /// <summary>
        /// Rondônia
        /// </summary>
        RO = 20,

        /// <summary>
        /// Rio de Janeiro
        /// </summary>
        RJ = 21,

        /// <summary>
        /// Rio Grande do Norte
        /// </summary>
        RN = 22,

        /// <summary>
        /// Rio Grande do Sul
        /// </summary>
        RS = 23,

        /// <summary>
        /// Santa Catarina
        /// </summary>
        SC = 24,

        /// <summary>
        /// São Paulo
        /// </summary>
        SP = 25,

        /// <summary>
        /// Sergipe
        /// </summary>
        SE = 26,

        /// <summary>
        /// Tocantins
        /// </summary>
        TO = 27
}