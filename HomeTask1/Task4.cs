using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{

    internal class Task4
    {
        static string[] units = { "", "один", "два", "три", "чотири", "п'ять", "шість", "сім", "вісім", "дев'ять" };
        static string[] teens = { "десять", "одинадцять", "дванадцять", "тринадцять", "чотирнадцять", "п'ятнадцять", "шістнадцять", "сімнадцять", "вісімнадцять", "дев'ятнадцять" };
        static string[] tens = { "", "", "двадцять", "тридцять", "сорок", "п'ятдесят", "шістдесят", "сімдесят", "вісімдесят", "дев'яносто" };
        static string[] hundreds = { "", "сто", "двісті", "триста", "чотириста", "п'ятсот", "шістсот", "сімсот", "вісімсот", "дев'ятсот" };
        static string[] thousands = { "", "тисяча", "тисячи", "тисяч" };

        public static string ConvertNumberToWords(int number)
        {
            if (number == 0)
                return "нуль";

            string words = "";

            int thousandsDigit = number / 1000;
            int hundredsDigit = (number / 100) % 10;
            int tensDigit = (number / 10) % 10;
            int unitsDigit = number % 10;

            if (thousandsDigit >= 5)
                words += $"{units[thousandsDigit]} {thousands[3]} ";            
            else if (thousandsDigit >= 2)
                words += $"{units[thousandsDigit]} {thousands[2]} ";
            else if (thousandsDigit == 1)
                words += $"{units[thousandsDigit]} {thousands[1]} ";

            if (hundredsDigit > 0)
                words += hundreds[hundredsDigit];

            if (tensDigit > 0)
            {
                if (tensDigit == 1 && unitsDigit > 0)
                    words += teens[unitsDigit];

                else
                {
                    words += tens[tensDigit];

                    if (unitsDigit > 0)
                        words += " " + units[unitsDigit];
                }
            }
            else
            {
                if (unitsDigit > 0)                
                    words += units[unitsDigit];
            }

            return words.Trim();
        }
    }
}

