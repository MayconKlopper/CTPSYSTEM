using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain.Servicos
{
    public interface IFuncionarioService
    {
        void GerarHash(int idFuncionario, int idCarteiraTrabalho, int idEmpresa);
    }
}
