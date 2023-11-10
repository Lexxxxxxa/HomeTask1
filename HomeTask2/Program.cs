namespace HomeTask2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Chose task 1-6");

                if (int.TryParse(Console.ReadLine(), out int action))
                {
                    switch (action)
                    {
                        case 1:
                            Console.WriteLine("Write a sentence");
                            string strToTask1 = Console.ReadLine();
                            char[] charArrayString = strToTask1.ToCharArray();

                            charArrayString = Task1.Reverse(charArrayString);

                            strToTask1 = new string(charArrayString);
                            Console.WriteLine(strToTask1);
                            break;

                        case 2:
                            Console.WriteLine("Write a sentence ");
                            string strToTask2 = Console.ReadLine();

                            string splitResult =null;
                            if (strToTask2 == null)
                            {
                                Console.WriteLine("Empty value");
                            }
                            else
                            {
                                splitResult = Task2.FilteringOfInappropriateWords(strToTask2);
                            }

                            Console.WriteLine(splitResult);
                            break;

                        case 3:
                            Console.WriteLine("Enter number of characters");
                            int stringLength = int.Parse(Console.ReadLine());

                            string randomString = Task3.GenrateRandomString(stringLength);
                            Console.WriteLine($"Your random string is \n{randomString}");

                            string sortedString = new string(randomString.OrderBy(c => c).ToArray());
                            Console.WriteLine($"Your orderly string is \n{sortedString}");
                            break;

                        case 4:
                            Console.WriteLine("Enter array of numbers, separated by spaces");
                            string input = Console.ReadLine();

                            int[] arrForTask4 = Task4.CreatingArrayOfNumbers(input);
                            if (arrForTask4 == null)
                            {
                                Console.WriteLine("Conversion error. Enter the correct data.");
                                Console.ReadKey();
                                continue;
                            }

                            Console.WriteLine($"Missing number (hole) {Task4.HoleFinder(arrForTask4)}");
                            break;

                        case 5:
                            Console.WriteLine("Print DNA ");
                            string originalDna = Console.ReadLine();

                            if (originalDna == null)
                            {
                                Console.WriteLine("Conversion error. DNA can not be empty.");
                                Console.ReadKey();
                                continue;
                            }
                            else
                            {
                                string compressedDna = Task5.CompressDna(originalDna);
                                Console.WriteLine("Compressed DNA " + compressedDna);

                                string decompressedDna = Task5.DecompressDna(compressedDna);
                                Console.WriteLine("Decompressed DNA " + decompressedDna);
                            }

                            break;

                        case 6:
                            Console.WriteLine("Write text");
                            string inputText = Console.ReadLine();

                            Console.WriteLine("Secret key");
                            string key = Console.ReadLine();

                            Console.WriteLine($"Original Text {inputText}");

                            string encryptedText = Task6.Encrypt(inputText, key);
                            Console.WriteLine($"Encrypted Text {encryptedText}");

                            string decryptedText = Task6.Decrypt(encryptedText, key);
                            Console.WriteLine($"Decrypted Text {decryptedText}");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Select another valid number ");
                }

                Console.WriteLine("Do you want to continue? (y/n)");
                string answer = Console.ReadLine();
                if (answer.ToLower() != "y")
                {
                    break;
                }
            }
        }
    }
}