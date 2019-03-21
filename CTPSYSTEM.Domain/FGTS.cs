using System;

using CTPSYSTEM.Domain.Enumeradores;

namespace CTPSYSTEM.Domain
{
    public class FGTS
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
        /// Data em que optou por iniciar o recolhimento de FGTS
        /// </summary>
        public DateTime Opcao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? Retratacao { get; set; }

        /// <summary>
        /// Banco depositário do FGTS
        /// </summary>
        public string BancoDepositario { get; set; }

        /// <summary>
        /// Agência do banco depositário
        /// </summary>
        public int? Agencia { get; set; }

        /// <summary>
        /// Cidade onde está situada a empresa
        /// </summary>
        public string Praca { get; set; }

        /// <summary>
        /// Sigla do estado onde está situada a empresa
        /// </summary>
        public EstadoSigla Estado { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Registro do contrato de trabalho ao qual
        /// esta contribuição sindical está vinculada
        /// </summary>
        public virtual ContratoTrabalho ContratoTrabalho { get; set; }

        #endregion Relacionamentos
    }
}
