using System;

namespace CTPSYSTEM.Domain.Historico
{
    /// <summary>
    /// Entidade que representa histórico de funcionário que já foram vinculados
    /// a uma empresa
    /// </summary>
    public class FuncionarioHistorico
    {
        /// <summary>
        /// Identificador único do registro de histório no sistema
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único da empresa ao qual
        /// este registro de histórico está vinculado
        /// </summary>
        public int? IdEmpresa { get; set; }

        /// <summary>
        /// Identificador único do registro de funcionário
        /// </summary>
        public int IdFuncionario { get; set; }

        /// <summary>
        /// Nome do funcionário
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// CPF do funcionário
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        /// Data de inserção do registro de histórico no sistema
        /// também é data que ocorreu a ação de desvinculamento do funcionário ao registro de empresa
        /// </summary>
        public DateTimeOffset Data { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Registro de empresa ao qual o registro de histórico está vinculado
        /// </summary>
        public virtual Empresa Empresa { get; set; }

        #endregion
    }
}
