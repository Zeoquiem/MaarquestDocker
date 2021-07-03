using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class ReceiptProductTypeService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public ReceiptProductTypeService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<ReceiptProductType>> GetAll()
        {
            List<ReceiptProductType> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<ReceiptProductType>>("ReceiptProductType/GetAll");

            return result;
        }

        public async Task<List<ReceiptProductType>> GetAllFromReceipt(int receiptId)
        {
            List<ReceiptProductType> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<ReceiptProductType>>($"ReceiptProductType/GetAllFromReceipt/{receiptId}");

            return result;
        }

        public async Task<List<ReceiptProductType>> GetAllFromProductType(int productTypeId)
        {
            List<ReceiptProductType> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<ReceiptProductType>>($"ReceiptProductType/GetAllFromProduct/{productTypeId}");

            return result;
        }

        public async Task<ReceiptProductType> Get(int receiptId, int productTypeId)
        {
            ReceiptProductType result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<ReceiptProductType>($"ReceiptProductType/Get?receiptId={receiptId}&productTypeId={productTypeId}");

            return result;
        }

        public async Task<ReceiptProductType> Add(ReceiptProductType receiptProductType)
        {
            ReceiptProductType result = null;

            result = await _maarquestApiContext.HttpCreateAsync<ReceiptProductType>("ReceiptProductType/Add", receiptProductType);

            return result;
        }

        public async Task<ReceiptProductType> UpdateReceipt(ReceiptProductType receiptProductType, int newReceiptId)
        {
            ReceiptProductType result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<ReceiptProductType>($"ReceiptProductType/UpdateReceipt?newReceiptId={newReceiptId}", receiptProductType);

            return result;
        }

        public async Task<ReceiptProductType> UpdateProductType(ReceiptProductType receiptProductType, int newProductTypeId)
        {
            ReceiptProductType result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<ReceiptProductType>($"ReceiptProductType/UpdateProduct?newProductTypeId={newProductTypeId}", receiptProductType);

            return result;
        }

        public async Task<int> Delete(int receiptId, int productTypeId)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"ReceiptProductType/Delete?receiptId={receiptId}&productTypeId={productTypeId}");

            return result;
        }

        public async Task<int> DeleteAllFromReceipt(int receiptId)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"ReceiptProductType/DeleteAllFromReceipt?receiptId={receiptId}");

            return result;
        }

        public async Task<int> DeleteAllFromProductType(int productTypeId)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"ReceiptProductType/DeleteAllFromProduct?productTypeId={productTypeId}");

            return result;
        }
    }
}
