using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain
{
    public class Hash
    {
        public Hash()
        {

        }

        public Hash(string hashCode, int idFuncionario, int idCarteiraTrabalho, DateTime DataGeracao, DateTime DataExpiracao)
        {
            this.HashCode = hashCode;
            this.IdFuncionario = idFuncionario;
            this.IdCarteiraTrabalho = idCarteiraTrabalho;
            this.DataGeracao = DataGeracao;
            this.DataExpiracao = DataExpiracao;
            this.Ativo = true;
        }

        /// <summary>
        /// Identificador único do Hash de 
        /// autenticação de inserção
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Código do Hash Gerado
        /// </summary>
        public string HashCode { get; set; }

        /// <summary>
        /// Identificador único do funcionário
        /// que gerou este Hash
        /// </summary>
        public int IdFuncionario { get; set; }

        /// <summary>
        /// Identificador único da carteira de trabalho
        /// ao qual este Hash permitirá inserção de novos dados
        /// </summary>
        public int IdCarteiraTrabalho { get; set; }

        /// <summary>
        /// Data em que o funcionário gerou o Hash
        /// </summary>
        public DateTime DataGeracao { get; set; }

        /// <summary>
        /// Data em que o Hash deixará de ser válido
        /// </summary>
        public DateTime DataExpiracao { get; set; }

        /// <summary>
        /// Indica se o Hash gerado já foi usado ou
        /// já expirou
        /// </summary>
        public bool Ativo { get; set; }
    }
}
