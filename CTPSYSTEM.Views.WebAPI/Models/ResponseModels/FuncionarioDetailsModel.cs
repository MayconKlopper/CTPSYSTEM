using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Enumeradores;

using System;
using System.Collections.Generic;
using System.Linq;

namespace CTPSYSTEM.Views.WebAPI.Models.ResponseModels
{
    public class FuncionarioDetailsModel
    {
        /// <summary>
        /// Identificador único do funcionário
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único da carteira de trabalho
        /// vinculada a este funcionario
        /// </summary>
        public int IdCarteiraTrabalho { get; set; }

        /// <summary>
        /// Identificador único do contrato de trabalho
        /// vinculado a este funcionário
        /// </summary>
        public int IdContratoTrabalho { get; set; }

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
        public string SiglaEstado { get; set; }

        public CarteiraTrabalhoDetailsModel CarteiraTrabalho { get; set; }

        public static implicit operator FuncionarioDetailsModel(Funcionario funcionario)
        {
            if (funcionario == null)
            {
                return null;
            }

            FuncionarioDetailsModel model = new FuncionarioDetailsModel();

            model.Id = funcionario.Id;

            if (!ReferenceEquals(funcionario.CarteiraTrabalho, null)
                && funcionario.CarteiraTrabalho?.Count > 0)
            {
                model.IdCarteiraTrabalho = funcionario.CarteiraTrabalho
                                                  .FirstOrDefault(ct => ct.Ativo).Id;
                model.CarteiraTrabalho = funcionario.CarteiraTrabalho.FirstOrDefault(ct => ct.Ativo);

                if (!ReferenceEquals(funcionario.CarteiraTrabalho.FirstOrDefault(ct => ct.Ativo).ContratoTrabalho, null)
                    && funcionario.CarteiraTrabalho.FirstOrDefault(ct => ct.Ativo).ContratoTrabalho?.Count > 0)
                {
                    model.IdContratoTrabalho = funcionario.CarteiraTrabalho
                                                      .FirstOrDefault(ct => ct.Ativo)
                                                      .ContratoTrabalho
                                                      .FirstOrDefault(ct => ct.Ativo).Id;
                }
            }
            
            model.Nome = funcionario.Nome;
            model.CPF = funcionario.CPF;
            if (!ReferenceEquals(funcionario.LocalNascimento, null))
            {
                model.Cidade = funcionario.LocalNascimento.Cidade;
                model.Data = funcionario.LocalNascimento.Data;
                if (!ReferenceEquals(funcionario.LocalNascimento.Estado, null))
                {
                    model.Estado = funcionario.LocalNascimento.Estado.Nome;
                    model.SiglaEstado = funcionario.LocalNascimento.Estado.Sigla.ToString();
                }
            }

            return model;
        }
    }
}