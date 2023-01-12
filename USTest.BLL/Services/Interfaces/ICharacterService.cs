﻿using USTest.BLL.Services.Base;
using USTest.Common.Models.DTOs;

namespace USTest.BLL.Services.Interfaces;

public interface ICharacterService
{
    Task<CharacterDTO> GetCharacter(string name);
}