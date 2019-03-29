using CTPSYSTEM.Domain.Historico;

using System;

namespace CTPSYSTEM.Views.WebAPI.Models.ResponseModels
{
    public class FuncionarioHistoricoDetailsModel
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTimeOffset Data { get; set; }

        public static implicit operator FuncionarioHistoricoDetailsModel(FuncionarioHistorico funcionarioHistorico)
        {
            FuncionarioHistoricoDetailsModel model = new FuncionarioHistoricoDetailsModel();

            model.Nome = funcionarioHistorico.Nome;
            model.CPF = funcionarioHistorico.CPF;
            model.Data = funcionarioHistorico.Data;

            return model;
        }
    }
}
