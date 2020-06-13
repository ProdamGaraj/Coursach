using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataAccess
{
    public abstract class Repository<TEntity> where TEntity : class
    {
        protected readonly AppDbContext DbContext;
        public Repository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public virtual TEntity DbGet(int id)
        {
            return DbContext.Find<TEntity>(id);
        }

        public virtual void DbAdd(TEntity entity)
        {
            DbContext.Add(entity);
        }

        public virtual void DbUpdate(TEntity entity)
        {
            DbContext.Update(entity);
        }

        public virtual void DbRemove(TEntity entity)
        {
            DbContext.Remove(entity);
        }

        public int SaveChanges()
        {
            return DbContext.SaveChanges();
        }
    }
}
