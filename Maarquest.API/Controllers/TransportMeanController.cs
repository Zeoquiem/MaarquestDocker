// Controllers/TransportMeanController.cs

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
    public class TransportMeanController
    {
        private readonly MaarquestContext _db;

        public TransportMeanController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.TRANSPORT_MEAN.ToListAsync();

            List<TransportMean> result = TransportMeanMapper.ConvertToTransportMeanList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.TRANSPORT_MEAN.FirstOrDefaultAsync(n => n.TRANSPORT_MEAN_ID == id);

            TransportMean result = TransportMeanMapper.ConvertToTransportMean(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(TransportMean transportMean)
        {
            TRANSPORT_MEAN data = TransportMeanMapper.ConvertToTRANSPORT_MEAN(transportMean);

            var res = _db.TRANSPORT_MEAN.Add(data);
            await _db.SaveChangesAsync();

            TransportMean result = TransportMeanMapper.ConvertToTransportMean(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, TransportMean transportMean)
        {
            var existingTransportMean = await _db.TRANSPORT_MEAN.FirstOrDefaultAsync(n => n.TRANSPORT_MEAN_ID == id);
            existingTransportMean.LABEL = (transportMean.Label != null) ? transportMean.Label : existingTransportMean.LABEL;
            existingTransportMean.CARBON_FOOTPRINT = (transportMean.CarbonFootprint > 0) ? transportMean.CarbonFootprint : existingTransportMean.CARBON_FOOTPRINT;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var transportMean = await _db.TRANSPORT_MEAN.FirstOrDefaultAsync(n => n.TRANSPORT_MEAN_ID == id);
            _db.Remove(transportMean);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
