using CTPSYSTEM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTPSYSTEM.Views.WebAPI.Models.RequestModels
{
    public class AddEstrangeiroModel
    {
        /// <summary>
        /// Data de chegada do estrangeiro ao Brasil
        /// </summary>
        public DateTime Chegada { get; set; }

        /// <summary>
        /// Documento de identificação do estrangeiro
        /// </summary>
        public string DocumentoIdentidade { get; set; }

        /// <summary>
        /// Data de expedição do documento de identificação do estrangeiro
        /// </summary>
        public DateTime Expedicao { get; set; }

        /// <summary>
        /// Estado de expedição do documento de identificação do estrangeiro
        /// </summary>
        public string Estado { get; set; }

        /// <summary>
        /// Anotações de observação
        /// </summary>
        public string Observacao { get; set; }

        public static implicit operator Estrangeiro(AddEstrangeiroModel model)
        {
            if (ReferenceEquals(model, null))
            {
                return null;
            }

            Estrangeiro estrangeiro = new Estrangeiro();
            estrangeiro.Chegada = model.Chegada;
            estrangeiro.DocumentoIdentidade = model.DocumentoIdentidade;
            estrangeiro.Estado = model.Estado;
            estrangeiro.Expedicao = model.Expedicao;
            estrangeiro.Observacao = model.Observacao;
            return estrangeiro;
        }
    }
}
