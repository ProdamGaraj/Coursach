using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CRUDInterfaces
{
    public interface IRemovable<TEntity> where TEntity : class
    {
        void Remove(TEntity entity);
    }
}