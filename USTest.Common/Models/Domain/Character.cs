using USTest.Common.Models.Domain.Base;

namespace USTest.Common.Models.Domain;

public class Character : BaseEntity
{
    public string Name { get; set; } = String.Empty;
    public string Status { get; set; } = String.Empty;
    public string Species { get; set; } = String.Empty;
    public string Type { get; set; } = String.Empty;
    public string Gender { get; set; } = String.Empty;
    public Location Location { get; set; } = null!;
}