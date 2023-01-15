﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using USTest.BLL.Extensions;
using USTest.BLL.Services.Interfaces;
using USTest.Common.Models.DTOs;

namespace USTest.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CharacterLocationController : ControllerBase
{
    private readonly ICharacterService _charService;
    private readonly ILocationService _locationService;
    private readonly IMapper _mapper;

    public CharacterLocationController(ICharacterService charService, ILocationService locationService, IMapper mapper)
    {
        _charService = charService;
        _locationService = locationService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetCharacter(string name)
    {
        try
        {
            var characters = await _charService.GetCharacter(name);

            foreach (var character in characters)
            {
                var locationId = character.Location.Url.GetLocationId();
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
}