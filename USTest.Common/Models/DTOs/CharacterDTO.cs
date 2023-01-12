namespace USTest.Common.Models.DTOs;

public class CharacterDTO
{
    public int Id { get; set; }
    public int Name { get; set; }
    public string Status { get; set; } = String.Empty;
    public string Species { get; set; } = String.Empty;
    public string Type { get; set; } = String.Empty;
    public string Gender { get; set; } = String.Empty;
    public OriginDTO Origin { get; set; } = null!;
}