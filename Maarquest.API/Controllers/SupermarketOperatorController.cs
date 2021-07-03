// Controllers/SupermarketOperatorController.cs

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
    public class SupermarketOperatorController
    {
        private readonly MaarquestContext _db;

        public SupermarketOperatorController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.SUPERMARKET_OPERATOR.ToListAsync();

            List<SupermarketOperator> result = SupermarketOperatorMapper.ConvertToSupermarketOperatorList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.SUPERMARKET_OPERATOR.FirstOrDefaultAsync(n => n.SUPERMARKET_OPERATOR_ID == id);

            SupermarketOperator result = SupermarketOperatorMapper.ConvertToSupermarketOperator(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SupermarketOperator supermarketOperator)
        {
            SUPERMARKET_OPERATOR data = SupermarketOperatorMapper.ConvertToSUPERMARKET_OPERATOR(supermarketOperator);

            var res = _db.SUPERMARKET_OPERATOR.Add(data);
            await _db.SaveChangesAsync();

            SupermarketOperator result = SupermarketOperatorMapper.ConvertToSupermarketOperator(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, SupermarketOperator supermarketOperator)
        {
            var existingSupermarketOperator = await _db.SUPERMARKET_OPERATOR.FirstOrDefaultAsync(n => n.SUPERMARKET_OPERATOR_ID == id);
            existingSupermarketOperator.SUPERMARKET_ID = (supermarketOperator.SupermarketId != null) ? supermarketOperator.SupermarketId : existingSupermarketOperator.SUPERMARKET_ID;
            existingSupermarketOperator.SUPERMARKET_OPERATOR_FUNCTION_ID = (supermarketOperator.SupermarketOperatorFunctionId > 0) ? supermarketOperator.SupermarketOperatorFunctionId : existingSupermarketOperator.SUPERMARKET_OPERATOR_FUNCTION_ID;
            existingSupermarketOperator.FIRSTNAME= (supermarketOperator.Firstname != null) ? supermarketOperator.Firstname : existingSupermarketOperator.FIRSTNAME;
            existingSupermarketOperator.LASTNAME = (supermarketOperator.Lastname != null) ? supermarketOperator.Lastname : existingSupermarketOperator.LASTNAME;
            existingSupermarketOperator.USERNAME = (supermarketOperator.Username != null) ? supermarketOperator.Username : existingSupermarketOperator.USERNAME;
            existingSupermarketOperator.MAIL = (supermarketOperator.Mail != null) ? supermarketOperator.Mail : existingSupermarketOperator.MAIL;
            existingSupermarketOperator.PASSWORD = (supermarketOperator.Password != null) ? supermarketOperator.Password : existingSupermarketOperator.PASSWORD;
            existingSupermarketOperator.BIRTHDATE = (supermarketOperator.Birthdate != null) ? supermarketOperator.Birthdate : existingSupermarketOperator.BIRTDATE;
            existingSupermarketOperator.GENDER = (supermarketOperator.Gender != null) ? supermarketOperator.Gender : existingSupermarketOperator.GENDER;
            existingSupermarketOperator.TEL = (supermarketOperator.Tel != null) ? supermarketOperator.Tel : existingSupermarketOperator.TEL;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var supermarketOperator = await _db.SUPERMARKET_OPERATOR.FirstOrDefaultAsync(n => n.SUPERMARKET_OPERATOR_ID == id);
            _db.Remove(supermarketOperator);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
