namespace MyLibrary
{
    public class MyMath
    {
        public static string DecimalToHex(int decimalNum)
        {
            char[] hexCharacters = { '0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F' };
            string resultHex = "";
            while (decimalNum > 0)
            {
                int remainder = decimalNum % 16;
                resultHex = hexCharacters[remainder] + resultHex;
                decimalNum = decimalNum / 16;
            }
            return resultHex;
        }
    }
}
