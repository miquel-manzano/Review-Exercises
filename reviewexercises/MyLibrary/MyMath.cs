namespace MyLibrary
{
    public class MyMath
    {
        public static bool CheckPostcode(int postcode)
        {
            return (CheckIsPositive(postcode)) && (CheckNumLength(postcode, 5));
        }

        public static bool CheckIsPositive(int num)
        {
            return num >= 0;
        }

        public static bool CheckNumLength(int num, int lenght)
        {
            return num.ToString().Length == lenght - 1; // menos uno porque el .Length empieza a contar desde 0.
        }
    }
}
