using CTPSYSTEM.Domain.Servicos;
using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Dados;

using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Application
{
    public class FuncionarioGovernoService : IFuncionarioGovernoService
    {
        private readonly IFuncionarioGovernoStorage funcionarioGovernoStorage;

        public FuncionarioGovernoService(IFuncionarioGovernoStorage funcionarioGovernoStorage)
        {
            this.funcionarioGovernoStorage = funcionarioGovernoStorage;
        }

        public void Cadastrar(CarteiraTrabalho carteiraTrabalho)
        {
            this.funcionarioGovernoStorage.Insert(carteiraTrabalho);
            this.funcionarioGovernoStorage.SaveChanges();
        }

        public void Cadastrar(Empresa empresa)
        {
            this.funcionarioGovernoStorage.Insert(empresa);
            this.funcionarioGovernoStorage.SaveChanges();
        }

        public void Cadastrar(Funcionario funcionario)
        {
            this.funcionarioGovernoStorage.Insert(funcionario);
            this.funcionarioGovernoStorage.SaveChanges();
        }
    }
}
