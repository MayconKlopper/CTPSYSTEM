using CTPSYSTEM.Domain.Historico;
using System.Collections.Generic;

namespace CTPSYSTEM.Domain.Dados
{
    public interface IEmpresaReadOnlyStorage
    {
        Empresa RecuperaEmpresa(string CNPJ);

        IEnumerable<Funcionario> RecuperaFuncionarios(int idEmpresa);

        Funcionario RecuperaFuncionario(int idFuncionario);

        ContratoTrabalho RecuperaContratoTrabalho(int idContratoTrabalho);

        IEnumerable<FuncionarioHistorico> RecuperaHistoricoFuncionario(int idEmpresa);
    }
}