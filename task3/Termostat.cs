namespace task3;

public class Termostat : IDevice
{
    public void TurnOff()
    {
        System.Console.WriteLine("The termostat turned off");
    }

    public void TurnOn()
    {
        System.Console.WriteLine("The termostat turned on");
    }

}
