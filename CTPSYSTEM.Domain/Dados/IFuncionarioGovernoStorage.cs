using System;
using System.Linq.Expressions;

namespace CTPSYSTEM.Domain.Dados
{
    public interface IFuncionarioGovernoStorage : IBaseStorage<CarteiraTrabalho>
    {
        void Insert(Funcionario funcionario);

        void Insert(Empresa empresa);

        /// <summary>
        /// Método que atualiza uma ou várias propriedades de um objeto
        /// </summary>
        /// <typeparam name="T">tipo genérico</typeparam>
        /// <param name="item">objeto cujo as propriedades serão atualizadas</param>
        /// <param name="expressions">propriedades do obejtos que serao atualizadas</param>
        void Update<T>(T item, params Expression<Func<T, object>>[] expressions) where T : class;
    }
}