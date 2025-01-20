namespace MyLibrary
{
    public class MyMath
    {
        public static float CalculateTipPercentage(int priceNum, int numPersons)
        {
            return (priceNum * 0.20f) / numPersons;
        }
    }
}
