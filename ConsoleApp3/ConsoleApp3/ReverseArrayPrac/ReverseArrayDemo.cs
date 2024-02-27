using System;

namespace ConsoleApp3.ReverseArrayPrac
{
    public class ReverseArrayDemo
    {
        // 3 methods: GenerateNumbers, Reverse, PrintNumbers
        public int[] GenerateNumbers(int length)
        {
            int[] ans = new int[length];

            for (int i = 0; i < length; i++)
            {
                ans[i] = i;
            }

            return ans;
        }

        public void PrintNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void Reverse(int[] arr)
        {
            if (arr == null || arr.Length == 0) return;

            int l = 0, r = arr.Length - 1;

            while (l < r)
            {
                int tmp = arr[l];
                arr[l] = arr[r];
                arr[r] = tmp;
                l++;
                r--;
            }
            
        }
    }
}