// Controllers/UserTypeController.cs

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
    public class UserTypeController
    {
        private readonly MaarquestContext _db;

        public UserTypeController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.USER_TYPE.ToListAsync();

            List<UserType> result = UserTypeMapper.ConvertToUserTypeList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.USER_TYPE.FirstOrDefaultAsync(n => n.USER_TYPE_ID == id);

            UserType result = UserTypeMapper.ConvertToUserType(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(UserType userType)
        {
            USER_TYPE data = UserTypeMapper.ConvertToUSER_TYPE(userType);

            var res = _db.USER_TYPE.Add(data);
            await _db.SaveChangesAsync();

            UserType result = UserTypeMapper.ConvertToUserType(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, UserType userType)
        {
            var existingUserType = await _db.USER_TYPE.FirstOrDefaultAsync(n => n.USER_TYPE_ID == id);
            existingUserType.LABEL = (userType.Label != null) ? userType.Label : existingUserType.LABEL;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var UserType = await _db.USER_TYPE.FirstOrDefaultAsync(n => n.USER_TYPE_ID == id);
            _db.Remove(UserType);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
