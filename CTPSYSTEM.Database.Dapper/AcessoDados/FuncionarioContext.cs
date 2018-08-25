using CTPSYSTEM.Domain.DapperModels;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace CTPSYSTEM.Database.Dapper.Persistence
{
    public class FuncionarioContext
    {
        private readonly string sqlServerConnection;

        public FuncionarioContext(IConfiguration configuration)
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