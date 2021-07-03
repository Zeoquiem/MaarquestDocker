using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class UserTypeMapper
    {
        public static UserType ConvertToUserType(USER_TYPE data)
        {
            UserType result = null;
            if (data != null)
            {
                result = new UserType()
                {
                    UserTypeId = data.USER_TYPE_ID,
                    Label = data.LABEL,
                };
            }
            return result;
        }
        public static USER_TYPE ConvertToUSER_TYPE(UserType data)
        {
            USER_TYPE result = null;
            if (data != null)
            {
                result = new USER_TYPE()
                {
                    USER_TYPE_ID = data.UserTypeId,
                    LABEL = data.Label,

                };
            }
            return result;
        }

        public static List<UserType> ConvertToUserTypeList(List<USER_TYPE> datas)
        {
            List<UserType> result = new List<UserType>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    UserType u = ConvertToUserType(data);
                    result.Add(u);
                }
            }
            return result;
        }

        public static List<USER_TYPE> ConvertToUSER_TYPEList(List<UserType> datas)
        {
            List<USER_TYPE> result = new List<USER_TYPE>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    USER_TYPE u = ConvertToUSER_TYPE(data);
                    result.Add(u);
                }
            }
            return result;
        }
    }
}
