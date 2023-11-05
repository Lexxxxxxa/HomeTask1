namespace HomeTask2
{
    internal class Task4
    {
        public static int HoleFinder(int[] arrForTask4, int actualSum = 0)
        {
            for (int i = 0; i < arrForTask4.Length; i++)
            {
                actualSum += arrForTask4[i];
            }

            return ((arrForTask4.Length * (arrForTask4.Length + 1) / 2) - actualSum); //expected - actual
        }

        public static int[]? CreatingArrayOfNumbers(string input)
        {
            string[] inputArray = input.Split(' ');

            int[] arrForTask4 = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (int.TryParse(inputArray[i], out int number))
                {
                    arrForTask4[i] = number;
                }
                else
                {
                    return null;
                }
            }

            return arrForTask4;
        }
    }
}