using System;

namespace HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine( "Chose task 1-5");
                int action = int.Parse( Console.ReadLine() );

                switch (action)
                {
                    case 1:
                        Console.WriteLine("Enter a letter from the English alphabet ");

                        char inputChar = Console.ReadKey().KeyChar;
                        int position = Task1.Position(inputChar);
                        Console.WriteLine($"\nPosition of the letter '{inputChar}' in the alphabet {position}");

                        char convertedChar = Task1.Convert(inputChar);
                        Console.WriteLine($"The letter in the other register {convertedChar}");
                        break;

                    case 2:
                        Console.WriteLine("Enter string ");
                        string inputString = Console.ReadLine();

                        Console.WriteLine("Enter a separator ");
                        char delimiter = Console.ReadKey().KeyChar;

                        string[] result = Task2.Split(inputString, delimiter);

                        Console.WriteLine("Result ");
                        foreach (string item in result)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter the main string ");
                        string mainString = Console.ReadLine();

                        Console.WriteLine("Enter the substring to search for ");
                        string substring = Console.ReadLine();

                        int totalCount = Task3.QuantifyOfSubstring(mainString, substring);
                    
                        if (totalCount == 0) 
                                Console.WriteLine($"Substring '{substring}' not found in the main string");
                        else 
                                Console.WriteLine($"Total occurrences {totalCount}");
                        break;
                    case 4:

                        Console.WriteLine("Enter a number up to 9999");
                        int number = int.Parse(Console.ReadLine());

                        string words = Task4.ConvertNumberToWords(number);
                        Console.WriteLine($"Number {number} in letters {words}");



                        break;
                    case 5:
                        Console.WriteLine("Write first value ");
                        int x = int.Parse(Console.ReadLine());

                        Console.WriteLine("Write second value ");
                        int y = int.Parse(Console.ReadLine());

                        Task5.ChangingValuesWithoutUsingThird(x, y);
                     
                            break;

                    default:
                        Console.WriteLine("Select another valid number ");
                        break;                        
                }
                Console.ReadKey();
            }
        }
    }
}