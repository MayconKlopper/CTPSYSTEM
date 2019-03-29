using CTPSYSTEM.Domain.Historico;

using System;
using System.Linq.Expressions;

namespace CTPSYSTEM.Domain.Dados
{
    public interface IEmpresaStorage : IBaseStorage<ContratoTrabalho>
    {
        void Insert(AlteracaoSalarial alteracaoSalarial);

        void Insert(ContribuicaoSindical contribuicaoSindical);

        void Insert(AnotacaoGeral anotacaoGeral);

        void Insert(Ferias ferias);

        void Insert(Licenca licenca);

        void Insert(Internacao internacao);

        void Insert(FGTS fgts);

        void Insert(EmpresaHistorico empresaHistorico);

        void Insert(FuncionarioHistorico funcionarioHistorico);

        void Update(Funcionario funcionario, params Expression<Func<Funcionario, object>>[] expressions);
    }
}