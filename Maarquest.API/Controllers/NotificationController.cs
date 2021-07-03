// Controllers/NotificationController.cs

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
    public class NotificationController
    {
        private readonly MaarquestContext _db;

        public NotificationController(MaarquestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _db.NOTIFICATION.ToListAsync();

            List<Notification> result = NotificationMapper.ConvertToNotificationList(data);

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _db.NOTIFICATION.FirstOrDefaultAsync(n => n.NOTIFICATION_ID == id);

            Notification result = NotificationMapper.ConvertToNotification(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Notification notification)
        {
            NOTIFICATION data = NotificationMapper.ConvertToNOTIFICATION(notification);

            var res = _db.NOTIFICATION.Add(data);
            await _db.SaveChangesAsync();

            Notification result = NotificationMapper.ConvertToNotification(res.Entity);

            return new JsonResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Notification notification)
        {
            var existingNotification = await _db.NOTIFICATION.FirstOrDefaultAsync(n => n.NOTIFICATION_ID == id);
            existingNotification.USER_ID = (notification.UserId < 0) ? notification.UserId : existingNotification.USER_ID;
            existingNotification.USER_TYPE_ID = (notification.UserTypeId < 0) ? notification.UserTypeId : existingNotification.USER_TYPE_ID;
            existingNotification.LABEL = (notification.Label != null) ? notification.Label : existingNotification.LABEL;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var notification = await _db.NOTIFICATION.FirstOrDefaultAsync(n => n.NOTIFICATION_ID == id);
            _db.Remove(notification);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }
}
