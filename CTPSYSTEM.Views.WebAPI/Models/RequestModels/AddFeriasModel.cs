using CTPSYSTEM.Domain;

using System;

namespace CTPSYSTEM.Views.WebAPI.Models.RequestModels
{
    public class AddFeriasModel
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

        public static implicit operator Ferias(AddFeriasModel model)
        {
            Ferias ferias = new Ferias();

            ferias.DataInicio = model.DataInicio;
            ferias.DataTermino = model.DataTermino;
            ferias.PeriodoRelativo = model.PeriodoRelativo;
            ferias.IdContratoTrabalho = model.IdContratoTrabalho;

            return ferias;
        }
    }
}