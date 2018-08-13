using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain
{
    public class Hash
    {
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
        /// Identificador único da empresa para o qual
        /// este Hash foi gerado
        /// </summary>
        public int IdEmpresa { get; set; }

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
