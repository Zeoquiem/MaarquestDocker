using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class PositionTypeService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public PositionTypeService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<PositionType>> GetAll()
        {
            List<PositionType> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<PositionType>>("PositionType/GetAll");

            return result;
        }

        public async Task<PositionType> Get(int positionTypeId)
        {
            PositionType result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<PositionType>($"PositionType/Get/{positionTypeId}");

            return result;
        }

        public async Task<PositionType> Add(PositionType positionType)
        {
            PositionType result = null;

            result = await _maarquestApiContext.HttpCreateAsync<PositionType>("PositionType/Add", positionType);

            return result;
        }

        public async Task<PositionType> Update(PositionType positionType)
        {
            PositionType result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<PositionType>("PositionType/Update", positionType);

            return result;
        }

        public async Task<int> Delete(int positionTypeid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"PositionType/Delete?id={positionTypeid}");

            return result;
        }
    }
}
