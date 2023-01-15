using AutoMapper;
using USTest.BLL.Extensions;
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
    
    public async Task<IEnumerable<Character>> GetCharacter(string name)
    {
        var splitName = name.ReplaceSpaceInString();
        var response = await Get<CharacterSearchResponse>($"?name={name}");
        if (response == null || !response.Results.Any())
            throw new Exception("Characters not found");

        return response.Results;
    }
}