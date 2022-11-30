namespace StarWarsBlazorWASM.Models;

public class StarshipList
{
    public int Count { get; set; }
    public string Next { get; set; } = string.Empty;
    public string Previous { get; set; } = string.Empty;
    public List<Starship> Results { get; set; } = new();
}
