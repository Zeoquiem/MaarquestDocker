using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class AddressService 
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public AddressService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<Address>> GetAll()
        {
            List<Address> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<Address>>("Address/GetAll");

            return result;
        }

        public async Task<Address> Get(int addressId)
        {
            Address result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<Address>($"Address/Get/{addressId}");

            return result;
        }

        public async Task<Address> Add(Address address)
        {
            Address result = null;

            result = await _maarquestApiContext.HttpCreateAsync<Address>("Address/Add", address);

            return result;
        }

        public async Task<Address> Update(Address address)
        {
            Address result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<Address>("Address/Update", address);

            return result;
        }

        public async Task<int> Delete(int addressid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"Address/Delete?id={addressid}");

            return result;
        }

        public bool Verify(Address address)
        {
            bool result = false;

            if (address.City !=null && address.Country !=null && address.LignOne !=null && address.PostCode != null && address.Receiver != null)
            {
                result = true;
            }

            return result;
        }
    }
}
