using SupplierModel = Maarquest.WEB.Logic.Models.Supplier;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class SupplierService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public SupplierService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<SupplierModel>> GetAll()
        {
            List<SupplierModel> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<SupplierModel>>("Supplier/GetAll");

            return result;
        }

        public async Task<SupplierModel> Get(int supplierId)
        {
            SupplierModel result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<SupplierModel>($"Supplier/Get/{supplierId}");

            return result;
        }

        public async Task<SupplierModel> Add(SupplierModel supplier)
        {
            SupplierModel result = null;

            result = await _maarquestApiContext.HttpCreateAsync<SupplierModel>("Supplier/Add", supplier);

            return result;
        }

        public async Task<SupplierModel> Update(SupplierModel supplier)
        {
            SupplierModel result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<SupplierModel>("Supplier/Update", supplier);

            return result;
        }

        public async Task<int> Delete(int supplierid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"Supplier/Delete?id={supplierid}");

            return result;
        }
    }
}
