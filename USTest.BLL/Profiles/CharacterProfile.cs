using AutoMapper;
using USTest.Common.Models.Domain;
using USTest.Common.Models.DTOs;

namespace USTest.BLL.Profiles;

public class CharacterProfile : Profile
{
    public CharacterProfile()
    {
        var mapper = new Mapper(new MapperConfiguration(config =>
            config.AddProfile(new OriginProfile())));

        CreateMap<Character, CharacterDTO>()
            .ForMember(dest => dest.Origin,
            opt => opt.MapFrom(src => mapper.Map<OriginDTO>(src.Origin)));
    }
}