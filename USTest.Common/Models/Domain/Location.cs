using USTest.Common.Models.Domain.Base;

namespace USTest.Common.Models.Domain;

public class Location : BaseEntity
{
    private string Dimension { get; set; } = String.Empty;
    private string Type { get; set; } = String.Empty;
}