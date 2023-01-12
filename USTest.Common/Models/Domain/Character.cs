﻿using USTest.Common.Models.Domain.Base;

namespace USTest.Common.Models.Domain;

public class Character : BaseEntity
{
    public string Status { get; set; } = String.Empty;
    public string Species { get; set; } = String.Empty;
    public string Type { get; set; } = String.Empty;
    public string Gender { get; set; } = String.Empty;
    public Origin Origin { get; set; } = null!;
}