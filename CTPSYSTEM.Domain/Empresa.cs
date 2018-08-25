using CTPSYSTEM.Domain.Historico;

using System.Collections.Generic;

namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Entidade que representa uma empresa
    /// </summary>
    public class Empresa
    {
        /// <summary>
        /// Identificador único da empresa cadastrada no sistema
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// CNPJ da empresa
        /// </summary>
        public string CNPJ { get; set; }

        /// <summary>
        /// Nome fantasia da empresa
        /// </summary>
        public string NomeFantasia { get; set; }

        /// <summary>
        /// Razão social da empresa
        /// </summary>
        public string RazaoSocial { get; set; }

        /// <summary>
        /// Tipo do seguimento da empresa
        /// </summary>
        public string Seguimento { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Registro de endereços da empresa. OBS: Uma empresa pode ter várias filiais espalhadas pelo Brasil
        /// </summary>
        public virtual ICollection<Endereco> Endereco { get; set; }

        /// <summary>
        /// Contratos de trabalho vinculados a esta empresa
        /// </summary>
        public virtual ICollection<ContratoTrabalho> ContratoTrabalho { get; set; }

        /// <summary>
        /// Funcionários que estão vinculados a esta empresa
        /// </summary>
        public virtual ICollection<Funcionario> Funcionario { get; set; }

        /// <summary>
        /// Histórico de Funcionários que já foram vinculados a esta empresa
        /// </summary>
        public virtual ICollection<FuncionarioHistorico> FuncionarioHistorico { get; set; }

        #endregion Relacionamentos
    }
}