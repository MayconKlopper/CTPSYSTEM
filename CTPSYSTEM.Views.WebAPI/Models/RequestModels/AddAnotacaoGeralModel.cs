using CTPSYSTEM.Domain;

namespace CTPSYSTEM.Views.WebAPI.Models.RequestModels
{
    public class AddAnotacaoGeralModel
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

        public static implicit operator AnotacaoGeral(AddAnotacaoGeralModel model)
        {
            AnotacaoGeral anotacaoGeral = new AnotacaoGeral();

            anotacaoGeral.Texto = model.Texto;
            anotacaoGeral.IdContratoTrabalho = model.IdContratoTrabalho;

            return anotacaoGeral;
        }
    }
}