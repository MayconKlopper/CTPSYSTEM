using CTPSYSTEM.Domain;
using System;

namespace CTPSYSTEM.Views.WebAPI.Models.RequestModels
{
    public class AddCarteiraTrabalhoModel
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

        public AddEstrangeiroModel Estrangeiro { get; set; }

        public static implicit operator CarteiraTrabalho(AddCarteiraTrabalhoModel model)
        {
            if(ReferenceEquals(model, null))
            {
                return null;
            }
            CarteiraTrabalho carteiraTrabalho = new CarteiraTrabalho();
            carteiraTrabalho.Id = model.Id;
            carteiraTrabalho.IdFuncionario = model.IdFuncionario;
            carteiraTrabalho.Numero = model.Numero;
            carteiraTrabalho.NumeroDocumento = model.NumeroDocumento;
            carteiraTrabalho.Serie = model.Serie;
            carteiraTrabalho.DataEmissao = DateTime.Now;
            carteiraTrabalho.FiliacaoMae = model.FiliacaoMae;
            carteiraTrabalho.FiliacaoPai = model.FiliacaoPai;
            carteiraTrabalho.Foto = model.Foto;
            carteiraTrabalho.Ativo = model.Ativo;
            if(!ReferenceEquals(model.Estrangeiro, null))
            {
                carteiraTrabalho.Estrangeiro = model.Estrangeiro;
            }
            return carteiraTrabalho;
        }
    }
}