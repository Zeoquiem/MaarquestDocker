using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class NotificationService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public NotificationService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<Notification>> GetAll()
        {
            List<Notification> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<Notification>>("Notification/GetAll");

            return result;
        }

        public async Task<Notification> Get(int notificationId)
        {
            Notification result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<Notification>($"Notification/Get/{notificationId}");

            return result;
        }

        public async Task<Notification> Add(Notification notification)
        {
            Notification result = null;

            result = await _maarquestApiContext.HttpCreateAsync<Notification>("Notification/Add", notification);

            return result;
        }

        public async Task<Notification> Update(Notification notification)
        {
            Notification result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<Notification>("Notification/Update", notification);

            return result;
        }

        public async Task<int> Delete(int notificationid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"Notification/Delete?id={notificationid}");

            return result;
        }
    }
}
