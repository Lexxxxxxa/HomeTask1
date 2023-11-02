using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    public class Task1
    {
        public static int Position(char inputChar)
        {                     
            int position = char.ToUpper(inputChar) - 'A' + 1;
            return position;
            
        }
        public static char Convert(char inputChar) 
        {
            char convertedChar = char.IsUpper(inputChar) ? char.ToLower(inputChar) : char.ToUpper(inputChar);
            return convertedChar;
        }
    }
}
