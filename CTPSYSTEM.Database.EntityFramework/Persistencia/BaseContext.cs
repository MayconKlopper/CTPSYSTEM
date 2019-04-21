﻿using CTPSYSTEM.Database.EntityFramework.FonteDados;
using CTPSYSTEM.Domain.Dados;

using System;
using System.Linq.Expressions;

namespace CTPSYSTEM.Database.EntityFramework.Persistencia
{
    public class BaseContext<Entity> : IBaseStorage<Entity>
        where Entity : class
    {
        protected readonly Conexao conexao;

        public BaseContext(Conexao conexao)
        {
            this.conexao = conexao;
        }

        public void Insert(Entity obj)
        {
            conexao.Add(obj);
        }

        public void Update(Entity item, params Expression<Func<Entity, object>>[] expressions)
        {
            var x = this.conexao.Attach(item);
            foreach (var expression in expressions)
            {
                x.Property(expression).IsModified = true;
            }
        }

        public void Delete(Entity obj)
        {
            conexao.Remove(obj);
        }

        public int SaveChanges()
        {
            return conexao.SaveChanges();
        }
    }
}