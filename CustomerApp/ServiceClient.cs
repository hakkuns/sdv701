using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace CustomerApp
{
    public static class ServiceClient
    {
        internal static async Task<string> InsertOrderAsync(clsOrder prOrder)
        {
            return await InsertOrUpdateAsync(prOrder, "http://localhost:60064/api/product/PostOrder", "POST");
        }

        internal async static Task<List<string>> GetPlaceNamesAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/product/GetPlaceNames/"));
        }

        internal async static Task<clsPlace> GetPlaceAsync(string prPlaceName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsPlace>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/product/GetPlace?PlaceName=" + prPlaceName));
        }

        internal async static Task<clsPlace> GetPlaceInstockAsync(string prPlaceName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsPlace>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/product/GetPlaceInstock?PlaceName=" + prPlaceName));
        }

        internal static async Task<string> UpdateProductAsync(clsAllProduct prProduct)
        {
            //throw new NotImplementedException();
            return await InsertOrUpdateAsync(prProduct, "http://localhost:60064/api/product/PutProduct", "PUT");
        }

        internal static async Task<string> InsertProductAsync(clsAllProduct prProduct)
        {
            return await InsertOrUpdateAsync(prProduct, "http://localhost:60064/api/product/PostProduct", "POST");
        }

        internal static async Task<string> InsertPlaceAsync(clsPlace prPlace)
        {
            //throw new NotImplementedException();
            return await InsertOrUpdateAsync(prPlace, "http://localhost:60064/api/product/PostPlace", "POST");
        }

        internal static async Task<string> UpdatePlaceAsync(clsPlace prPlace)
        {
            return await InsertOrUpdateAsync(prPlace, "http://localhost:60064/api/product/PutPlace", "PUT");
        }

        private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        {
            using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
            using (lcReqMessage.Content = new StringContent(JsonConvert.SerializeObject(prItem), Encoding.UTF8, "application/json"))
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }

        internal static async Task<string> DeleteProductAsync(clsAllProduct prProduct)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync($"http://localhost:60064/api/product/DeleteProduct?ProductName={prProduct.ProductName}&PlaceName={prProduct.PlaceName}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }

        internal static async Task<string> DeletePlace(string lcKey)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync($"http://localhost:60064/api/product/DeletePlace?PlaceName={lcKey}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
            
        }
    }
}
