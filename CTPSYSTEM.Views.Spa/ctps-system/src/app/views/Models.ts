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
