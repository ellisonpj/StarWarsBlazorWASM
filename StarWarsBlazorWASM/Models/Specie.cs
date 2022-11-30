namespace StarWarsBlazorWASM.Models;

public class Specie
{
    public string Name { get; set; } = string.Empty;
    public string Classification { get; set; } = string.Empty;
    public string Designation { get; set; } = string.Empty;
    public string Average_height { get; set; } = string.Empty;
    public string Skin_colors { get; set; } = string.Empty;
    public string Hair_colors { get; set; } = string.Empty;
    public string Eye_colors { get; set; } = string.Empty;
    public string Average_lifespan { get; set; } = string.Empty;
    public string Homeworld { get; set; } = string.Empty;
    public string Language { get; set; } = string.Empty;
    public List<string> People { get; set; } = new();
    public List<string> Films { get; set; } = new();
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
    public string Url { get; set; } = string.Empty;
}

