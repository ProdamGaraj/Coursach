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

        public override void Add(TEntity entity)
        {
            entity.CreatedAt = DateTime.Now;
            base.Add(entity);
            SaveChanges();
        }

        public override void Update(TEntity entity)
        {
            entity.ModifiedAt = DateTime.Now;
            base.Update(entity);
            SaveChanges();
        }

        public override void Remove(TEntity entity)
        {
            base.Remove(entity);
            SaveChanges();
        }
    }
}