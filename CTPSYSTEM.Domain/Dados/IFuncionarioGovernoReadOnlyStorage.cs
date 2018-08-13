using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain.Dados
{
    public interface IFuncionarioGovernoReadOnlyStorage
    {
        IEnumerable<Empresa> RecuperaEmpresa();

        IEnumerable<Funcionario> RecuperaFuncionario();
    }
}
