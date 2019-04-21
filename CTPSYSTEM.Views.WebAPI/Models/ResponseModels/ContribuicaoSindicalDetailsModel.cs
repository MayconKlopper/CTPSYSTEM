using CTPSYSTEM.Domain;

namespace CTPSYSTEM.Views.WebAPI.Models.ResponseModels
{
    public class ContribuicaoSindicalDetailsModel
    {
        /// <summary>
        /// Identificador único da contribuição sindical
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único do contrato de trabalho ao qual este
        /// registro de contribuição sindical está vinculado
        /// </summary>
        public int IdContratoTrabalho { get; set; }

        /// <summary>
        /// Valor da contribuição sindical
        /// </summary>
        public decimal ValorContribuicao { get; set; }

        /// <summary>
        /// Nome do sindicato ao qual esta contribuição pertence
        /// </summary>
        public string NomeSindicato { get; set; }

        /// <summary>
        /// Ano da contribuição
        /// </summary>
        public int Ano { get; set; }

        public static implicit operator ContribuicaoSindicalDetailsModel(ContribuicaoSindical contribuicaoSindical)
        {
            if (ReferenceEquals(contribuicaoSindical, null))
            {
                return null;
            }

            ContribuicaoSindicalDetailsModel model = new ContribuicaoSindicalDetailsModel();

            model.Id = contribuicaoSindical.Id;
            model.IdContratoTrabalho = contribuicaoSindical.IdContratoTrabalho;
            model.ValorContribuicao = contribuicaoSindical.ValorContribuicao;
            model.NomeSindicato = contribuicaoSindical.NomeSindicato;
            model.Ano = contribuicaoSindical.Ano;

            return model;
        }
    }
}