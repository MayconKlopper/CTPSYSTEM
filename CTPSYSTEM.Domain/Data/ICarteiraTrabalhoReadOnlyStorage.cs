using CTPSYSTEM.Domain.DapperModels;

using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain.Data
{
    interface ICarteiraTrabalhoReadOnlyStorage
    {
        CarteiraTrabalhoDetalhadaModel getDetalhada(int idFuncionario);
    }
}