using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using ModernHttpClient;
namespace XamarinFormsTest.Common
{
    public class GenericGet
    {
        public async Task<T> GetAsync<T>(string baseUrl, string param1 = null, string param2 = null, string param3=null)
        {
            var serviceUrl = baseUrl + (param1 != null ? "/" + param1 : string.Empty) + (param2 != null ? "/" + param2 : string.Empty) + (param3 != null ? "/" + param3 : string.Empty) ;

            var messageHandler = new NativeMessageHandler();
            messageHandler.ClientCertificateOptions = ClientCertificateOption.Automatic;
            using (var client = new HttpClient(messageHandler))
            {
                try
                {
                    var response = client.GetAsync(new Uri(serviceUrl)).Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new HttpRequestException(string.Format("Generic Get to url {0} faled with status code {1}", serviceUrl, response.StatusCode));
                    }
                    var data = await response.Content.ReadAsStringAsync();
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
