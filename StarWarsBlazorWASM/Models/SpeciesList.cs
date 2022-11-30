namespace StarWarsBlazorWASM.Models;

public class SpeciesList
{
    public int Count { get; set; }
    public string Next { get; set; } = string.Empty;
    public string Previous { get; set; } = string.Empty;
    public List<Specie> Results { get; set; } = new();
}
