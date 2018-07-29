using System;

namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Entidadde que representa um registro de internação no sistema
    /// </summary>
    public class Internacao
    {
        /// <summary>
        /// Identificador único do registro de internação
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único da carteira de trabalho ao qual
        /// este registro de internação está vinculado
        /// </summary>
        public int IdCarteiraTrabalho { get; set; }

        /// <summary>
        /// Nome do hospital onde o funcionário foi internado
        /// </summary>
        public string Hospital { get; set; }

        /// <summary>
        /// Registro do hospital
        /// </summary>
        public string Registro { get; set; }

        /// <summary>
        /// Matricula do hospital
        /// </summary>
        public string Matricula { get; set; }

        /// <summary>
        /// Data do início da internação
        /// </summary>
        public DateTimeOffset DataInternacao { get; set; }

        /// <summary>
        /// Data da alta do funcionário
        /// </summary>
        public DateTimeOffset DataAlta { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Registro de carteira de trabalho ao qual
        /// este registro de internação está vinculado
        /// </summary>
        public virtual CarteiraTrabalho CarteiraTrabalho { get; set; }

        #endregion
    }
}
