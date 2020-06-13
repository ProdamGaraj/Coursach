using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataAccess.CRUDInterfaces
{
    public interface IDelitable<TEntity> where TEntity:class
    {
        void Delete(TEntity entity);
    }
}
