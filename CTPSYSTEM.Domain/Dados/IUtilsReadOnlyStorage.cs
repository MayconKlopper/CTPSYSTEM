﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain.Dados
{
    public interface IUtilsReadOnlyStorage
    {
        IEnumerable<Estado> RecuperaEstados();
    }
}
