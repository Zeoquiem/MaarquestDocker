using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic
{
    public interface IMaarquestApiContext
    {

        Task<T> HttpGetItemAsync<T>(string urlApi);

        Task<T> HttpCreateAsync<T>(string urlApi, T item);

        Task<T> HttpUpdateAsync<T>(string urlApi, T item);

        Task<T> HttpUpdatePostAsync<T>(string urlApi, T item);

        Task<int> HttpSetValueAsync(string urlApi);

        Task<int> HttpDeleteAsync(string urlApi);
    }

}