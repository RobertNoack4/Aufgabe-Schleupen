using Aufgabe_WinForm.Model;
using Aufgabe_WinForm.Services.IServices;
using System.Net.Http.Json;

namespace Aufgabe_WinForm.Services
{
    internal class BaseService : IBaseService
    {
        private static readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7117/")
        };

        public async Task<T?> SendAsync<T>(ApiRequest request)
        {
            try
            {
                var client = _httpClient;
                var message = new HttpRequestMessage
                {
                    RequestUri = new Uri(request.Url, UriKind.Relative),
                    Method = GetHttpMethod(request.ApiType)
                };

                if(request.Data != null)
                {
                    message.Content = JsonContent.Create(request.Data);
                }

                var response = await client.SendAsync(message);

                return await response.Content.ReadFromJsonAsync<T>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return default;
            }
        }

        private static HttpMethod GetHttpMethod(ApiType.ApiTypeEnum apiType)
        {
            switch(apiType)
            {
                case ApiType.ApiTypeEnum.GET:
                    return HttpMethod.Get;
                case ApiType.ApiTypeEnum.POST:
                    return HttpMethod.Post;
                case ApiType.ApiTypeEnum.PUT:
                    return HttpMethod.Put;
                case ApiType.ApiTypeEnum.DELETE:
                    return HttpMethod.Delete;
                default:
                    return HttpMethod.Get;  
            }
        }
    }
}
