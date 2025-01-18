using MyLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(MyLibrary.MyMath.TriangleArea(UserInteraction.UserInputFloat(), UserInteraction.UserInputFloat()));
    }
}