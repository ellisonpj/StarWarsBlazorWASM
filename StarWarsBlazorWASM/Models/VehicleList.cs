namespace StarWarsBlazorWASM.Models;

public class VehicleList
{
    public int Count { get; set; }
    public string Next { get; set; } = string.Empty;
    public string Previous { get; set; } = string.Empty;
    public List<Vehicle> Results { get; set; } = new();
}
