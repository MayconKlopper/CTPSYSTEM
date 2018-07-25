using System;

namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Entidade que representa uma carteira de trabalho no sistema
    /// </summary>
    public class CarteiraTrabalho
    {
        /// <summary>
        /// Identificador único da carteira de trabalho
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Identificador único do local de nascimento vinculado a esta carteira de trabalho
        /// </summary>
        public int IdLocalNascimento { get; set; }
        /// <summary>
        /// Número da carteira de trabalho
        /// </summary>
        public int Numero { get; set; }
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

        #region Relacionamentos

        /// <summary>
        /// Entidade funcionário possuidor desta carteira de trabalho
        /// </summary>
        public virtual Funcionario funcionario { get; set; }

        /// <summary>
        /// Endereço do local de nascimento do funcionário
        /// </summary>
        public virtual LocalNascimento localNascimento { get; set; }

        /// <summary>
        /// Registro de estrangeiro portador de uma carteira de trabalho
        /// </summary>
        public virtual Estrangeiro Estrangeiro { get; set; }

        #endregion
    }
}
