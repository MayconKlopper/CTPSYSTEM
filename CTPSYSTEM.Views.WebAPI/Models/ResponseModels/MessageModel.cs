namespace CTPSYSTEM.Views.WebAPI.Models.ResponseModels
{
    public class MessageModel
    {
        public MessageModel()
        {

        }

        public MessageModel(int tipo, string texto)
        {
            this.tipo = tipo;
            this.Texto = texto;
        }

        /// <summary>
        /// tipo da mensagem onde
        /// 1 significa que é uma mensagem de erro
        /// 2 significa que é uma mensagem de sucesso
        /// </summary>
        public int tipo { get; set; }

        /// <summary>
        /// Texto da mensagem
        /// </summary>
        public string Texto { get; set; }

        public static implicit operator MessageModel((int, string) model)
        {
            if (ReferenceEquals(model, null))
            {
                return null;
            }

            return new MessageModel(model.Item1, model.Item2);
        }
    }
}