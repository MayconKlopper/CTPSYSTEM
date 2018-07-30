using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain.Enums
{
    /// <summary>
    /// Enumerador com todos os possíveis estados civis
    /// </summary>
    public enum EstadoCivil
    {
        /// <summary>
        /// Pessoa que nunca se casou ou teve o casamento anulado
        /// </summary>
        Solteiro = 1,
        /// <summary>
        /// Pessoa que contraiu matrimônio, independente do regime de bens adotado
        /// </summary>
        Casado = 2,
        /// <summary>
        /// Pessoa que não vive mais com o cônjuge (vive em separação física dele), mas que ainda não obteve o divórcio
        /// </summary>
        Separado = 3,
        /// <summary>
        /// Após a homologação do divórcio pela justiça ou por uma escritura pública
        /// </summary>
        Divorciado = 4,
        /// <summary>
        /// Pessoa cujo cônjuge faleceu
        /// </summary>
        Viuvo = 5
    }
}
