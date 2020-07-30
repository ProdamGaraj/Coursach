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
    public class CardController : Controller
    {
        private ICardRepository _cardRepository { get; set; }

        public CardController(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }


        [HttpGet]
        public ActionResult Index()
        {
            return View(new List<Card>());
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return View(_cardRepository.Get(id));
        }

        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Card card)
        {
            try
            {
                _cardRepository.Add(card);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet("edit/{id}")]
        public ActionResult Edit(int id)
        {
            return View(_cardRepository.Get(id));
        }
        [HttpPost("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] Card card)
        {
            try
            {
                _cardRepository.Update(card);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpGet("remove/{id}")]
        public ActionResult Remove(int id)
        {
            return View(_cardRepository.Get(id));
        }

        [HttpPost("remove/{id}")]
        public ActionResult Remove(int id, [FromForm] Card card)
        {
            try
            {
                _cardRepository.Remove(card);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
