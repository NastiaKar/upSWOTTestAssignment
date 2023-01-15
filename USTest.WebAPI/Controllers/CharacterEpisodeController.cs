using Microsoft.AspNetCore.Mvc;
using USTest.BLL.Services.Interfaces;
using USTest.Common.Models.DTOs;

namespace USTest.WebAPI.Controllers;

[ApiController]
public class CharacterEpisodeController : ControllerBase
{
    private readonly ICharacterService _charService;
    private readonly IEpisodeService _episodeService;

    public CharacterEpisodeController(ICharacterService charService, IEpisodeService episodeService)
    {
        _charService = charService;
        _episodeService = episodeService;
    }

    [HttpPost("CheckEpisode")]
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