using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CRUDInterfaces
{
    public interface IGiveAll<TEntity> where TEntity : class
    {
        IList<TEntity> GetAll();
    }
}