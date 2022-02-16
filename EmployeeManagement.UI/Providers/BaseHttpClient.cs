using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace EmployeeManagement.UI.Providers
{
    public abstract class BaseHttpClient
    {
        private readonly HttpClient _httpClient;

        public BaseHttpClient(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public T ExecuteGet<T>(string relativeUri)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, relativeUri))
            {

                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                using (var response = _httpClient.SendAsync(request).Result)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new WebException($"Failed to get data from external api:RequestUri:{request.RequestUri},StatusCode:{response.StatusCode}");
                    }
                    var responseData =  response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<T>(responseData, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                }
            }
        }
    }
}
