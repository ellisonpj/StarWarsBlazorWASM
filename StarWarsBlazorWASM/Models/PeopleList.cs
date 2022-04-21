namespace StarWarsBlazorWASM.Models;

public class PeopleList
{
    public int Count { get; set; }
    public string Next { get; set; }
    public string Previous { get; set; }
    public List<People> Results { get; set; }
}
