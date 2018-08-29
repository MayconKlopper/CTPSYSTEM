using System;
using System.Collections.Generic;

namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Entidade que representa uma carteira de trabalho no sistema
    /// </summary>
    public class CarteiraTrabalho
    {
        /// <summary>
        /// Identificador único da carteira de trabalho
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Idenificador único do funcionário ao qual
        /// esta carteira de trabalho está vinculada
        /// </summary>
        public int IdFuncionario { get; set; }

        /// <summary>
        /// Número da carteira de trabalho
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// Número do documento da carteira de trabalho
        /// </summary>
        public string NumeroDocumento { get; set; }

        /// <summary>
        /// Série da carteira de trabalho
        /// </summary>
        public string Serie { get; set; }

        /// <summary>
        /// Data de emissão da carteira de trabalho
        /// </summary>
        public DateTime DataEmissao { get; set; }

        /// <summary>
        /// Foto do funcionário
        /// </summary>
        public string Foto { get; set; }

        /// <summary>
        /// Nome do pai do funcionário
        /// </summary>
        public string FiliacaoPai { get; set; }

        /// <summary>
        /// Nome da mãe do funcionário
        /// </summary>
        public string FiliacaoMae { get; set; }

        /// <summary>
        /// Indica se esta carteria de trabalho é a carteira atual
        /// do funcionário
        /// </summary>
        public bool Ativo { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Entidade funcionário portador desta carteira de trabalho
        /// </summary>
        public virtual Funcionario funcionario { get; set; }

        /// <summary>
        /// Contratos de trabalho do funcionário
        /// </summary>
        public virtual ICollection<ContratoTrabalho> ContratoTrabalho { get; set; }

        /// <summary>
        /// Registro de estrangeiro portador de uma carteira de trabalho
        /// </summary>
        public virtual Estrangeiro Estrangeiro { get; set; }

        /// <summary>
        /// Registros de licenças do funcionário
        /// </summary>
        public virtual ICollection<Licenca> Licenca { get; set; }

        /// <summary>
        /// Registros de internações do funcionário que estão vinculadas
        /// a esta carteira de trabalho
        /// </summary>
        public virtual ICollection<Internacao> Internacao { get; set; }

        #endregion Relacionamentos
    }
}