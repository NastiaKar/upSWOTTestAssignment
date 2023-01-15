namespace USTest.Common.Models.DTOs;

public class CharacterDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Status { get; set; } = String.Empty;
    public string Species { get; set; } = String.Empty;
    public string Type { get; set; } = String.Empty;
    public string Gender { get; set; } = String.Empty;
    public LocationDTO Origin { get; set; } = null!;
}