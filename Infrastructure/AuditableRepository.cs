using Entities;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public abstract class AuditableRepository<TEntity> : Repository<TEntity> where TEntity : AuditableEntity
    {
        public AuditableRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
        public override void DbAdd(TEntity entity)
        {
            entity.CreatedAt = DateTime.Now;
            base.DbAdd(entity);
            SaveChanges();
        }

        public override void DbUpdate(TEntity entity)
        {
            entity.ModifiedAt = DateTime.Now;
            base.DbUpdate(entity);
            SaveChanges();
        }
        public override void DbRemove(TEntity entity)
        {
            base.DbRemove(entity);
            SaveChanges();
        }
    }
}
