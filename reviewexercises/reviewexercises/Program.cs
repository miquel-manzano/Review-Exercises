using MyLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(MyMath.CalculateDiscount(UserInteraction.UserInputFloat(), UserInteraction.UserInputFloat()));
    }
}