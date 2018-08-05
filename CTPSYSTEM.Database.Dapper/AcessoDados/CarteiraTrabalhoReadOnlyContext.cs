using CTPSYSTEM.Domain.Dados;
using CTPSYSTEM.Domain.DapperModels;

using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace CTPSYSTEM.Database.Dapper.Persistence
{
    public class CarteiraTrabalhoReadOnlyContext : ICarteiraTrabalhoReadOnlyStorage
    {
        private readonly string sqlServerConnection;

        public CarteiraTrabalhoReadOnlyContext(IConfiguration configuration)
        {
            this.sqlServerConnection = configuration.GetConnectionString("SqlServerConnection");
        }

        public CarteiraTrabalhoDetalhadaModel RecuperaCarteiraTrabalhoDetalhada(int idFuncionario)
        {
            using (SqlConnection conexao = new SqlConnection(this.sqlServerConnection))
            {
                return conexao.QueryFirstOrDefault<CarteiraTrabalhoDetalhadaModel>(ArquivosRecurso.Queries.RecuperaCarteiraTrabalhoDetalhada, idFuncionario);
            }
        }
    }
}
