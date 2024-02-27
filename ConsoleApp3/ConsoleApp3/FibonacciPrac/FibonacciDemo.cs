using System.Collections.Generic;

namespace ConsoleApp3.FibonacciPrac
{
    public class FibonacciDemo
    {
        private Dictionary<int, int> dictFib = new Dictionary<int, int>();

        public int Memorization(int num)
        {
            if (num <= 0) return -1;
            // base case
            if (num == 1 || num == 2) return 1;
            
            if (dictFib.ContainsKey(num)) return dictFib[num];

            dictFib[num] = Memorization(num - 1) + Memorization(num - 2);
            
            return dictFib[num];
        }

        public int PrintFib(int num)
        {
            if (num <= 0) return -1;
            // base case
            if (num == 1 || num == 2) return 1;
            
            return PrintFib(num - 1) + PrintFib(num - 2);
        }
    }
}