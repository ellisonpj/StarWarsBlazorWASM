﻿namespace StarWarsBlazorWASM.Models;

public class VehicleList
{
    public int Count { get; set; }
    public string Next { get; set; }
    public string Previous { get; set; }
    public List<Vehicle> Results { get; set; }
}
