namespace StarWarsBlazorWASM.Models;

public class PlanetList
{
    public int Count { get; set; }
    public string Next { get; set; } = string.Empty;
    public string Previous { get; set; } = string.Empty;
    public List<Planet> Results { get; set; } = new();
}
