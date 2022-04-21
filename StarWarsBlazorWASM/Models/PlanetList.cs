namespace StarWarsBlazorWASM.Models;

public class PlanetList
{
    public int Count { get; set; }
    public string Next { get; set; }
    public string Previous { get; set; }
    public List<Planet> Results { get; set; }
}
