namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Entidadde que representa uma contribuição sindical
    /// </summary>
    public class ContribuicaoSindical
    {
        /// <summary>
        /// Identificador único da contribuição sindical
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único do contrato de trabalho ao qual este
        /// registro de contribuição sindical está vinculado
        /// </summary>
        public int IdContratoTrabalho { get; set; }

        /// <summary>
        /// Valor da contribuição sindical
        /// </summary>
        public decimal ValorContribuicao { get; set; }

        /// <summary>
        /// Nome do sindicato ao qual esta contribuição pertence
        /// </summary>
        public string NomeSindicato { get; set; }

        /// <summary>
        /// Ano da contribuição
        /// </summary>
        public int Ano { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Registro do contrato de trabalho ao qual
        /// esta contribuição sindical está vinculada
        /// </summary>
        public virtual ContratoTrabalho ContratoTrabalho { get; set; }

        #endregion Relacionamentos
    }
}