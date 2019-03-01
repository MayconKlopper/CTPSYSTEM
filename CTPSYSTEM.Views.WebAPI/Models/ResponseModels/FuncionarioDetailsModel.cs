using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Enumeradores;

using System;

namespace CTPSYSTEM.Views.WebAPI.Models.ResponseModels
{
    public class FuncionarioDetailsModel
    {
        /// <summary>
        /// Identificador único do funcionário
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único da empresa ao qual o funcionário está vinculado
        /// </summary>
        public int? IdEmpresa { get; set; }

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
        /// Sigla do estado
        /// </summary>
        public EstadoSigla SiglaEstado { get; set; }

        public EmpresaDetailsModel Empresa { get; set; }

        public static implicit operator FuncionarioDetailsModel(Funcionario funcionario)
        {
            if (funcionario == null)
            {
                return null;
            }

            FuncionarioDetailsModel model = new FuncionarioDetailsModel();

            model.Id = funcionario.Id;
            model.Nome = funcionario.Nome;
            model.CPF = funcionario.CPF;
            model.Cidade = funcionario.LocalNascimento.Cidade;
            model.Data = funcionario.LocalNascimento.Data;
            model.Estado = funcionario.LocalNascimento.Estado.Nome;
            model.SiglaEstado = funcionario.LocalNascimento.Estado.Sigla;
            model.Empresa = funcionario.Empresa;

            return model;
        }
    }
}