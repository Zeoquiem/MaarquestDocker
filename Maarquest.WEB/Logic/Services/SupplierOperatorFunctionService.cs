using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class SupplierOperatorFunctionService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public SupplierOperatorFunctionService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<SupplierOperatorFunction>> GetAll()
        {
            List<SupplierOperatorFunction> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<SupplierOperatorFunction>>("SupplierOperatorFunction/GetAll");

            return result;
        }

        public async Task<SupplierOperatorFunction> Get(int supplierOperatorFunctionId)
        {
            SupplierOperatorFunction result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<SupplierOperatorFunction>($"SupplierOperatorFunction/Get/{supplierOperatorFunctionId}");

            return result;
        }

        public async Task<SupplierOperatorFunction> Add(SupplierOperatorFunction supplierOperatorFunction)
        {
            SupplierOperatorFunction result = null;

            result = await _maarquestApiContext.HttpCreateAsync<SupplierOperatorFunction>("SupplierOperatorFunction/Add", supplierOperatorFunction);

            return result;
        }

        public async Task<SupplierOperatorFunction> Update(SupplierOperatorFunction supplierOperatorFunction)
        {
            SupplierOperatorFunction result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<SupplierOperatorFunction>("SupplierOperatorFunction/Update", supplierOperatorFunction);

            return result;
        }

        public async Task<int> Delete(int supplierOperatorFunctionid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"SupplierOperatorFunction/Delete?id={supplierOperatorFunctionid}");

            return result;
        }
    }
}
