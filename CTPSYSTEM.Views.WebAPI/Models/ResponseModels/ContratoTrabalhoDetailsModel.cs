using CTPSYSTEM.Domain;

using System;

namespace CTPSYSTEM.Views.WebAPI.Models.ResponseModels
{
    public class ContratoTrabalhoDetailsModel
    {
        /// <summary>
        /// Identificador único do registro de contrato de trabalho
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único do registro de carteira trabalho
        /// ao qual este registro de contrato de trabalho está vinculado
        /// </summary>
        public int IdCarteiraTrabalho { get; set; }

        /// <summary>
        /// Identificador único da empresa ao qual este registro de
        /// contrato de trabalho está vinculado
        /// </summary>
        public int IdEmpresa { get; set; }

        /// <summary>
        /// Nome do cargo
        /// </summary>
        public string Cargo { get; set; }

        /// <summary>
        /// Número do CBO da empresa empregadora
        /// </summary>
        public int CBONumero { get; set; }

        /// <summary>
        /// Data de firmação do contrato de trabalho
        /// </summary>
        public DateTimeOffset DataAdmissao { get; set; }

        /// <summary>
        /// Data de finalização do contrato de trabalho
        /// </summary>
        public DateTimeOffset DataSaida { get; set; }

        /// <summary>
        /// Valor de remuneração em decimal
        /// </summary>
        public decimal Remuneracao { get; set; }

        /// <summary>
        /// Valor de remuneração escrita por extenso
        /// </summary>
        public string RemuneracaoExtenso { get; set; }

        /// <summary>
        /// FlsFicha da empresa empregadora. OBS: a maioria vem com o valor 0 que é o valor default
        /// </summary>
        public int FlsFicha { get; set; }

        /// <summary>
        /// Númeor de registro da empresa. OBS: a maioria vem com o valor 0 que é o valor default
        /// </summary>
        public int RegistroNumero { get; set; }

        /// <summary>
        /// Indica se o contrato de trabalho
        /// está ativo
        /// </summary>
        public bool Ativo { get; set; }

        public static implicit operator ContratoTrabalhoDetailsModel(ContratoTrabalho contratoTrabalho)
        {
            ContratoTrabalhoDetailsModel model = new ContratoTrabalhoDetailsModel();

            model.Id = contratoTrabalho.Id;
            model.IdCarteiraTrabalho = contratoTrabalho.IdCarteiraTrabalho;
            model.IdEmpresa = contratoTrabalho.IdEmpresa;
            model.Cargo = contratoTrabalho.Cargo;
            model.CBONumero = contratoTrabalho.CBONumero;
            model.DataAdmissao = contratoTrabalho.DataAdmissao;
            model.DataSaida = contratoTrabalho.DataSaida;
            model.Remuneracao = contratoTrabalho.Remuneracao;
            model.RemuneracaoExtenso = contratoTrabalho.RemuneracaoExtenso;
            model.FlsFicha = contratoTrabalho.FlsFicha;
            model.RegistroNumero = contratoTrabalho.RegistroNumero;
            model.Ativo = contratoTrabalho.Ativo;

            return model;
        }
    }
}