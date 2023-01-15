using USTest.Common.Models.Domain.Base;

namespace USTest.Common.Models.Domain;

public class Episode : BaseEntity
{
    public string Name { get; set; } = String.Empty;
    public string Url { get; set; } = String.Empty;
    public IEnumerable<string> Characters { get; set; } = null!;
}