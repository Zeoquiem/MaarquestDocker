// Controllers/CreditCardController.cs

using Maarquest.API.Data;
using Maarquest.API.Mappers;
using Maarquest.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DockerSqlServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreditCardController
    {
        private readonly MaarquestContext _db;

        public CreditCardController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.CREDIT_CARD.ToListAsync();

            List<CreditCard> result = CreditCardMapper.ConvertToCreditCardList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.CREDIT_CARD.FirstOrDefaultAsync(n => n.CREDIT_CARD_ID == id);

            CreditCard result = CreditCardMapper.ConvertToCreditCard(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreditCard creditCard)
        {
            CREDIT_CARD data = CreditCardMapper.ConvertToCREDIT_CARD(creditCard);

            var res = _db.CREDIT_CARD.Add(data);
            await _db.SaveChangesAsync();

            CreditCard result = CreditCardMapper.ConvertToCreditCard(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, CreditCard creditCard)
        {
            var existingCreditCard = await _db.CREDIT_CARD.FirstOrDefaultAsync(n => n.CREDIT_CARD_ID == id);
            existingCreditCard.CARD_NUMBER = (creditCard.CardNumber != null) ? creditCard.CardNumber : existingCreditCard.CARD_NUMBER;
            existingCreditCard.CARD_NAME = (creditCard.CardName != null) ? creditCard.CardName : existingCreditCard.CARD_NAME;
            existingCreditCard.EXPIRY_DATE = (creditCard.ExpiryDate != null) ? creditCard.ExpiryDate : existingCreditCard.EXPIRY_DATE;
            existingCreditCard.SECURITY_CODE = (creditCard.SecurityCode < 0) ? creditCard.SecurityCode : existingCreditCard.SECURITY_CODE;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var creditCard = await _db.CREDIT_CARD.FirstOrDefaultAsync(n => n.CREDIT_CARD_ID == id);
            _db.Remove(creditCard);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
