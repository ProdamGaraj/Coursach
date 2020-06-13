using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataAccess.CRUDInterfaces
{
    public interface IReadable<TEntity> where TEntity:class
    {
        TEntity Get(int id);
    }
}
