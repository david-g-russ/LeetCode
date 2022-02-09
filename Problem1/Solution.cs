using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public static class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        int[] result = new int[2]{ i, j};
                        return result;
                    }
                }
        }
    }
}
