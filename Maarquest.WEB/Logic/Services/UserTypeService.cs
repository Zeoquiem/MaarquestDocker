using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class UserTypeService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public UserTypeService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<UserType>> GetAll()
        {
            List<UserType> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<UserType>>("UserType/GetAll");

            return result;
        }

        public async Task<UserType> Get(int userTypeId)
        {
            UserType result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<UserType>($"UserType/Get/{userTypeId}");

            return result;
        }

        public async Task<UserType> Add(UserType userType)
        {
            UserType result = null;

            result = await _maarquestApiContext.HttpCreateAsync<UserType>("UserType/Add", userType);

            return result;
        }

        public async Task<UserType> Update(UserType userType)
        {
            UserType result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<UserType>("UserType/Update", userType);

            return result;
        }

        public async Task<int> Delete(int userTypeid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"UserType/Delete?id={userTypeid}");

            return result;
        }
    }
}
