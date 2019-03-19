﻿using System;
using System.Linq.Expressions;

namespace CTPSYSTEM.Domain.Dados
{
    public interface IBaseStorage<Entity> where Entity : class
    {
        void Insert(Entity obj);

        /// <summary>
        /// Método que atualiza uma ou várias propriedades de um objeto
        /// </summary>
        /// <param name="item">objeto cujo as propriedades serão atualizadas</param>
        /// <param name="expressions">propriedades do obejtos que serao atualizadas</param>
        void Update(Entity item, params Expression<Func<Entity, object>>[] expressions);

        void Delete(Entity obj);

        int SaveChanges();
    }
}