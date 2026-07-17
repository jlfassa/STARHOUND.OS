using STARHOUND.OS.Models;


namespace STARHOUND.OS.Systems;


public sealed class ContractGenerator
{


    private static readonly string[] Names =
    {
        "Vex Arkon",
        "Lyra Nova",
        "Drax Vorn",
        "Cipher-09"
    };



    private static readonly string[] Sectors =
    {
        "NEXUS-7",
        "ORION",
        "VEGA",
        "KRYPTON"
    };




    public Suspect GenerateTarget()
    {

        return new Suspect
        {

            Name =
                Names[
                    Random.Shared.Next(
                        Names.Length)
                ],


            OriginSector =
                Sectors[
                    Random.Shared.Next(
                        Sectors.Length)
                ],


            Traits =
            {
                "Wanted",
                "Unknown"
            }

        };

    }


}