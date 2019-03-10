﻿using CTPSYSTEM.Domain;

using System;

namespace CTPSYSTEM.Views.WebAPI.Models.ResponseModels
{
    public class InternacaoDetailsModel
    {
        /// <summary>
        /// Nome do hospital onde o funcionário foi internado
        /// </summary>
        public string Hospital { get; set; }

        /// <summary>
        /// Registro do hospital
        /// </summary>
        public string Registro { get; set; }

        /// <summary>
        /// Matricula do hospital
        /// </summary>
        public string Matricula { get; set; }

        /// <summary>
        /// Data do início da internação
        /// </summary>
        public DateTimeOffset DataInternacao { get; set; }

        /// <summary>
        /// Data da alta do funcionário
        /// </summary>
        public DateTimeOffset DataAlta { get; set; }

        public static implicit operator InternacaoDetailsModel(Internacao internacao)
        {
            if (ReferenceEquals(internacao, null))
            {
                return null;
            }

            InternacaoDetailsModel model = new InternacaoDetailsModel();
             
            model.Hospital = internacao.Hospital;
            model.Registro = internacao.Registro;
            model.Matricula = internacao.Matricula;
            model.DataInternacao = internacao.DataInternacao;
            model.DataAlta = internacao.DataAlta;

            return model;
        }
    }
}