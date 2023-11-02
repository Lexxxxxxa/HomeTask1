using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    internal class Task5
    {
        public static void ChangingValuesWithoutUsingThird(int x, int y) 
        {
            Console.WriteLine($"First value{x}, second value{y}");
            (y, x) = (x, y);
            /*  can be written in another form 
                x = x + y; 
                y = x - y;
                x = x - y;  */
            Console.WriteLine($"First value{x}, second value{y} after swap values");
        }
    }
}
