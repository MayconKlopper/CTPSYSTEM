using System;

namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Entidade que representa o endereço do local de um local de nascimento
    /// </summary>
    public class LocalNascimento
    {
        /// <summary>
        /// Identificador único do local de nascimento
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome da cidade
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// Sigla do estado
        /// </summary>
        public string Estado { get; set; }

        /// <summary>
        /// Data de nascimento
        /// </summary>
        public DateTime Data { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Carteira de trabalho vinculada ao local de nascimento do funcionário
        /// </summary>
        public virtual CarteiraTrabalho CarteiraTrabalho { get; set; }

        #endregion
    }
}