namespace StarWarsBlazorWASM.Models;

public class PeopleList
{
    public int Count { get; set; }
    public string Next { get; set; } = string.Empty;
    public string Previous { get; set; } = string.Empty;
    public List<People> Results { get; set; } = new();
}
