using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    public class Task2
    {
        public static string[] Split(string input, char delimiter)
        {
            List<string> res = new List<string>();
            string currentSubstring = "";

            foreach (char ch in input)
            {
                if (ch != delimiter)
                {
                    currentSubstring += ch;
                }
                else
                {
                    res.Add(currentSubstring);
                    currentSubstring = "";
                }
            }

            res.Add(currentSubstring);

            return res.ToArray();
        }
    }
}
