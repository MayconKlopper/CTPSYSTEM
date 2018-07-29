
namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Entidade que representa uma anotação geral no sistema
    /// </summary>
    public class AnotacaoGeral
    {
        /// <summary>
        /// Identificador único da anotação geral
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Identificador único do contrato de trabalho ao qual
        /// esta anotação geral está vinculada
        /// </summary>
        public int IdContratoTrabalho { get; set; }
        /// <summary>
        /// Texto da anotação geral
        /// </summary>
        public string Texto { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Registro da carteira de trabalho ao qual esta anotação geral
        /// está vinculada
        /// </summary>
        public virtual ContratoTrabalho ContratoTrabalho { get; set; }

        #endregion
    }
}
