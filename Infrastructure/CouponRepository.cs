﻿using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class CouponRepository : AuditableRepository<Coupon>, ICouponRepository
    {
        private readonly AppDbContext _dbContext;


        public CouponRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}