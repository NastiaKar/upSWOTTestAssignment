using AutoMapper;
using Newtonsoft.Json;

namespace USTest.BLL.Services.Base;

public abstract class BaseService
{
    private readonly HttpClient _client;
    private readonly IMapper _mapper;

    protected BaseService(IMapper mapper, string baseAddress)
    {
        _mapper = mapper;
        
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