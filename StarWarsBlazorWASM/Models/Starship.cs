namespace StarWarsBlazorWASM.Models;

public class Starship
{
    public string Name { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Manufacturer { get; set; } = string.Empty;
    public string Cost_in_credits { get; set; } = string.Empty;
    public string Length { get; set; } = string.Empty;
    public string Max_atmosphering_speed { get; set; } = string.Empty;
    public string Crew { get; set; } = string.Empty;
    public string Passengers { get; set; } = string.Empty;
    public string Cargo_capacity { get; set; } = string.Empty;
    public string Consumables { get; set; } = string.Empty;
    public string Hyperdrive_rating { get; set; } = string.Empty;
    public string MGLT { get; set; } = string.Empty;
    public string Starship_class { get; set; } = string.Empty;
    public List<string> Pilots { get; set; } = new();
    public List<string> Films { get; set; } = new();
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
    public string Url { get; set; } = string.Empty;
}

