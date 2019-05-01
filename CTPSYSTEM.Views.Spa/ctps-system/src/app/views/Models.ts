export class CarteiraTrabalhoDetalhes {
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

export class CriarCarteiraTrabalho {
    public idFuncionario: number;
    public numero: number;
    public numeroDocumento: string;
    public serie: string;
    public dataEmissao: Date;
    public foto: string;
    public filiacaoPai: string;
    public filiacaoMae: string;
    public estrangeiro?: CriarEstrangeiro;
}

export class CriarEstrangeiro {
    public chegada: Date;
    public documentoIdentidade: string;
    public expedicao: Date;
    public estado: string;
    public observacao: string;
}

export class LicencaDetalhes {
    public dataInicio: Date;
    public dataTermino: Date;
    public dias: number;
    public codigoPosto: number;
    public motivo: string;
}

export class CriarLicenca {
    public idCarteiratrabalho: number;
    public dataInicio: Date;
    public dataTermino: Date;
    public codigoPosto: number;
    public motivo: string;
}

export class InternacaoDetalhes {
    public hospital: string;
    public registro: string;
    public matricula: string;
    public dataInternacao: Date;
    public dataAlta: Date;
}

export class CriarInternacao {
    public idCarteiratrabalho: number;
    public hospital: string;
    public registro: string;
    public matricula: string;
    public dataInternacao: Date;
    public dataAlta: Date;
}

export class ContratoTrabalhoDetalhes {
    public id: number;
    public nomeEmpresa: string;
    public cargo: string;
    public cboNumero: number;
    public dataAdmissao: Date;
    public dataSaida?: Date;
    public remuneracao: number;
    public remuneracaoExtenso: string;
    public flsFicha: number;
    public registroNumero: number;
    public ativo: boolean;
}

export class CriarContratoTrabalho {
    public id: number;
    public idEmpresa: number;
    public idCarteiraTrabalho: number;
    public cargo: string;
    public CBONumero: number;
    public dataAdmissao: Date;
    public remuneracao: number;
    public remuneracaoExtenso: string;
    public flsFicha: number;
    public registroNumero: number;
}

export class ContribuicaoSindicalDetalhes {
    public id: number;
    public idContratoTrabalho: number;
    public valorContribuicao: number;
    public nomeSindicato: string;
    public ano: number;
}

export class CriarContribuicaoSindical {
    public id: number;
    public idContratoTrabalho: number;
    public valorContribuicao: number;
    public nomeSindicato: string;
    public ano: number;
}

export class AlteracaoSalarialDetalhes {
    public id: number;
    public idContratoTrabalho: number;
    public dataAumento: Date;
    public remuneracao: number;
    public remuneracaoExtenso: string;
    public cargo: string;
    public motivo: string;
}

export class CriarAlteracaoSalarial {
    public idContratoTrabalho: number;
    public dataAumento: Date;
    public remuneracao: number;
    public remuneracaoExtenso: string;
    public cargo: string;
    public motivo: string;
}

export class FeriasDetalhes {
    public id: number;
    public idContratoTrabalho: number;
    public periodoRelativo: string;
    public dataInicio: Date;
    public dataTermino: Date;
    public dias: number;
}

export class CriarFerias {
    public idContratoTrabalho: number;
    public periodoRelativo: string;
    public dataInicio: Date;
    public dataTermino: Date;
}

export class AnotacaoGeralDetalhes {
    public id: number;
    public idContratoTrabalho: number;
    public texto: string;
}

export class CriarAnotacaoGeral {
    public idContratoTrabalho: number;
    public texto: string;
}

export class CriarFGTS {
    public idContratoTrabalho: number;

    public opcao: Date;

    public retratacao?: Date;

    public bancoDepositario: string;

    public agencia?: string;

    public praca: string;

    public Estado: string;
}

export class FGTSDetalhes {
    public id: number;

    public idContratoTrabalho: number;

    public opcao: Date;

    public retratacao?: Date;

    public bancoDepositario: string;

    public agencia?: number;

    public praca: string;

    public Estado: string;
}

export class EmpresaDetalhes {
    public id: number;
    public cnpj: string;
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

export class CriarEmpresa {
    public CNPJ: string;
    public nomeFantasia: string;
    public razaoSocial: string;
    public seguimento: string;
    public idEstado: number;
    public cidade: string;
    public rua: string;
    public numero: number;
    public sala: string;
}

export class EmpresaHistorico {
    public cnpj: string;
    public nomeFantasia: string;
    public razaoSocial: string;
    public data: Date;
}

export class FuncionarioDetalhes {
    public id: number;
    public idCarteiraTrabalho: number;
    public idContratoTrabalho: number;
    public nome: string;
    public cpf: string;
    public cidade: string;
    public data: Date;
    public estado: string;
    public siglaEstado: string;
    public carteiraTrabalho: CarteiraTrabalhoDetalhes;
}

export class CriarFuncionario {
    public nome: string;
    public cpf: string;
    public cidade: string;
    public data: Date;
    public idEstado: number;
}

export class FuncionarioHistorico {
    public Nome: string;
    public cpf: string;
    public data: Date;
}

export class HashDetalhes {
    public idFuncionario: number;
    public idCarteiraTrabalho: number;
    public hashCode: string;
}

export class CriarHash {
    public idFuncionario: number;
    public idCarteiraTrabalho: number;
}

export class VincularFuncionario {
    public cpf: string;
    public hashCode: string;
    public idEmpresa: number;
}

export class DesvincularFuncionario {
    public idFuncionario: number;
    public idContratoTrabalho: number;
}

// Account Settings
export class Register {
    public userName: string;
    public email: string;
    public celular: string;
    public password: string;
    public confirmPassword: string;
    public role: string;
}

export class LogIn {
    public userName: string;
    public password: string;
}

export class User {
    public token: string;
    public userName: string;
    public Email: string;
    public role: Array<string>;
    public funcionario: FuncionarioDetalhes;
    public empresa: EmpresaDetalhes;
}

export class Estado {
    public id: number;
    public nome: string;
}

// ENUMS
export enum EstadoSigla {
        /**
        * Acre
        */
        AC = 1,

        /**
        * Alagoas
        */
        AL = 2,

        /**
        * Amapá
        */
        AP = 3,

        /**
        * Amazonas
        */
        AM = 4,

        /**
        * Bahia
        */
        BA = 5,

        /**
        * Ceará
        */
        CE = 6,

        /**
        * Distrito federal
        */
        DF = 7,

        /**
        * Espírito Santo.
        */
        ES = 8,

        /**
        * Goiás
        */
        GO = 9,

        /**
        * Maranhão
        */
        MA = 10,

        /**
        * Mato Grosso
        */
        MT = 11,

        /**
        * Mato Grosso do Sul
        */
        MS = 12,

        /**
        * Minas Gerais
        */
        MG = 13,

        /**
        * Pará
        */
        PA = 14,

        /**
        * Paraíba
        */
        PB = 15,

        /**
        * Paraná
        */
        PR = 16,

        /**
        * Pernambuco
        */
        PE = 17,

        /**
        * Piauí
        */
        PI = 18,

        /**
        * Roraima
        */
        RR = 19,

        /**
        * Rondônia
        */
        RO = 20,

        /**
        * Rio de Janeiro
        */
        RJ = 21,

        /**
        * Rio Grande do Norte
        */
        RN = 22,

        /**
        * Rio Grande do Sul
        */
        RS = 23,

        /**
        * Santa Catarina
        */
        SC = 24,

        /**
        * São Paulo
        */
        SP = 25,

        /**
        * Sergipe
        */
        SE = 26,

        /**
        * Tocantins
        */
        TO = 27
}

export enum Roles {
    Funcionario = 'funcionario',
    Empresa = 'empresa',
    Usuario = 'usuario',
}

// Message template
export class MessageModel {
    public tipo: number;
    public texto: string;
}
