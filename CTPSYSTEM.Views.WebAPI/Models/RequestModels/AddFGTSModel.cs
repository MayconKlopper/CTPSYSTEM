using System;

using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Enumeradores;

namespace CTPSYSTEM.Views.WebAPI.Models.RequestModels
{
    public class AddFGTSModel
    {
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
        public string Agencia { get; set; }

        /// <summary>
        /// Cidade onde está situada a empresa
        /// </summary>
        public string Praca { get; set; }

        /// <summary>
        /// Sigla do estado onde está situada a empresa
        /// </summary>
        public string Estado { get; set; }

        public static implicit operator FGTS (AddFGTSModel model)
        {
            FGTS fgts = new FGTS();

            fgts.IdContratoTrabalho = model.IdContratoTrabalho;
            fgts.Opcao = model.Opcao;
            fgts.Retratacao = model.Retratacao;
            fgts.BancoDepositario = model.BancoDepositario;
            fgts.Agencia = model.Agencia;
            fgts.Praca = model.Praca;
            fgts.Estado = Enum.Parse<EstadoSigla>(model.Estado);

            return fgts;
        }
    }
}
