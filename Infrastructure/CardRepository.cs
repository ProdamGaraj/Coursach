using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class CardRepository : AuditableRepository<Card>, ICardRepository
    {
        private readonly AppDbContext _dbContext;

        public CardRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Card entity)
        {
            DbAdd(entity);
        }

        public void Delete(Card entity)
        {
            DbRemove(entity);
        }

        public Card Get(int id)
        {
            return DbGet(id);
        }


        public void Update(Card entity)
        {
            DbUpdate(entity);
        }
    }
}
