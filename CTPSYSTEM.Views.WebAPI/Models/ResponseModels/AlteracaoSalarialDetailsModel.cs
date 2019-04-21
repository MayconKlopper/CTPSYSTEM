using CTPSYSTEM.Domain;
using System;

namespace CTPSYSTEM.Views.WebAPI.Models.ResponseModels
{
    public class AlteracaoSalarialDetailsModel
    {
        /// <summary>
        /// Identificador único do registro de alteração salarial
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único do contrato de trabalho ao qual
        /// esta alteração salarial está vinculada
        /// </summary>
        public int IdContratoTrabalho { get; set; }

        /// <summary>
        /// Data que ocorreu o aumeto salarial
        /// </summary>
        public DateTimeOffset DataAumento { get; set; }

        /// <summary>
        /// Valor de remuneração em decimal
        /// </summary>
        public decimal Remuneracao { get; set; }

        /// <summary>
        /// Valor de remuneração escrita por extenso
        /// </summary>
        public string RemuneracaoExtenso { get; set; }

        /// <summary>
        /// Cargo para o qual o funcionário foi promovido
        /// </summary>
        public string Cargo { get; set; }

        /// <summary>
        /// Motivo do aumento salarial
        /// </summary>
        public string Motivo { get; set; }

        public static implicit operator AlteracaoSalarialDetailsModel(AlteracaoSalarial alteracaoSalarial)
        {
            if (ReferenceEquals(alteracaoSalarial, null))
            {
                return null;
            }

            AlteracaoSalarialDetailsModel model = new AlteracaoSalarialDetailsModel();

            model.Id = alteracaoSalarial.Id;
            model.IdContratoTrabalho = alteracaoSalarial.IdContratoTrabalho;
            model.DataAumento = alteracaoSalarial.DataAumento;
            model.Remuneracao = alteracaoSalarial.Remuneracao;
            model.RemuneracaoExtenso = alteracaoSalarial.RemuneracaoExtenso;
            model.Cargo = alteracaoSalarial.Cargo;
            model.Motivo = alteracaoSalarial.Motivo;

            return model;
        }
    }
}