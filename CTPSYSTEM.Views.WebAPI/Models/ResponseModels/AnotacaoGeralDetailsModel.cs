using CTPSYSTEM.Domain;

namespace CTPSYSTEM.Views.WebAPI.Models.ResponseModels
{
    public class AnotacaoGeralDetailsModel
    {
        /// <summary>
        /// Identificador único da anotação geral
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único do contrato de trabalho ao qual
        /// esta anotação geral está vinculada
        /// </summary>
        public int IdContratoTrabalho { get; set; }

        /// <summary>
        /// Texto da anotação geral
        /// </summary>
        public string Texto { get; set; }

        public static implicit operator AnotacaoGeralDetailsModel(AnotacaoGeral anotacaoGeral)
        {
            AnotacaoGeralDetailsModel model = new AnotacaoGeralDetailsModel();

            model.Id = anotacaoGeral.Id;
            model.IdContratoTrabalho = anotacaoGeral.IdContratoTrabalho;
            model.Texto = anotacaoGeral.Texto;

            return model;
        }
    }
}