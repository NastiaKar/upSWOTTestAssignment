using AutoMapper;
using USTest.BLL.Extensions;
using USTest.BLL.Services.Base;
using USTest.BLL.Services.Interfaces;
using USTest.Common.Models.Domain;

namespace USTest.BLL.Services;

public class EpisodeService : BaseService, IEpisodeService
{
    private readonly IMapper _mapper;

    public EpisodeService(IMapper mapper, string baseAddress = "https://rickandmortyapi.com/api/episode/")
        : base(mapper, baseAddress)
    {
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<Episode>> GetEpisode(string name)
    {
        var response = await Get<EpisodeSearchResponse>($"?name={name}");

        return response.Results;
    }
}