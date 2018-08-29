using CTPSYSTEM.Domain;

using System;

namespace CTPSYSTEM.Views.WebAPI.Models.ResponseModels
{
    public class CarteiraTrabalhoDetailsModel
    {
        /// <summary>
        /// Identificador único da carteira de trabalho
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Idenificador único do funcionário ao qual
        /// esta carteira de trabalho está vinculada
        /// </summary>
        public int IdFuncionario { get; set; }

        /// <summary>
        /// Número da carteira de trabalho
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// Número do documento da carteira de trabalho
        /// </summary>
        public string NumeroDocumento { get; set; }

        /// <summary>
        /// Série da carteira de trabalho
        /// </summary>
        public string Serie { get; set; }

        /// <summary>
        /// Data de emissão da carteira de trabalho
        /// </summary>
        public DateTime DataEmissao { get; set; }

        /// <summary>
        /// Foto do funcionário
        /// </summary>
        public string Foto { get; set; }

        /// <summary>
        /// Nome do pai do funcionário
        /// </summary>
        public string FiliacaoPai { get; set; }

        /// <summary>
        /// Nome da mãe do funcionário
        /// </summary>
        public string FiliacaoMae { get; set; }

        /// <summary>
        /// Indica se esta carteria de trabalho é a carteira atual
        /// do funcionário
        /// </summary>
        public bool Ativo { get; set; }

        public static implicit operator CarteiraTrabalhoDetailsModel(CarteiraTrabalho carteiraTrabalho)
        {
            CarteiraTrabalhoDetailsModel model = new CarteiraTrabalhoDetailsModel();

            model.Id = carteiraTrabalho.Id;
            model.IdFuncionario = carteiraTrabalho.IdFuncionario;
            model.Numero = carteiraTrabalho.Numero;
            model.NumeroDocumento = carteiraTrabalho.NumeroDocumento;
            model.Serie = carteiraTrabalho.Serie;
            model.DataEmissao = carteiraTrabalho.DataEmissao;
            model.Foto = carteiraTrabalho.Foto;
            model.FiliacaoPai = carteiraTrabalho.FiliacaoPai;
            model.FiliacaoMae = carteiraTrabalho.FiliacaoMae;

            return model;
        }
    }
}
