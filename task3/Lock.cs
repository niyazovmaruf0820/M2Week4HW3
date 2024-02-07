namespace task3;

public class Lock : IDevice
{
    public void TurnOff()
    {
        System.Console.WriteLine("The lock turned off");
    }

    public void TurnOn()
    {
        System.Console.WriteLine("The lock turned on");
    }

}
