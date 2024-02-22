using System;

namespace ConsoleApp1.FizzBuzzPrac
{
    public class FizzBuzz
    {
        private int Three = 3;
        private int Five = 5;
        
        public void printFizzBuzz(int num)
        {
            if (num % Three == 0 && num % Five == 0)
            {
                Console.WriteLine("FizzBuzz");
            }else if (num % Three == 0)
            {
                Console.WriteLine("Fizz");
            }else if (num % Five == 0)
            {
                Console.WriteLine("Buzz");
            }

        }
        
    }
}