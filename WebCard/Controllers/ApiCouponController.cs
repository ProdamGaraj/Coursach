using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponController : ControllerBase
    {
        private ICouponRepository _couponRepository { get; set; }

        public CouponController(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
        }

        [HttpGet]
        public ActionResult<Coupon> Get()
        {
            return _couponRepository.Get(1);
        }


        [HttpGet("{id}")]
        public Coupon Get(int id)
        {
            return _couponRepository.Get(id);
        }


        [HttpPost]
        public ActionResult Post([FromBody] Coupon card)
        {
            _couponRepository.Add(card);
            return Ok();
        }
    }
}