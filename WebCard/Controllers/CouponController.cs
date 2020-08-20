using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entities;
using Infrastructure;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            // TODO: OPTIMIZE
            ViewBag.Cards = new SelectList(((CouponRepository)_couponRepository)._dbContext.Cards, "Id", "CardNumber");
            return View();
        }

        // POST: HomeController/Create
        [HttpPost("add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add([FromForm] Coupon coupon)
        {
            var forms = Request.Form;
            try
            {  // Sorry they(https://stackoverflow.com/questions/34624034/select-tag-helper-in-asp-net-core-mvc || https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.1 || https://habr.com/ru/post/276277/) told me this.
                var selectedIds = int.Parse(Request.Form["Card"][0]);
                var card = ((CouponRepository)_couponRepository)._dbContext.Cards.Find(selectedIds);
                coupon.Card = card;
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

        [HttpPost("remove/{id}")]
        public ActionResult Remove(int id, [FromForm] Coupon coupon)
        {
            try
            {
                _couponRepository.Remove(coupon);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}