namespace USTest.Common.Models.Domain;

public class EpisodeSearchResponse
{
    public Info Info { get; set; } = null!;
    public IEnumerable<Episode> Results { get; set; } = null!;
}