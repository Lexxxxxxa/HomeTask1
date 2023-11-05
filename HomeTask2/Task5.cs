using System.Text;

namespace HomeTask2
{
    internal class Task5
    {
        public static string  CompressDna(string dnaString)
        {
            StringBuilder compressedDna = new StringBuilder();
            int count = 1;

            for (int i = 1; i < dnaString.Length; i++)
            {
                if (dnaString[i] == dnaString[i - 1])
                {
                    count++;
                }
                else
                {
                    compressedDna.Append(dnaString[i - 1]);
                    compressedDna.Append(count);
                    count = 1;
                }
            }

            compressedDna.Append(dnaString[dnaString.Length - 1]);
            compressedDna.Append(count);

            return compressedDna.ToString();
        }

        public static string DecompressDna(string compressedDna)
        {
            StringBuilder decompressedDna = new StringBuilder();

            for (int i = 0; i < compressedDna.Length; i += 2)
            {
                char nucleotide = compressedDna[i];
                int count = int.Parse(compressedDna[i + 1].ToString());

                for (int j = 0; j < count; j++)
                {
                    decompressedDna.Append(nucleotide);
                }
            }

            return decompressedDna.ToString();
        }
    }
}