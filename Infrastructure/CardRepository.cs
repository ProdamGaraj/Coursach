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
    }
}