using CTPSYSTEM.Domain;

using System;

namespace CTPSYSTEM.Views.WebAPI.Models.RequestModels
{
    public class AddInternacaoModel
    {
        /// <summary>
        /// Identificador único da carteira de trabalho ao qual
        /// este registro de internação está vinculado
        /// </summary>
        public int IdCarteiraTrabalho { get; set; }

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

        public static implicit operator Internacao(AddInternacaoModel model)
        {
            if (ReferenceEquals(model, null))
            {
                return null;
            }

            Internacao internacao = new Internacao();

            internacao.DataAlta = model.DataAlta;
            internacao.DataInternacao = model.DataInternacao;
            internacao.Hospital = model.Hospital;
            internacao.Matricula = model.Matricula;
            internacao.Registro = model.Registro;
            internacao.IdCarteiraTrabalho = model.IdCarteiraTrabalho;

            return internacao;
        }
    }
}