﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain.Servicos
{
    public interface IHashService
    {
        string GerarHash(int idFuncionario, int idCarteiraTrabalho);

        string verificaVlidadeHash(string hashCode,int idFuncionario, int idCarteiraTrabalho);
    }
}