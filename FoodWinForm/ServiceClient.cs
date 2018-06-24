using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace FoodWinForm
{
    public static class ServiceClient
    {

        internal async static Task<string> GetTotalPriceAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<string>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/product/GetTotalPrice/"));
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


        internal async static Task<List<clsOrder>> GetOrderAsync()
        //internal async static Task<clsOrder> GetOrderAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsOrder>>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/product/GetOrder"));
        }

        //internal static async Task<string> InsertOrderAsync(clsOrder prOrder)
        internal static async Task<string> InsertOrderAsync(clsAllProduct prProduct)
        {
            //throw new NotImplementedException();
            return await InsertOrUpdateAsync(prProduct, "http://localhost:60064/api/product/PostOrder", "POST");
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
            using (lcReqMessage.Content = new StringContent(JsonConvert.SerializeObject(prItem), Encoding.Default, "application/json"))
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

        internal static async Task<string> DeleteOrderAsync(clsOrder prOrder)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync($"http://localhost:60064/api/product/DeleteOrder?OrderID={prOrder.OrderId}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }
    }
}
