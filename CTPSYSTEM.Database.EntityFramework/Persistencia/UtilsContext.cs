using CTPSYSTEM.Database.EntityFramework.FonteDados;
using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Dados;

using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Database.EntityFramework.Persistencia
{
    public class UtilsContext : IUtilsReadOnlyStorage
    {
        private readonly Conexao conexao;

        public UtilsContext(Conexao conexao)
        {
            this.conexao = conexao;
        }

        public IEnumerable<Estado> RecuperaEstados()
        {
            return this.conexao.Estado;
        }
    }
}
