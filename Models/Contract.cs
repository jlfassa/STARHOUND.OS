namespace STARHOUND.OS.Models;


public class Contract
{

    public string TargetName { get; set; } = "UNKNOWN";


    public int RewardCredits { get; set; }


    public int Difficulty { get; set; }


    public string LocationSector { get; set; } = "UNKNOWN";


    public int RiskLevel { get; set; }


    public bool IsCompleted { get; set; }


    public override string ToString()
    {
        return $"{TargetName} // Reward {RewardCredits} // Risk {RiskLevel}";
    }

}

