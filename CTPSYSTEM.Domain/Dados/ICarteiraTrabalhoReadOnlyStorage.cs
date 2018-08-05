using CTPSYSTEM.Domain.DapperModels;

using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain.Dados
{
    public interface ICarteiraTrabalhoReadOnlyStorage
    {
        CarteiraTrabalhoDetalhadaModel RecuperaCarteiraTrabalhoDetalhada(int idFuncionario);
    }
}