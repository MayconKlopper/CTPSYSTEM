using System.Collections.Generic;

namespace CTPSYSTEM.Domain.Servicos
{
    public interface IFuncionarioGovernoService
    {
        void Cadastrar(Empresa empresa);

        void Cadastrar(Funcionario funcionario);

        void Cadastrar(CarteiraTrabalho carteiraTrabalho);

        IEnumerable<Empresa> RecuperaEmpresa();

        IEnumerable<Funcionario> RecuperaFuncionario();
    }
}