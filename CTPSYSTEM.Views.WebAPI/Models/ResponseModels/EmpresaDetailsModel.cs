using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Enumeradores;
using CTPSYSTEM.Domain.Historico;

using System.Linq;

namespace CTPSYSTEM.Views.WebAPI.Models.ResponseModels
{
    public class EmpresaDetailsModel
    {
        /// <summary>
        /// Identificador único da empresa cadastrada no sistema
        /// </summary>
        public int Id { get; set; }

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
        /// Nome do estado
        /// </summary>
        public string Estado { get; set; }

        /// <summary>
        /// Sigla do estado
        /// </summary>
        public EstadoSigla SiglaEstado { get; set; }

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

        public static implicit operator EmpresaDetailsModel(Empresa empresa)
        {
            EmpresaDetailsModel model = new EmpresaDetailsModel();

            model.Id = empresa.Id;
            model.CNPJ = empresa.CNPJ;
            model.RazaoSocial = empresa.RazaoSocial;
            model.NomeFantasia = empresa.NomeFantasia;
            model.Seguimento = empresa.Seguimento;
            model.Estado = empresa.Endereco.FirstOrDefault().Estado.Nome;
            model.SiglaEstado = empresa.Endereco.FirstOrDefault().Estado.Sigla;
            model.Cidade = empresa.Endereco.FirstOrDefault().Cidade;
            model.Rua = empresa.Endereco.FirstOrDefault().Rua;
            model.Numero = empresa.Endereco.FirstOrDefault().Numero;
            model.Sala = empresa.Endereco.FirstOrDefault().Sala;

            return model;
        }

        public static implicit operator EmpresaDetailsModel(EmpresaHistorico empresa)
        {
            EmpresaDetailsModel model = new EmpresaDetailsModel();

            model.Id = empresa.Id;
            model.CNPJ = empresa.CNPJ;
            model.RazaoSocial = empresa.RazaoSocial;
            model.NomeFantasia = empresa.NomeFantasia;

            return model;
        }
    }
}