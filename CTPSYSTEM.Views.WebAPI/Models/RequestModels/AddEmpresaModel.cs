using CTPSYSTEM.Domain;

using System.Collections.Generic;

namespace CTPSYSTEM.Views.WebAPI.Models.RequestModels
{
    public class AddEmpresaModel
    {
        /// <summary>
        /// CNPJ da empresa
        /// </summary>
        public string CNPJ { get; set; }

        /// <summary>
        /// Nome fantasia da empresa
        /// </summary>
        public string NomeFantasia { get; set; }

        /// <summary>
        /// Razão social da empresa
        /// </summary>
        public string RazaoSocial { get; set; }

        /// <summary>
        /// Tipo do seguimento da empresa
        /// </summary>
        public string Seguimento { get; set; }

        /// <summary>
        /// Cidade do endereço
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// Rua do endereço
        /// </summary>
        public string Rua { get; set; }

        /// <summary>
        /// Número da rua
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// Sala ou salas do edifício
        /// </summary>
        public string Sala { get; set; }

        /// <summary>
        /// Identificador único do estado ao qual
        /// este endereço esta vinculado
        /// </summary>
        public int IdEstado { get; set; }

        public static implicit operator Empresa(AddEmpresaModel model)
        {
            if (ReferenceEquals(model, null))
            {
                return null;
            }

            Empresa empresa = new Empresa();

            empresa.CNPJ = model.CNPJ;
            empresa.NomeFantasia = model.NomeFantasia;
            empresa.RazaoSocial = model.RazaoSocial;
            empresa.Seguimento = model.Seguimento;
            empresa.Endereco = new List<Endereco>();
            Endereco endereco = new Endereco();
            endereco.Cidade = model.Cidade;
            endereco.Rua = model.Cidade;
            endereco.Numero = model.Numero;
            endereco.Sala = model.Sala;
            endereco.IdEstado = model.IdEstado;
            empresa.Endereco.Add(endereco);

            return empresa;

        }
    }
}