namespace StarWarsBlazorWASM.Models;

public class Films
{
    public string Title { get; set; } = string.Empty;
    public int Episode_id { get; set; }
    public string Opening_crawl { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public string Producer { get; set; } = string.Empty;
    public string Release_date { get; set; } = string.Empty;
    public List<string> Characters { get; set; } = new();
    public List<string> Planets { get; set; } = new();
    public List<string> Starships { get; set; } = new();
    public List<string> Vehicles { get; set; } = new();
    public List<string> Species { get; set; } = new();
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
    public string Url { get; set; } = string.Empty;
}

