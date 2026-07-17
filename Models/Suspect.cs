namespace STARHOUND.OS.Models;


public class Suspect
{

    public string Name { get; set; } = "UNKNOWN";


    public string Alias { get; set; } = "UNKNOWN";


    public string Species { get; set; } = "Human";


    public string LastKnownLocation { get; set; } = "UNKNOWN";

    // Used by the deduction engine to eliminate suspects based on evidence.
    public string OriginSector { get; set; } = "";

    // Used by the deduction engine to track whether this suspect is still in play.
    public bool Eliminated { get; set; }

    // Traits used by contract generation / UI.
    public List<string> Traits { get; set; } = new();

    public int ThreatLevel { get; set; }



    public Dictionary<string,string> Profile { get; set; } = new();



    public bool IsGuilty { get; set; }



    public override string ToString()
    {
        return $"{Alias} // Threat {ThreatLevel}";
    }

}
