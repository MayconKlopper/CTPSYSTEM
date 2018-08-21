using CTPSYSTEM.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTPSYSTEM.Views.WebAPI.Models.RequestModels
{
    public class AddLicencaModel
    {
        /// <summary>
        /// Identificador único do registro de licença
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único da carteira de trabalho oa qual
        /// este registro de licença está vinculado
        /// </summary>
        public int IdCarteiraTrabalho { get; set; }

        /// <summary>
        /// Data do inicio da licença
        /// </summary>
        public DateTimeOffset DataInicio { get; set; }

        /// <summary>
        /// Data de término da licença
        /// </summary>
        public DateTimeOffset DataTermino { get; set; }

        /// <summary>
        /// Código do posto que afastou o funcionário
        /// </summary>
        public int CodigoPosto { get; set; }

        /// <summary>
        /// Motivo do afastamento.
        /// OBS: Esse campo é opcional e não existe na carteira de trabalho física
        /// </summary>
        public string Motivo { get; set; }

        public static implicit operator Licenca(AddLicencaModel model)
        {
            Licenca licenca = new Licenca();

            licenca.CodigoPosto = model.CodigoPosto;
            licenca.DataInicio = model.DataInicio;
            licenca.DataTermino = model.DataTermino;
            licenca.Motivo = model.Motivo;
            licenca.IdCarteiraTrabalho = model.IdCarteiraTrabalho;

            return licenca;
        }
    }
}
