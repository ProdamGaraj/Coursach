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
    public class CardController : ControllerBase
    {
        private ICardRepository _cardRepository { get; set; }

        public CardController(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        [HttpGet]
        public ActionResult<Card> Get()
        {
            return _cardRepository.Get(1);
        }


        [HttpGet("{id}")]
        public Card Get(int id)
        {
            return _cardRepository.Get(id);
        }


        [HttpPost]
        public ActionResult Post([FromBody] Card card)
        {
            _cardRepository.Add(card);
            return Ok();
        }


        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Card coupon)
        {
            _cardRepository.Update(coupon);
            return Ok();
        }

    }
}