using CTPSYSTEM.Domain.Enums;

using System;

namespace CTPSYSTEM.Domain.DapperModels
{
    public class CarteiraTrabalhoDetalhadaModel
    {

        public string NomeFuncionario { get; set; }

        public string CPF { get; set; }

        public int Numero { get; set; }

        public string Serie { get; set; }

        public string Foto { get; set; }

        public string NumeroDocumento { get; set; }

        public string FiliacaoPai { get; set; }

        public string filiacaoMae { get; set; }

        public DateTime DataEmissao { get; set; }

        public string CidadeNascimento { get; set; }

        public string SiglaEstadoNascimento { get; set; }
    }
}
