namespace USTest.Common.Models.Domain;

public class CharacterSearchResponse
{
    public Info Info { get; set; } = null!;
    public IEnumerable<Character> Results { get; set; } = null!;
}