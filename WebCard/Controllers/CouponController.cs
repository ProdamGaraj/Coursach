using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Infrastructure;
using Entities;

namespace WebCard.Controllers
{
    public class CouponController : Controller
    {
        private ICouponRepository _couponRepository { get; set; }
        // GET: HomeController
        public CouponController(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
        }
        public ActionResult Index()
        {
            return View(new List<Coupon>());
        }

        // GET: HomeController/Details/5
        public ActionResult Get(int id)
        {
            return View(_couponRepository.Get(id));
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Coupon coupon)
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
        [HttpGet("delete/{id}")]
    public ActionResult Delete(int id)
    {
        return View(_couponRepository.Get(id));
    }

    // POST: HomeController/Delete/5
    [HttpDelete("{id}")]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection, Coupon coupon)
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
