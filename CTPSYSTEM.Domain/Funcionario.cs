using CTPSYSTEM.Domain.Historico;
using System.Collections.Generic;

namespace CTPSYSTEM.Domain
{
    /// <summary>
    /// Entidade que representa um funcionário no sistema
    /// </summary>
    public class Funcionario
    {
        public Funcionario()
        {
            this.CarteiraTrabalho = new List<CarteiraTrabalho>();
            this.LocalNascimento = new LocalNascimento();
        }

        /// <summary>
        /// Identificador único do funcionário
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único da empresa ao qual o funcionário está vinculado
        /// </summary>
        public int? IdEmpresa { get; set; }

        /// <summary>
        /// Nome do funcionário
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// CPF do funcionário
        /// </summary>
        public string CPF { get; set; }

        #region Relacionamentos

        /// <summary>
        /// Carteira de trabalho deste funcionário
        /// </summary>
        public virtual ICollection<CarteiraTrabalho> CarteiraTrabalho { get; set; }

        /// <summary>
        /// Empresa ao qual o funcionário está vinculado no momento
        /// </summary>
        public virtual Empresa Empresa { get; set; }

        /// <summary>
        /// Histórico de empresas ao qual este funcionário já foi
        /// vinculado
        /// </summary>
        public virtual ICollection<EmpresaHistorico> EmpresaHistorico { get; set; }

        /// <summary>
        /// Local de nascimento do funcionário
        /// </summary>
        public virtual LocalNascimento LocalNascimento { get; set; }

        #endregion Relacionamentos
    }
}