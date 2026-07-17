using STARHOUND.OS.Models;


namespace STARHOUND.OS.Systems;


public sealed class DeductionEngine
{

    private readonly List<Suspect> suspects = new();

    private readonly List<Evidence> evidence = new();



    public DeductionEngine()
    {

        suspects.AddRange(
        new[]
        {

            new Suspect
            {
                Name="Kara Voss",
                OriginSector="NEXUS-7",
                Traits =
                {
                    "Hacker",
                    "Smuggler"
                }
            },


            new Suspect
            {
                Name="Rax Helion",
                OriginSector="ORION",
                Traits =
                {
                    "Mercenary",
                    "Pilot"
                }
            },


            new Suspect
            {
                Name="Mira Kane",
                OriginSector="VEGA",
                Traits =
                {
                    "Trader",
                    "Spy"
                }
            }

        });

    }



    public void AddEvidence(Evidence clue)
    {
        evidence.Add(clue);

        Evaluate();
    }




    private void Evaluate()
    {
        foreach(var suspect in suspects)
        {
            foreach(var clue in evidence)
            {
                // Unreliable evidence should not drive deductions.
                if(!clue.IsReliable)
                    continue;

                // Only some evidence categories are allowed to affect this deduction rule.
                // For now, we treat empty category as compatible, and "Location" as compatible.
                if(!IsSectorEvidenceCategoryAllowed(clue.Category))
                    continue;

                if(clue.Description.Contains(
                    suspect.OriginSector,
                    StringComparison.OrdinalIgnoreCase))
                {
                    suspect.Eliminated = true;
                }
            }
        }
    }

    private static bool IsSectorEvidenceCategoryAllowed(string? category)
    {
        if(string.IsNullOrWhiteSpace(category))
            return true;

        return category.Equals("Location", StringComparison.OrdinalIgnoreCase);
    }





    public IEnumerable<Suspect> GetRemainingSuspects()
    {
        return suspects
            .Where(x=>!x.Eliminated);
    }



    public IEnumerable<Suspect> GetAllSuspects()
    {
        return suspects;
    }

}