using CTPSYSTEM.Domain;

namespace CTPSYSTEM.Views.WebAPI.Models.RequestModels
{
    public class AddContribuicaoSindicalModel
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

        public static implicit operator ContribuicaoSindical(AddContribuicaoSindicalModel model)
        {
            if (ReferenceEquals(model, null))
            {
                return null;
            }

            ContribuicaoSindical contribuicaoSindical = new ContribuicaoSindical();

            contribuicaoSindical.Ano = model.Ano;
            contribuicaoSindical.NomeSindicato = model.NomeSindicato;
            contribuicaoSindical.ValorContribuicao = model.ValorContribuicao;
            contribuicaoSindical.IdContratoTrabalho = model.IdContratoTrabalho;

            return contribuicaoSindical;
        }
    }
}