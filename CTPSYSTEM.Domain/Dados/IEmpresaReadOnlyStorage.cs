using CTPSYSTEM.Domain.Historico;
using System.Collections.Generic;

namespace CTPSYSTEM.Domain.Dados
{
    public interface IEmpresaReadOnlyStorage
    {
        Empresa RecuperaEmpresa(string CNPJ);

        Empresa RecuperaEmpresa(int idEmpresa);

        IEnumerable<Funcionario> RecuperaFuncionarios(int idEmpresa);

        IEnumerable<FuncionarioHistorico> RecuperaHistoricoFuncionarios(int idEmpresa);

        Funcionario RecuperaFuncionario(int idFuncionario);

        ContratoTrabalho RecuperaContratoTrabalho(int idContratoTrabalho);
    }
}