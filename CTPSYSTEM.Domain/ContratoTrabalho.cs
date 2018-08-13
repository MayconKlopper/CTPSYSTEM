using System;
using System.Collections.Generic;

namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Entidade que representa um registro de contrato de trabalho
    /// </summary>
    public class ContratoTrabalho
    {
        /// <summary>
        /// Identificador único do registro de contrato de trabalho
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único do registro de carteira trabalho 
        /// ao qual este registro de contrato de trabalho está vinculado
        /// </summary>
        public int IdCarteiraTrabalho { get; set; }

        /// <summary>
        /// Identificador único da empresa ao qual este registro de
        /// contrato de trabalho está vinculado
        /// </summary>
        public int IdEmpresa { get; set; }

        /// <summary>
        /// Nome do cargo
        /// </summary>
        public string Cargo { get; set; }

        /// <summary>
        /// Número do CBO da empresa empregadora
        /// </summary>
        public int CBONumero { get; set; }

        /// <summary>
        /// Data de firmação do contrato de trabalho
        /// </summary>
        public DateTimeOffset DataAdmissao { get; set; }

        /// <summary>
        /// Data de finalização do contrato de trabalho
        /// </summary>
        public DateTimeOffset DataSaida { get; set; }

        /// <summary>
        /// Valor de remuneração em decimal
        /// </summary>
        public decimal Remuneracao { get; set; }

        /// <summary>
        /// Valor de remuneração escrita por extenso
        /// </summary>
        public string RemuneracaoExtenso { get; set; }

        /// <summary>
        /// FlsFicha da empresa empregadora. OBS: a maioria vem com o valor 0 que é o valor default
        /// </summary>
        public int FlsFicha { get; set; }

        /// <summary>
        /// Númeor de registro da empresa. OBS: a maioria vem com o valor 0 que é o valor default
        /// </summary>
        public int RegistroNumero { get; set; }

        /// <summary>
        /// Indica se o contrato de trabalho
        /// está ativo
        /// </summary>
        public bool Ativo { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Registro da empresa empregadora
        /// </summary>
        public virtual Empresa Empresa { get; set; }

        /// <summary>
        /// Registro da carteira de trabalho ao qual este contrato de trabalho está vinculado
        /// </summary>
        public virtual CarteiraTrabalho CarteiraTrabalho { get; set; }

        /// <summary>
        /// Contribuições sindicais que estão vinculadas a este contrato de trabalho
        /// </summary>
        public virtual ICollection<ContribuicaoSindical> ContribuicaoSindical { get; set; }

        /// <summary>
        /// Anotações gerais que estão vinculadas a este contrato de trabalho
        /// </summary>
        public virtual ICollection<AnotacaoGeral> AnotacaoGeral { get; set; }

        /// <summary>
        /// Registros de férias vinculados a este contrato de trabalho
        /// </summary>
        public virtual ICollection<Ferias> Ferias { get; set; }

        /// <summary>
        /// Registros de alterações salariais vinculadas a este contrato de trabalho
        /// </summary>
        public virtual ICollection<AlteracaoSalarial> AlteracaoSalarial { get; set; }

        #endregion
    }
}
