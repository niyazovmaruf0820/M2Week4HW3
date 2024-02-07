namespace task1;

public class Person
{
    private int age;  
    public void Greet()
    {
        System.Console.WriteLine("Hello!");
    }
    public void SetAge(int age)
    {
        this.age = age;
    }
    public int GetAge()
    {
        return age;
    }
}
