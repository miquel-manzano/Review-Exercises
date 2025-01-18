using MyLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(MyMath.CelsiusToKelvin(UserInteraction.UserInputFloat()));
    }
}