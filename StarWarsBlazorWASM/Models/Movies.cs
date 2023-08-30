namespace StarWarsBlazorWASM.Models;

public class Movies
{
    public int Count { get; set; }
    public string Next { get; set; }
    public string Previous { get; set; }
    public List<Films> Results { get; set; }
}
