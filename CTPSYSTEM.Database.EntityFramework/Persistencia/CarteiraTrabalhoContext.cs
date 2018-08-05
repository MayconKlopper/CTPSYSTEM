using CTPSYSTEM.Database.EntityFramework.FonteDados;
using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Dados;

using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Database.EntityFramework.Persistence
{
    public class CarteiraTrabalhoContext : BaseContext<CarteiraTrabalho>, ICarteiraTrabalhoStorage
    {
        public CarteiraTrabalhoContext(Conexao conexao) : base(conexao)
        {

        }
    }
}
