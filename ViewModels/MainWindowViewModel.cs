using STARHOUND.OS.Core;


namespace STARHOUND.OS.ViewModels;


public class MainWindowViewModel
{

    public GameState State { get; }


    public string StatusText =>
        $"SECTOR: {State.CurrentSector}\n" +
        $"CREDITS: {State.Credits}\n" +
        $"FUEL: {State.Fuel}";



    public MainWindowViewModel()
    {
        State = new GameState();
    }

}