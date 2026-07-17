namespace STARHOUND.OS.Models;


public class Planet
{

    public string Name { get; set; } = "UNKNOWN";


    public string Biome { get; set; } = "Unknown";


    public string Atmosphere { get; set; } = "Unknown";


    public int Population { get; set; }


    public bool HasSettlement { get; set; }



    public List<Evidence> Evidence { get; set; } = new();



    public override string ToString()
    {
        return $"{Name} - {Biome}";
    }

}