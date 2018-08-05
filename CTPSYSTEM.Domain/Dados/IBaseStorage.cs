using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain.Dados
{
    public interface IBaseStorage<Entity> where Entity : class
    {
        void Insert(Entity obj);

        int SaveChanges();
    }
}
