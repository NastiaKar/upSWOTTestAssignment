using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using USTest.BLL.Extensions;
using USTest.BLL.Services.Interfaces;
using USTest.Common.Models.DTOs;

namespace USTest.WebAPI.Controllers.v1;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class PersonController : ControllerBase
{
    private readonly ICharacterService _charService;
    private readonly ILocationService _locationService;
    private readonly IEpisodeService _episodeService;
    private readonly IMapper _mapper;

    public PersonController(ICharacterService charService, ILocationService locationService, IMapper mapper,
        IEpisodeService episodeService)
    {
        _charService = charService;
        _locationService = locationService;
        _episodeService = episodeService;
        _mapper = mapper;
    }

    [HttpGet()]
    public async Task<IActionResult> GetCharacter([FromQuery] string name)
    {
        try
        {
            var characters = await _charService.GetCharacter(name);

            foreach (var character in characters)
            {
                var locationId = character.Location.Url.GetIdFromUrl();
                var location = await _locationService.GetLocation(locationId);
                character.Location = location;
            }

            return Ok(_mapper.Map<IEnumerable<CharacterDTO>>(characters));
        }
        catch (Exception)
        {
            return NotFound("Character not found.");
        }
    }

    [HttpPost("check-person")]
    public async Task<IActionResult> CheckCharacterEpisode([FromBody] CharacterEpisodeDTO dto)
    {
        try
        {
            var characters = await _charService.GetCharacter(dto.CharacterName);
            var episodes = await _episodeService.GetEpisode(dto.EpisodeName);

            var intersection = episodes
                .Select(e => e.Url)
                .Intersect(characters.SelectMany(c => c.Episode))
                .ToList();

            return Ok(intersection.Count != 0);
        }
        catch (Exception)
        {
            return NotFound("Episode or Character not found.");
        }
    }
}