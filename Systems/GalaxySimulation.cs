namespace STARHOUND.OS.Systems;


public sealed class GalaxySimulation
{

    private CancellationTokenSource? cancellation;


    public event Action<string>? OnGalaxyEvent;



    public bool Running { get; private set; }



    public async Task StartAsync()
    {

        if(Running)
            return;


        Running = true;

        cancellation = new CancellationTokenSource();


        while(!cancellation.Token.IsCancellationRequested)
        {

            await Task.Delay(
                TimeSpan.FromSeconds(5),
                cancellation.Token
            );


            GenerateEvent();

        }


    }




    private void GenerateEvent()
    {

        string[] events =
        {
            "BLACK MARKET PRICES UPDATED",
            "UNKNOWN SIGNAL DETECTED",
            "NEW BOUNTY CONTRACT GENERATED",
            "PIRATE ACTIVITY INCREASED",
            "SECTOR WAR ESCALATION",
            "ALIEN TRANSMISSION INTERCEPTED"
        };


        string galaxyEvent =
            events[
                Random.Shared.Next(events.Length)
            ];


        OnGalaxyEvent?.Invoke(
            galaxyEvent
        );

    }




    public void Stop()
    {

        cancellation?.Cancel();

        Running=false;

    }


}