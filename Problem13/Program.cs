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
        static int RomanToInt(string s)
        {
            int temp = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'M' && i == 0 || s[i] == 'M' && s[i - 1] != 'C')
                {
                    temp += 1000;
                }
                else if (s[i] == 'D' && i == 0 || s[i] == 'D' && s[i - 1] != 'C')
                {
                    temp += 500;
                }
                else if (s[i] == 'C' && i == 0 || s[i] == 'C' && s[i - 1] != 'X')
                {
                    temp += 100;
                }
                else if (s[i] == 'I')
                {
                    if (i == s.Length - 1 || s[i + 1] == 'I') temp += 1;
                    else if (s[i + 1] == 'V') temp += 4;
                    else if (s[i + 1] == 'X') temp += 9;
                }
                }
                }
            }
        }
    }
}