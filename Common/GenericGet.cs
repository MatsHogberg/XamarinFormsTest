using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using Xamarin.Forms;

namespace XamarinFormsTest.Common
{

    public class GenericGet
    {

        // Root URL.
        private const string rootUrl = "http://jsonplaceholder.typicode.com";

        // Actions.
        public enum Resource
        {
            posts,
            comments,
            todos,
            users
        };

        public async Task<T> GetAsync<T>(Resource resource, string param1 = null, string param2 = null, string param3 = null)
        {
            var serviceUrl = rootUrl + "/" + resource.ToString() + (param1 != null ? "/" + param1 : string.Empty) + (param2 != null ? "/" + param2 : string.Empty) + (param3 != null ? "/" + param3 : string.Empty) ;

            using (var client = new HttpClient())
            {
                try
                {
                    Debug.WriteLine(serviceUrl);
                    var response = client.GetAsync(new Uri(serviceUrl)).Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new HttpRequestException(string.Format("Generic Get to url {0} failed with status code {1}", serviceUrl, response.StatusCode));
                    }
                    var data = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine("Data: {0}", data);
                    return JsonConvert.DeserializeObject<T>(data);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(" *** > " + ex.Message);
                    return default(T);
                }
            }
        }
    }
}
