using CTPSYSTEM.Domain.Enums;

using System.Collections.Generic;

namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Entidade que representa um estado do Brasil no sistema
    /// </summary>
    public class Estado
    {
        /// <summary>
        /// Identificador único do registro de estado
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nome do estado
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Sigla do estado
        /// </summary>
        public EstadoSigla Sigla { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Lista de endereços vinculados a este estado
        /// </summary>
        public virtual ICollection<Endereco> Endereco { get; set; }

        #endregion
    }
}
