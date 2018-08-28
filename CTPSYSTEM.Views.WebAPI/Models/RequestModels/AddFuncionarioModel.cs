using CTPSYSTEM.Domain.Enumeradores;
using System;

namespace CTPSYSTEM.Views.WebAPI.Models.RequestModels
{
    public class AddFuncionarioModel
    {
        /// <summary>
        /// Nome do funcionário
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// CPF do funcionário
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        /// Nome da cidade
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// Data de nascimento
        /// </summary>
        public DateTime Data { get; set; }

        /// <summary>
        /// Nome do estado
        /// </summary>
        public string Estado { get; set; }

        /// <summary>
        /// Sigla do estadozx
        /// </summary>
        public EstadoSigla Sigla { get; set; }
    }
}