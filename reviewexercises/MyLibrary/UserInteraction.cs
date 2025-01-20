namespace MyLibrary
{
    public class UserInteraction
    {
        public static float UserInputFloat()
        {
            float userNum;
            try
            {
                userNum = float.Parse(Console.ReadLine());
            }
            catch
            {
                userNum = 0.0f;
            }
            return userNum;
        }
    }
}