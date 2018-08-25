using CTPSYSTEM.Domain;

using System;

namespace CTPSYSTEM.Views.WebAPI.Models.ResponseModels
{
    public class FeriasDetailsModel
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

        /// <summary>
        /// Quantidade de dias que o funcionário gozou de férias
        /// </summary>
        public int Dias { get; set; }

        public static implicit operator FeriasDetailsModel(Ferias ferias)
        {
            FeriasDetailsModel model = new FeriasDetailsModel();

            model.Id = ferias.Id;
            model.IdContratoTrabalho = ferias.IdContratoTrabalho;
            model.PeriodoRelativo = ferias.PeriodoRelativo;
            model.DataInicio = ferias.DataInicio;
            model.DataTermino = ferias.DataTermino;

            return model;
        }
    }
}