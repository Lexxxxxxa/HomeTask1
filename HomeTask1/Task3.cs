using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    internal class Task3
    {
        public static int QuantifyOfSubstring(string mainString, string substring) 
        {
            int index = 0;
            int count = 0;

            while ((index = mainString.IndexOf(substring, index)) != -1)
            {
                Console.WriteLine($"Substring '{substring}' found at index {index}");
                index += substring.Length;
                count++;
            }

            if (count == 0)
            {
                Console.WriteLine($"Substring '{substring}' not found in the main string.");
            }

            return count;
        }
    }
}
