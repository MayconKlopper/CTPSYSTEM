using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain.Servicos
{
    public interface IHashService
    {
        void verificarVlidadeHash(string hashCode);
    }
}
