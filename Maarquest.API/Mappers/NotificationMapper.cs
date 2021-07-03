using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class NotificationMapper
    {
        public static Notification ConvertToNotification(NOTIFICATION data)
        {
            Notification result = null;
            if (data != null)
            {
                result = new Notification()
                {
                    NotificationId = data.NOTIFICATION_ID,
                    UserId = data.USER_ID,
                    UserTypeId = data.USER_TYPE_ID,
                    Label = data.LABEL
                };
            }
            return result;
        }
        public static NOTIFICATION ConvertToNOTIFICATION(Notification data)
        {
            NOTIFICATION result = null;
            if (data != null)
            {
                result = new NOTIFICATION()
                {
                    NOTIFICATION_ID = data.NotificationId,
                    USER_ID = data.UserId,
                    USER_TYPE_ID = data.UserTypeId,
                    LABEL = data.Label
                };
            }
            return result;
        }

        public static List<Notification> ConvertToNotificationList(List<NOTIFICATION> datas)
        {
            List<Notification> result = new List<Notification>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    Notification n = ConvertToNotification(data);
                    result.Add(n);
                }
            }
            return result;
        }

        public static List<NOTIFICATION> ConvertToDELIVERYList(List<Notification> datas)
        {
            List<NOTIFICATION> result = new List<NOTIFICATION>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    NOTIFICATION n = ConvertToNOTIFICATION(data);
                    result.Add(n);
                }
            }
            return result;
        }
    }
}
