using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class SupplierOperatorService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public SupplierOperatorService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<SupplierOperator>> GetAll()
        {
            List<SupplierOperator> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<SupplierOperator>>("SupplierOperator/GetAll");

            return result;
        }

        public async Task<SupplierOperator> Get(int supplierOperatorId)
        {
            SupplierOperator result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<SupplierOperator>($"SupplierOperator/Get/{supplierOperatorId}");

            return result;
        }

        public async Task<SupplierOperator> GetByLogIn(SupplierOperator supplierOperator)
        {
            SupplierOperator result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<SupplierOperator>($"SupplierOperator/GetByLogIn?username={supplierOperator.Username}&password={supplierOperator.Password}");

            return result;
        }

        public async Task<SupplierOperator> Add(SupplierOperator supplierOperator)
        {
            SupplierOperator result = null;

            result = await _maarquestApiContext.HttpCreateAsync<SupplierOperator>("SupplierOperator/Add", supplierOperator);

            return result;
        }

        public async Task<SupplierOperator> Update(SupplierOperator supplierOperator)
        {
            SupplierOperator result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<SupplierOperator>("SupplierOperator/Update", supplierOperator);

            return result;
        }

        public async Task<int> Delete(int supplierOperatorid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"SupplierOperator/Delete?id={supplierOperatorid}");

            return result;
        }
    }
}
