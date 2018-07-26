using CTPSYSTEM.Domain.Enums;

using System;

namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Identidade que representa um registro de alteração de documento
    /// </summary>
    public class AlteracaoIdentidade
    {
        /// <summary>
        /// Identificador único do registro de alteração de documento
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Identificador único da carteira de trabalho
        /// </summary>
        public int IdCarteiraTrabalho { get; set; }
        /// <summary>
        /// Registro de alteração de nome
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Registro de alteração de documento
        /// </summary>
        public string Documento { get; set; }
        /// <summary>
        /// Registro de alteração de estado civil
        /// </summary>
        public EstadoCivil EstadoCivil { get; set; }
        /// <summary>
        /// Data da alteração
        /// </summary>
        public DateTime DataAlteracao { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Carteira de trabalho vinculada a este registro de alteração de documento
        /// </summary>
        public virtual CarteiraTrabalho CarteiraTrabalho { get; set; }

        #endregion
    }
}
