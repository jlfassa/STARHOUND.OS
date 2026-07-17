namespace STARHOUND.OS.Models;


public class Evidence
{

    public string Description { get; set; } = "";


    public string Category { get; set; } = "";


    public bool IsReliable { get; set; }



    public override string ToString()
    {
        return Description;
    }

}