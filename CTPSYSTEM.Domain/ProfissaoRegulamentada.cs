using System;

namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Registro de profissão regulamentada
    /// </summary>
    public class ProfissaoRegulamentada
    {
        /// <summary>
        /// Identificador único do registro
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Identificador único da carteira de trabalho
        /// </summary>
        public int IdCarteiraTrabalho { get; set; }
        /// <summary>
        /// Nome da profissão
        /// </summary>
        public string Profissao { get; set; }
        /// <summary>
        /// Número da profissão
        /// </summary>
        public int Numero { get; set; }
        /// <summary>
        /// Liv da profissão
        /// </summary>
        public int Liv { get; set; }
        /// <summary>
        /// Fis da profissão
        /// </summary>
        public int Fis { get; set; }
        /// <summary>
        /// SRTE da profissão
        /// </summary>
        public string SRTE { get; set; }
        /// <summary>
        /// Data de cadastro do registro no sistema
        /// </summary>
        public DateTime Data { get; set; }
        /// <summary>
        /// Data em que o funcionário obteve o registro de profissão regulamentada
        /// </summary>
        public DateTime DataRegistro { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Registro da carteira de trabalho vinculada a este registro de profissão regulamentada
        /// </summary>
        public virtual CarteiraTrabalho CarteiraTrabalho { get; set; }

        #endregion
    }
}
