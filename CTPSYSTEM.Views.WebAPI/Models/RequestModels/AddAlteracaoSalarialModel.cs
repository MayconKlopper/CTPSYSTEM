using CTPSYSTEM.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTPSYSTEM.Views.WebAPI.Models.RequestModels
{
    public class AddAlteracaoSalarialModel
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
        public DateTime DataAumento { get; set; }

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

        public static implicit operator AlteracaoSalarial(AddAlteracaoSalarialModel model)
        {
            AlteracaoSalarial alteracaoSalarial = new AlteracaoSalarial();

            alteracaoSalarial.Cargo = model.Cargo;
            alteracaoSalarial.DataAumento = model.DataAumento;
            alteracaoSalarial.Motivo = model.Motivo;
            alteracaoSalarial.Remuneracao = model.Remuneracao;
            alteracaoSalarial.RemuneracaoExtenso = model.RemuneracaoExtenso;
            alteracaoSalarial.IdContratoTrabalho = model.IdContratoTrabalho;

            return alteracaoSalarial;
        }
    }
}
