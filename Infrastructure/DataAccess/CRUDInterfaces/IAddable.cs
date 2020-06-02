using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataAccess.CRUDInterfaces
{
    public interface IAddable<TEntity> where TEntity: class
    {
        void Add(TEntity entity);
    }
}
