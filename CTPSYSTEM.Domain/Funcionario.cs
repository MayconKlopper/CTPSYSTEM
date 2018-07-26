using System;
using System.Collections.Generic;

namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Entidade que representa um funcionário no sistema
    /// </summary>
    public class Funcionario
    {
        /// <summary>
        /// Identificador único do funcionário
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Identificador único da carteira de trabalho vinculada a este funcionário
        /// </summary>
        public int IdCarteiraTrabalho { get; set; }
        /// <summary>
        /// Nome do funcionário
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// CPF do funcionário
        /// </summary>
        public string CPF { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Carteira de trabalho deste funcionário
        /// </summary>
        public virtual ICollection<CarteiraTrabalho> CarteiraTrabalho { get; set; }

        #endregion
    }
}
