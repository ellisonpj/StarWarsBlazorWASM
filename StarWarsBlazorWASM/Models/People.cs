namespace StarWarsBlazorWASM.Models;

public class People
{
    public string Name { get; set; } = string.Empty;
    public string Height { get; set; } = string.Empty;
    public string Mass { get; set; } = string.Empty;
    public string Hair_color { get; set; } = string.Empty;
    public string Skin_color { get; set; } = string.Empty;
    public string Eye_color { get; set; } = string.Empty;
    public string Birth_year { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public string Homeworld { get; set; } = string.Empty;
    public List<string> Films { get; set; } = new();
    public List<string> Species { get; set; } = new();
    public List<string> Vehicles { get; set; } = new();
    public List<string> Starships { get; set; } = new();
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
    public string Url { get; set; } = string.Empty;
}
