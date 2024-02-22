using System;

namespace ConsoleApp1.GreetingPrac
{
    public class Greeting
    {
        public void GreetingWords(DateTime t)
        {
            Console.WriteLine($"hour: {t.Hour}");
            if (t.Hour >= 0 && t.Hour < 12)
            {
                Console.WriteLine("Good morning");
            }else if (t.Hour >= 12 && t.Hour < 18)
            {
                Console.WriteLine("good afternoon");
            }else if (t.Hour >= 18 && t.Hour < 22)
            {
                Console.WriteLine("good evening");
            }
            else
            {
                Console.WriteLine("good night");
            }
        }
    }
}