using System.Collections.Generic;
using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Dados;
using CTPSYSTEM.Domain.Servicos;

namespace CTPSYSTEM.Application
{
    public class FuncionarioGovernoService : IFuncionarioGovernoService
    {
        private readonly IFuncionarioGovernoStorage funcionarioGovernoStorage;
        private readonly IFuncionarioGovernoReadOnlyStorage funcionarioGovernoReadOnlyStorage;

        public FuncionarioGovernoService(IFuncionarioGovernoStorage funcionarioGovernoStorage
            , IFuncionarioGovernoReadOnlyStorage funcionarioGovernoReadOnlyStorage)
        {
            this.funcionarioGovernoStorage = funcionarioGovernoStorage;
            this.funcionarioGovernoReadOnlyStorage = funcionarioGovernoReadOnlyStorage;
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

        public IEnumerable<Empresa> RecuperaEmpresa()
        {
            return this.funcionarioGovernoReadOnlyStorage.RecuperaEmpresa();
        }

        public IEnumerable<Funcionario> RecuperaFuncionario()
        {
            return this.funcionarioGovernoReadOnlyStorage.RecuperaFuncionario();
        }
    }
}