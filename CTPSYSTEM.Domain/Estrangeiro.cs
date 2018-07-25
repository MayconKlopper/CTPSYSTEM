using System;

namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Entidade que representa o caso da carteira de trabalho pertencer a um estrangeiro
    /// </summary>
    public class Estrangeiro
    {
        /// <summary>
        /// Identificador único do registro de estrangeiro
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Identificador único da carteira de trabalho que está vinculada ao registro de estrangeiro
        /// </summary>
        public int IdCarteiraTrabalho { get; set; }
        /// <summary>
        /// Data de chegada do estrangeiro ao Brasil
        /// </summary>
        public DateTime Chegada { get; set; }
        /// <summary>
        /// Documento de identificação do estrangeiro
        /// </summary>
        public string DocumentoIdentidade { get; set; }
        /// <summary>
        /// Data de expedição do documento de identificação do estrangeiro
        /// </summary>
        public DateTime Expedicao { get; set; }
        /// <summary>
        /// Estado de expedição do documento de identificação do estrangeiro
        /// </summary>
        public string Estado { get; set; }
        /// <summary>
        /// Anotações de observação
        /// </summary>
        public string Observacao { get; set; }

        #region relacionamentos

        /// <summary>
        /// Carteira de trabalho que está vinculada ao registro de estrangeiro
        /// </summary>
        public virtual CarteiraTrabalho CarteiraTrabalho { get; set; }

        #endregion
    }
}
