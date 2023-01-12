using AutoMapper;
using USTest.Common.Models.Domain;
using USTest.Common.Models.DTOs;

namespace USTest.BLL.Profiles;

public class OriginProfile : Profile
{
    public OriginProfile()
    {
        CreateMap<Origin, OriginDTO>().ReverseMap();
    }
}