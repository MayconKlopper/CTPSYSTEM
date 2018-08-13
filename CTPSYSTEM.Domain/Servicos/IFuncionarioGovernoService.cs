using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain.Servicos
{
    public interface IFuncionarioGovernoService
    {
        void CadastrarEmpresa(Empresa empresa);

        void CadastrarFuncionario(Funcionario funcionario);

        void CadastrarCarteiraTrabalho(int idFuncionario);
    }
}
