using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinWeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test cases
            // 1, 2, 1 = 1
            // 2, 2, 3, 1 = 4
            // 100, [2-101] 1, 500 = 100

            List<int> TestCase1 = new List<int> { 30, 20, 25 };
            List<int> TestCase2 = new List<int> { 2 };
            List<int> TestCase3 = new List<int> { 2, 3 };
            List<int> TestCase4 = new List<int> { 15, 100, 35, 65, 20 };

            Console.WriteLine(findminWeight(TestCase1, 4) + ", 31");
            Console.WriteLine(findminWeight(TestCase2, 1) + ", 1");
            Console.WriteLine(findminWeight(TestCase3, 1) + ", 4");
            Console.WriteLine(findminWeight(TestCase4, 10) + ", 48");

            Console.ReadLine();
        }

        public static int findminWeight(List<int> weights, int d)
        {

            weights.Sort();
            int n = weights.Count-1;
            if (n == -1)
                return 0;
            if (n == 0)
            {
                while (d > 0)
                {
                    weights[0] /= 2;
                    d--;
                }
            }

            while (d > 0)
            {
                if (weights[n] > weights[n - 1])
                {
                    weights[n] = (int)Math.Ceiling((double)weights[n] / 2);
                }
                else
                {
                    for(int i = n-1; i >= 0; i--)
                    {
                        if (weights[n] > weights[i])
                        {
                            weights.Insert(i+1, weights[n]);
                            weights.RemoveAt(n+1);
                            break;
                        }
                        else if (i == 0)
                        {
                            weights.Insert(0, weights[n]);
                            weights.RemoveAt(n+1);
                            break;
                        }
                    }
                    weights[n] = (int)Math.Ceiling((double)weights[n] / 2);
                }
                d--;

            }
            return weights.Sum();
            weights.Max(out index);
        }
    }
}
