using Newtonsoft.Json;

namespace USTest.BLL.Services.Base;

public abstract class BaseService
{
    private readonly HttpClient _client;

    protected BaseService(string baseAddress)
    {
        _client = new HttpClient
        {
            BaseAddress = new Uri(baseAddress)
        };
    }

    protected async Task<T?> Get<T>(string path)
    {
        var response = await _client.GetAsync(path);
        
        return response.IsSuccessStatusCode
            ? JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync())
            : default(T);
    }
}