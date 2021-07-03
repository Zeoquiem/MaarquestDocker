// Controllers/PositionTypeController.cs

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
    public class PositionTypeController
    {
        private readonly MaarquestContext _db;

        public PositionTypeController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.POSITION_TYPE.ToListAsync();

            List<PositionType> result = PositionTypeMapper.ConvertToPositionTypeList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.POSITION_TYPE.FirstOrDefaultAsync(n => n.POSITION_TYPE_ID == id);

            PositionType result = PositionTypeMapper.ConvertToPositionType(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(PositionType positionType)
        {
            POSITION_TYPE data = PositionTypeMapper.ConvertToPOSITION_TYPE(positionType);

            var res = _db.POSITION_TYPE.Add(data);
            await _db.SaveChangesAsync();

            PositionType result = PositionTypeMapper.ConvertToPositionType(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, PositionType positionType)
        {
            var existingPositionType = await _db.POSITION_TYPE.FirstOrDefaultAsync(n => n.POSITION_TYPE_ID == id);
            existingPositionType.LABEL = (positionType.Label != null) ? positionType.Label : existingPositionType.LABEL;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var positionType = await _db.POSITION_TYPE.FirstOrDefaultAsync(n => n.POSITION_TYPE_ID == id);
            _db.Remove(positionType);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
