using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "III";
            Console.WriteLine(RomanToInt(s));

            s = "LVIII";
            Console.WriteLine(RomanToInt(s));

            s = "MCMXCIV";
            Console.WriteLine(RomanToInt(s));
        }
        static int RomanToInt(string roman)
        {
                var endNum = 0;
                var romanCharsNum = new Dictionary<char, int>()
                {
                    { 'I', 1 },
                    { 'V', 5 },
                    { 'X', 10 },
                    { 'L', 50 },
                    { 'C', 100 },
                    { 'D', 500 },
                    { 'M', 1000 },
                };

                for (var i = 0; i < roman.Length - 1; i++)
                {
                    if (romanCharsNum[roman[i]] >= romanCharsNum[roman[i + 1]]) endNum += romanCharsNum[roman[i]];
                    else endNum -= romanCharsNum[roman[i]];
                }
                endNum += romanCharsNum[roman[roman.Length - 1]];

                return endNum;
            }
        }
    }
}