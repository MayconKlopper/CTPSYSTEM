using CTPSYSTEM.Domain.Enums;

using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Entidade que representa um dependente do funcionário
    /// </summary>
    public class Dependente
    {
        /// <summary>
        /// Identificador único do dependente
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// identificador único da carteira de trabalho
        /// </summary>
        public int IdCarteiraTrabalho { get; set; }
        /// <summary>
        /// Nome do dependente
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Estado civil do dependente
        /// </summary>
        public EstadoCivil EstadoCivil { get; set; }
        /// <summary>
        /// Idade do dependente
        /// </summary>
        public int Idade { get; set; }
        /// <summary>
        /// Grau de parentesco do dependente em relação com o funcionário
        /// </summary>
        public GrauParentesco GrauParentesco { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Carteira de trabalho vinculada ao dependente
        /// </summary>
        public virtual CarteiraTrabalho CarteiraTrabalho { get; set; }

        #endregion
    }
}
