using Microsoft.AspNetCore.Mvc;
using USTest.BLL.Services.Interfaces;

namespace USTest.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CharacterLocationController : ControllerBase
{
    private readonly ICharacterService _charService;
    private readonly ILocationService _locationService;

    public CharacterLocationController(ICharacterService charService, ILocationService locationService)
    {
        _charService = charService;
        _locationService = locationService;
    }

    [HttpGet]
    public async Task<IActionResult> GetCharacter(string name)
    {
        return Ok(await _charService.GetCharacter(name));
    }
}