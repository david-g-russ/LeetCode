using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            Console.WriteLine(Solution.TwoSum(nums, target)[0] + " " + Solution.TwoSum(nums,target)[1]);

            nums = new int[] { 3, 2, 4};
            target = 6;
            Console.WriteLine(Solution.TwoSum(nums, target)[0] + " " + Solution.TwoSum(nums, target)[1]);

            nums = new int[] { 3, 3 };
            Console.WriteLine(Solution.TwoSum(nums, target)[0] + " " + Solution.TwoSum(nums, target)[1]);

            Console.ReadLine();

        }
    }
}
