namespace StarWarsBlazorWASM.Models;

public class Movies
{
    public int Count { get; set; }
    public string Next { get; set; } = string.Empty;
    public string Previous { get; set; } = string.Empty;
    public List<Films> Results { get; set; } = new();
}
