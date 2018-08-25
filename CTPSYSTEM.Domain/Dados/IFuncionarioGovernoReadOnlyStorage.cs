using System.Collections.Generic;

namespace CTPSYSTEM.Domain.Dados
{
    public interface IFuncionarioGovernoReadOnlyStorage
    {
        IEnumerable<Empresa> RecuperaEmpresa();

        IEnumerable<Funcionario> RecuperaFuncionario();
    }
}