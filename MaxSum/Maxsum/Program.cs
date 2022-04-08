using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxsum
{
    internal class Program
    {
        static int calculateMaxSumRateWithMaxSteps(List<int> arrList, int maxSteps)
        {
            long currmax = 0;
            currmax += arrList[0];
            long maxsum = 0;

            for (int i = 0; i < arrList.Count - maxSteps; i++)
            {
                for (int j = i + 1; j < i + maxSteps + 1; j++)
                {
                    maxsum = Math.Max(maxsum, currmax + arrList[j]);
                }
                currmax = maxsum;
            }

            return (int)currmax;
        }

        static int calculateMaxSumRateWithMaxStepzz(List<int> arrList, int maxSteps)
        {
            long currmax = 0;
            currmax += arrList[0];
            long maxsum = 0;

            for (int i = 0; i < arrList.Count - maxSteps; i++)
            {
                for (int j = i + 1; j < i + maxSteps + 1; j++)
                {
                    maxsum = Math.Max(maxsum, currmax + arrList[j]);
                }
                currmax = maxsum;
            }

            return (int)currmax;
        }

        static int calculateMaxSumRateWithMaxStepz(List<int> arrList, int maxSteps)
        {
            int n = arrList.Count;
            int[] maxSum = new int[n];
            SortedSet<int> tree = new SortedSet<int>();
            maxSum[n - 1] = arrList[n - 1];
            tree.Add(maxSum[n - 1]);
            
            for (int i = n - 2; i >= 0; i--)
            {
                maxfromIndex(arrList, n, maxSteps, i, ref maxSum, tree);
            }
            return maxSum[0];
        }

        static int maxfromIndex(List<int> arrList, int n, int maxSteps, int i, ref int[] maxSum, SortedSet<int> tree)
        {
            int max = tree.Max();
            if (i + maxSteps > n)
                max = Math.Max(max, 0);
            maxSum[i] = arrList[i] + max;
            tree.Add(maxSum[i]);
            if (i + maxSteps < n)
                tree.Remove(maxSum[i + maxSteps]);
            return maxSum[i];
        }

        static int calculateMaxSumRateWithMaxStep(List<int> arrList, int maxSteps)
        {
            int[] arr = arrList.ToArray();

            if (arr.Length == 0)
                return 0;

            if (arr.Length == 1)
                return arr[0];

            int firstSum = 0;
            int secondSum = 0;
            int outputSum = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0)
                {
                    if (count <= arr.Length)
                    {
                        firstSum = outputSum + arr[i + 1];
                        secondSum = outputSum + arr[i + maxSteps];
                        count += maxSteps;
                    }
                }
                else
                {
                    firstSum = arr[i] + arr[i + 1];
                    secondSum = arr[i] + arr[i + maxSteps];
                    count += maxSteps;
                }

                outputSum = Math.Max(firstSum, secondSum);
            }

            return outputSum;
        }

        static void Main(string[] args)
        {
            List<int> TestCase1 = new List<int>() { 10, 2, -10, 5, 20 };
            List<int> TestCase2 = new List<int>() { 10, -20, -5 };
            List<int> TestCase3 = new List<int>() { 100, -70, -90, -80, 100 };
            List<int> TestCase4 = new List<int>() { 3, -4, -3, -5, 0 };

            Console.WriteLine(calculateMaxSumRateWithMaxStepz(TestCase1, 2) + " 37");
            Console.WriteLine(calculateMaxSumRateWithMaxStepz(TestCase2, 2) + " 5");
            Console.WriteLine(calculateMaxSumRateWithMaxStepz(TestCase3, 3) + " 130");
            Console.WriteLine(calculateMaxSumRateWithMaxStepz(TestCase4, 2) + " 0");

            Console.ReadLine();
        }
    }
}