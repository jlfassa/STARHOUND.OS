namespace STARHOUND.OS.Models;


public class StarSystem
{

    public string Name { get; set; } = "UNKNOWN";


    public string Sector { get; set; } = "UNKNOWN";


    public int DangerLevel { get; set; }


    public List<Planet> Planets { get; set; } = new();



    public List<Contract> ActiveContracts { get; set; } = new();



    public bool HasBlackMarket { get; set; }



    public override string ToString()
    {
        return $"{Name} // Sector {Sector}";
    }

}