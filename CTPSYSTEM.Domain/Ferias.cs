using System;

namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Entidade que representa registro de férias do funcionário
    /// </summary>
    public class Ferias
    {
        /// <summary>
        /// Identificador único do registro de férias
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único do registro de contrato de trabalho ao qual
        /// estas férias estão vinculadas
        /// </summary>
        public int IdContratoTrabalho { get; set; }

        /// <summary>
        /// Período que o funcionário trabalhou para ter direito a estas férias
        /// </summary>
        public string PeriodoRelativo { get; set; }

        /// <summary>
        /// Data de início das férias
        /// </summary>
        public DateTimeOffset DataInicio { get; set; }

        /// <summary>
        /// Data de término das férias
        /// </summary>
        public DateTimeOffset DataTermino { get; set; }

        private int dias;

        /// <summary>
        /// Quantidade de dias que o funcionário gozou de férias
        /// </summary>
        public int Dias
        {
            get
            {
                if (this.DataInicio == null || this.DataTermino == null)
                {
                    return 0;
                }

                var seconds = (this.DataInicio.ToUnixTimeSeconds() - this.DataTermino.ToUnixTimeSeconds());
                var days = Convert.ToInt32((((seconds / 60) / 60) / 24));
                return days;
            }

            set { this.dias = value; }
        }

        #region Relacionamentos

        /// <summary>
        /// Registro de contrato de trabaho ao qual
        /// estas férias está vinculada
        /// </summary>
        public virtual ContratoTrabalho ContratoTrabalho { get; set; }

        #endregion Relacionamentos
    }
}