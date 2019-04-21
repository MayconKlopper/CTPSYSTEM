using CTPSYSTEM.Domain;
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
        /// Chave Única do estado ao qual o local de nascimento deste funcionário está
        /// vinculado
        /// </summary>
        public int IdEstado { get; set; }

        public static implicit operator Funcionario(AddFuncionarioModel model)
        {
            if (ReferenceEquals(model, null))
            {
                return null;
            }

            Funcionario funcionario = new Funcionario();

            funcionario.Nome = model.Nome;
            funcionario.CPF = model.CPF;
            funcionario.LocalNascimento = new LocalNascimento();
            funcionario.LocalNascimento.Cidade = model.Cidade;
            funcionario.LocalNascimento.Data = DateTime.Parse(model.Data.ToString("dd/MM/yyyy"));
            funcionario.LocalNascimento.IdEstado = model.IdEstado;

            return funcionario;
        }
    }
}