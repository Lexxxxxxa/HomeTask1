namespace HomeTask2
{
    internal class Task3
    {
        private static readonly Random random = new Random();

        public static string GenrateRandomString(int length)
        {
            char[] randomArray = new char[length];

            for (int i = 0; i < length; i++)
            {
                randomArray[i] = Const.charsForTask3[random.Next(Const.charsForTask3.Length)];
            }

            return new string(randomArray);
        }
    }
}
