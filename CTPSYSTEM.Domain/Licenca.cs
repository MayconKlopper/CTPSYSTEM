using System;

namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Entidade que representa uma licença (Afastamento) do funcionário.
    /// Afastamento ocorre quando o funcionário tem alguma doença física ou mental e precisa ser afastado
    /// do trabalho por um período de tempo
    /// </summary>
    public class Licenca
    {
        /// <summary>
        /// Identificador único do registro de licença
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único da carteira de trabalho oa qual
        /// este registro de licença está vinculado
        /// </summary>
        public int IdCarteiraTrabalho { get; set; }

        /// <summary>
        /// Data do inicio da licença
        /// </summary>
        public DateTimeOffset DataInicio { get; set; }

        /// <summary>
        /// Data de término da licença
        /// </summary>
        public DateTimeOffset DataTermino { get; set; }

        private int dias;

        /// <summary>
        /// Quantidade de dias que o funcionário ficou de licença
        /// </summary>
        public int Dias
        {
            get
            {
                if (this.DataInicio == null || this.DataTermino == null)
                {
                    return 0;
                }

                var seconds = (this.DataTermino.ToUnixTimeSeconds() - this.DataInicio.ToUnixTimeSeconds());
                var days = Convert.ToInt32((((seconds / 60) / 60) / 24));
                return days;
            }

            set { this.dias = value; }
        }

        /// <summary>
        /// Código do posto que afastou o funcionário
        /// </summary>
        public int CodigoPosto { get; set; }

        /// <summary>
        /// Motivo do afastamento.
        /// OBS: Esse campo é opcional e não existe na carteira de trabalho física
        /// </summary>
        public string Motivo { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Registro de carteira de trabalho ao qual esta licença(afastamento) está vinculado
        /// </summary>
        public virtual CarteiraTrabalho CarteiraTrabalho { get; set; }

        #endregion Relacionamentos
    }
}