using CTPSYSTEM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTPSYSTEM.Views.WebAPI.Models.ResponseModels
{
    public class FGTSDetailsModel
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
        public string Estado { get; set; }

        public static implicit operator FGTSDetailsModel(FGTS fgts)
        {
            FGTSDetailsModel model = new FGTSDetailsModel();
            model.Id = fgts.Id;
            model.IdContratoTrabalho = fgts.IdContratoTrabalho;
            model.Opcao = fgts.Opcao;
            model.Retratacao = fgts.Retratacao;
            model.BancoDepositario = fgts.BancoDepositario;
            model.Agencia = fgts.Agencia;
            model.Praca = fgts.Praca;
            model.Estado = fgts.Estado.ToString();

            return model;
        }
    }
}
