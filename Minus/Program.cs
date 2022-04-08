using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minus
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public int MissingEl(int[] arr)
        {
            int sum = 100 * (100 + 1) / 2;
            return sum - arr.Sum();
        }
    }
}