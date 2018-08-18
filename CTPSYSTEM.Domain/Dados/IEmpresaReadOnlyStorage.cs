using CTPSYSTEM.Domain.Historico;

using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain.Dados
{
    public interface IEmpresaReadOnlyStorage
    {
        Empresa RecuperaEmpresa(string CNPJ);

        IEnumerable<Funcionario> RecuperaFuncionarios(int idEmpresa);
        Funcionario RecuperaFuncionario(int idFuncionario);

        IEnumerable<FuncionarioHistorico> RecuperaHistoricoFuncionario(int idEmpresa);
    }
}
