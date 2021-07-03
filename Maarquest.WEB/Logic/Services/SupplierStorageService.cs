using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class SupplierStorageService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public SupplierStorageService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<SupplierStorage>> GetAll()
        {
            List<SupplierStorage> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<SupplierStorage>>("SupplierStorage/GetAll");

            return result;
        }

        public async Task<SupplierStorage> Get(int supplierStorageId)
        {
            SupplierStorage result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<SupplierStorage>($"SupplierStorage/Get/{supplierStorageId}");

            return result;
        }

        public async Task<SupplierStorage> Add(SupplierStorage supplierStorage)
        {
            SupplierStorage result = null;

            result = await _maarquestApiContext.HttpCreateAsync<SupplierStorage>("SupplierStorage/Add", supplierStorage);

            return result;
        }

        public async Task<SupplierStorage> Update(SupplierStorage supplierStorage)
        {
            SupplierStorage result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<SupplierStorage>("SupplierStorage/Update", supplierStorage);

            return result;
        }

        public async Task<int> Delete(int supplierStorageid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"SupplierStorage/Delete?id={supplierStorageid}");

            return result;
        }
    }
}
