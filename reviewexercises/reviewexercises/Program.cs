using MyLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(MyMath.SecondsTo24Format(UserInteraction.UserIntputInt()));
    }
}