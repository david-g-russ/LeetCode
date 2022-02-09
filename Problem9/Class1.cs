using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    public static class Solution
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            else if ((double)x/10 < 1)
            {
                return true;
            }
            else
            {
                int digits = (int)Math.Ceiling(((Math.Log10((double)x + 1))));
                int[] xarray = new int[digits];
                for (int i = 1; i <= digits; i++)
                {
                    double temp = x;
                    while (temp >= Math.Pow(10, i))
                    {
                        temp /= 10;
                    }
                    xarray[i - 1] = (int)(temp % 10);
                }
                for (int i = 0; i < xarray.Length / 2 + 1; i++)
                {
                    int j = xarray.Length - 1 - i;
                    if (xarray[i] == xarray[j])
                        continue;
                    else
                        return false;
                }
                return true;
            }
        }
    }
}