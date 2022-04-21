namespace StarWarsBlazorWASM.Models;

public class SpeciesList
{
    public int Count { get; set; }
    public string Next { get; set; }
    public string Previous { get; set; }
    public List<Specie> Results { get; set; }
}
