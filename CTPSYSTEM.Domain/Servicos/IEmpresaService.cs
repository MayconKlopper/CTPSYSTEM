using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain.Servicos
{
    public interface IEmpresaService
    {
        void CadastrarContratoTrabalho(ContratoTrabalho contratoTrabalho);

        void VincularFuncionario(int idFuncionario);

        void DesvincularFuncionario(int idFuncionario);
    }
}
