using AutoMapper;
using USTest.BLL.Services.Base;
using USTest.BLL.Services.Interfaces;
using USTest.Common.Models.Domain;

namespace USTest.BLL.Services;

public class LocationService : BaseService, ILocationService
{
    private readonly IMapper _mapper;
    
    public LocationService(IMapper mapper, string baseAddress = "https://rickandmortyapi.com/api/location/")
        : base(mapper, baseAddress)
    {
        _mapper = mapper;
    }
    
    public async Task<Location> GetLocation(int id)
    {
        var response = await Get<Location>(id.ToString());

        return response;
    }
}