namespace StarWarsBlazorWASM.Models;

public class StarshipList
{
    public int Count { get; set; }
    public string Next { get; set; }
    public string Previous { get; set; }
    public List<Starship> Results { get; set; }
}
