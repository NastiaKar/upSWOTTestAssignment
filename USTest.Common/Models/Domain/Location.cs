using USTest.Common.Models.Domain.Base;

namespace USTest.Common.Models.Domain;

public class Location : BaseEntity
{
    public string Name { get; set; } = String.Empty;
    public string Url { get; set; } = String.Empty;
    public string Dimension { get; set; } = String.Empty;
    public string Type { get; set; } = String.Empty;
}