namespace STARHOUND.OS.Core;


public class GameState
{

    public static GameState Instance { get; } = new();



    public string AgentName { get; set; } = "UNKNOWN AGENT";


    public int AgentLevel { get; set; } = 1;


    public int Experience { get; set; } = 0;



    public long Credits { get; set; } = 250000;



    public double Fuel { get; set; } = 85;



    public string CurrentSector { get; set; } = "SOL-01";



    public string CurrentSystem { get; set; } = "SOL";



    public int Reputation { get; set; } = 10;



    public List<string> KernelLogs { get; set; } = new()
    {

        "[BOOT] Carrier systems online",

        "[NAV] Galaxy database loaded",

        "[AI] Investigation engine ready"

    };



    public void AddCredits(long amount)
    {

        Credits += amount;

    }



    public void ConsumeFuel(double amount)
    {

        Fuel -= amount;


        if(Fuel < 0)

            Fuel = 0;

    }



    public void AddExperience(int amount)
    {

        Experience += amount;


        if(Experience >= AgentLevel * 1000)
        {

            AgentLevel++;

            Experience = 0;

            KernelLogs.Add(
                $"[RANK] Promoted to Agent Level {AgentLevel}"
            );

        }

    }

}