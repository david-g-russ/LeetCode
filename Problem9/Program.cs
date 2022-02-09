using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 121;
            Console.WriteLine(Solution.IsPalindrome(x));

            x = 0;
            Console.WriteLine(Solution.IsPalindrome(x));

            x = 2147483647;
            Console.WriteLine(Solution.IsPalindrome(x));

            Console.ReadLine();
        }
    }
}
