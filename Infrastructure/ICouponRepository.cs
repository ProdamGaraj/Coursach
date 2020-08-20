using Entities;
using Infrastructure.CRUDInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public interface ICouponRepository : IAddable<Coupon>, IReadable<Coupon>, IRemovable<Coupon>, IGiveAll<Coupon>
    {
    }
}