using CTPSYSTEM.Domain.Historico;

using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain.Dados
{
    public interface IEmpresaReadOnlyStorage
    {
        Empresa RecuperaEmpresa(string CNPJ);

        IEnumerable<Funcionario> RecuperaFuncionario(int idEmpresa);

        IEnumerable<FuncionarioHistorico> RecuperaHistoricoFuncionario(int idEmpresa);
    }
}
