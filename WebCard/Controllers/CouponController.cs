using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entities;
using Infrastructure;
namespace WebCard.Controllers
{
    [Route("html/[controller]")]
    public class CouponController : Controller
    {
        private ICouponRepository _couponRepository { get; set; }
        // GET: HomeController
        public CouponController(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
          
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View(new List<Coupon>());
        }
        [HttpGet("{id}")]

        // GET: HomeController/Details/5
        public ActionResult Get(int id)
        {
            return View(_couponRepository.Get(id));
        }
        [HttpGet("add")]
        // GET: HomeController/Create
        public ActionResult Add()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost("add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add([FromForm] Coupon coupon)
        {
            try
            {
                _couponRepository.Add(coupon);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        [HttpGet("remove/{id}")]
        public ActionResult Remove(int id)
        {
            return View(_couponRepository.Get(id));
        }

        // POST: HomeController/Delete/5
        [HttpPost("remove/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(int id, [FromForm] Coupon coupon)
        {
            try
            {
                _couponRepository.Remove(coupon);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
