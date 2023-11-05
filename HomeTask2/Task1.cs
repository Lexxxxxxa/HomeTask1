namespace HomeTask2
{
    internal class Task1
    {
        public static char[] Reverse(char[] charArrayString)
        {
            for (int i = 0; i < charArrayString.Length / 2; i++)
            {
                char ch = charArrayString[i];
                charArrayString[i] = charArrayString[charArrayString.Length - 1 - i];
                charArrayString[charArrayString.Length - 1 - i] = ch;
            }

            return charArrayString;
        }
    }
}