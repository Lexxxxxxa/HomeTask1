using System.Text.RegularExpressions;

namespace HomeTask2
{
    internal class Task2
    {
        private static readonly string[] _exceptWords = { "fuck", "fucking", "ass" };

        public static string FilteringOfInappropriateWords(string strToTask2)
        {
            
            string[] splitResult = Regex.Split(strToTask2, @"(\s|,|\.|!|\?)");

            for (int i = 0; i < splitResult.Length; i++)
            {
                for (int j = 0; j < _exceptWords.Length; j++)
                {
                    if (string.Equals(splitResult[i], _exceptWords[j], StringComparison.OrdinalIgnoreCase))
                    {
                        splitResult[i] = "***";
                    }
                }
            }

            return string.Join("", splitResult);
        }
    }
}
