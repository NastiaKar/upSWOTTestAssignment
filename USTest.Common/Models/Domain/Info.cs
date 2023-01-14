namespace USTest.Common.Models.Domain;

public class Info
{
    public int Count { get; set; }
    public int Pages { get; set; }
    public string Next { get; set; } = String.Empty;
    public string Prev { get; set; } = String.Empty;
}