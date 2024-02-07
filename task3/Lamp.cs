namespace task3;

public class Lamp : IDevice
{
    public void TurnOff()
    {
        System.Console.WriteLine("The lamp turned off");
    }

    public void TurnOn()
    {
        System.Console.WriteLine("The lamp turned on");
    }
}
