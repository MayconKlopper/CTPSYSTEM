using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain.Data
{
    public interface BaseStorage<Entity> where Entity : class
    {
        void Insert(Entity obj);

        int SaveChanges();
    }
}
