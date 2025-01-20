namespace MyLibrary
{
    public class MyMath
    {
        public static float CalculateDiscount(float startingPrice, float discountedPrice)
        {
            return ((startingPrice - discountedPrice) / startingPrice) * 100;
        }
    }
}
