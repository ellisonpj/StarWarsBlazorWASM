namespace StarWarsBlazorWASM.Models;

public class Planet
{
    public string Name { get; set; } = string.Empty;
    public string Rotation_period { get; set; } = string.Empty;
    public string Orbital_period { get; set; } = string.Empty;
    public string Diameter { get; set; } = string.Empty;
    public string Climate { get; set; } = string.Empty;
    public string Gravity { get; set; } = string.Empty;
    public string Terrain { get; set; } = string.Empty;
    public string Surface_water { get; set; } = string.Empty;
    public string Population { get; set; } = string.Empty;
    public List<string> Residents { get; set; } = new();
    public List<string> Films { get; set; } = new();
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
    public string Url { get; set; } = string.Empty;
}

