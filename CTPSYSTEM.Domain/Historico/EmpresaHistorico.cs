using System;

namespace CTPSYSTEM.Domain.Historico
{
    /// <summary>
    /// Entidade que representa histórico de empresas que já foram
    /// vinculados a um funcionário
    /// </summary>
    public class EmpresaHistorico
    {
        public EmpresaHistorico()
        {

        }

        public EmpresaHistorico(int idEmpresa, int idFuncionario, string CNPJ, string nomeFantasia, string razaoSocial, DateTimeOffset data)
        {
            this.IdFuncionario = idFuncionario;
            this.IdEmpresa = idEmpresa;
            this.CNPJ = CNPJ;
            this.NomeFantasia = nomeFantasia;
            this.RazaoSocial = razaoSocial;
            this.Data = data;
        }

        /// <summary>
        /// Identificador único do registro de histórico no sistema
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único do funcionário
        /// ao qual este registro de histórico está vinculado
        /// </summary>
        public int? IdFuncionario { get; set; }

        /// <summary>
        /// Identificador único da empresa
        /// </summary>
        public int IdEmpresa { get; set; }

        /// <summary>
        /// CNPJ da empresa
        /// </summary>
        public string CNPJ { get; set; }

        /// <summary>
        /// Nome Fantasia da empresa
        /// </summary>
        public string NomeFantasia { get; set; }

        /// <summary>
        /// Razão social da empresa
        /// </summary>
        public string RazaoSocial { get; set; }

        /// <summary>
        /// Data de inserção do registro de histórico no sistema
        /// também é data que ocorreu a ação de desvinculamento do funcionário ao registro de empresa
        /// </summary>
        public DateTimeOffset Data { get; set; }

        #region Relacionamento

        /// <summary>
        /// Registro de funcionário ao qual o registro de histórico está vinculado
        /// </summary>
        public virtual Funcionario Funcionario { get; set; }

        #endregion Relacionamento
    }
}