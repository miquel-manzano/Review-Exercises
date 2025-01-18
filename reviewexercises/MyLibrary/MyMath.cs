namespace MyLibrary
{
    public class MyMath
    {
        public static string SecondsTo24Format(int userSeconds)
        {
            float hours = userSeconds / 3600;
            float minutes = (userSeconds % 3600) / 60;
            float seconds = userSeconds % 60;

            return $"{hours} horas {minutes} minuts {seconds} segons";
        }
    }
}
