using System;

namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Entidade que representa um registro de alteração salarial
    /// </summary>
    public class AlteracaoSalarial
    {
        /// <summary>
        /// Identificador único do registro de alteração salarial
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único do contrato de trabalho ao qual
        /// esta alteração salarial está vinculada
        /// </summary>
        public int IdContratoTrabalho { get; set; }

        /// <summary>
        /// Data que ocorreu o aumeto salarial
        /// </summary>
        public DateTime DataAumento { get; set; }

        /// <summary>
        /// Valor de remuneração em decimal
        /// </summary>
        public decimal Remuneracao { get; set; }

        /// <summary>
        /// Valor de remuneração escrita por extenso
        /// </summary>
        public string RemuneracaoExtenso { get; set; }

        /// <summary>
        /// Cargo para o qual o funcionário foi promovido
        /// </summary>
        public string Cargo { get; set; }

        /// <summary>
        /// Motivo do aumento salarial
        /// </summary>
        public string Motivo { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Registro de contrato de trabalho ao qual
        /// esta alteração salarial está vinculada
        /// </summary>
        public virtual ContratoTrabalho ContratoTrabalho { get; set; }

        #endregion
    }
}
