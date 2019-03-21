using System;
using System.Linq.Expressions;

namespace CTPSYSTEM.Domain.Dados
{
    public interface IEmpresaStorage : IBaseStorage<ContratoTrabalho>
    {
        void Insert(AlteracaoSalarial alteracaoSalarial);

        void Insert(ContribuicaoSindical contribuicaoSindical);

        void Insert(AnotacaoGeral anotacaoGeral);

        void Insert(FGTS fgts);

        void Insert(Ferias ferias);

        void Insert(Licenca licenca);

        void Insert(Internacao internacao);

        /// <summary>
        /// Método que atualiza uma ou várias propriedades de um objeto
        /// </summary>
        /// <param name="funcionario">objeto cujo as propriedades serão atualizadas</param>
        /// <param name="expressions">propriedades do obejtos que serao atualizadas</param>
        void Update(Funcionario funcionario, params Expression<Func<Funcionario, object>>[] expressions);
    }
}