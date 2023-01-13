using AutoMapper;
using USTest.BLL.Services.Base;
using USTest.BLL.Services.Interfaces;
using USTest.Common.Models.Domain;
using USTest.Common.Models.DTOs;

namespace USTest.BLL.Services;

public class CharacterService : BaseService, ICharacterService
{
    private readonly IMapper _mapper;
    
    public CharacterService(IMapper mapper, string baseAddress = "https://rickandmortyapi.com/api/character/")
        : base(mapper, baseAddress)
    {
        _mapper = mapper;
    }
    
    public async Task<CharacterDTO> GetCharacter(string name)
    {
        var response = await Get<Character>($"?name={name}");
        if (response.Id == null)
            throw new Exception("Character not found");

        return _mapper.Map<CharacterDTO>(response);
    }
}