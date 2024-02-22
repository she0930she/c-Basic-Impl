using System;

namespace ConsoleApp1.RandomNumberPrac
{
    public class RandomNumber
    {
        private int MaxVal = 3;
        private int MinVal = 0;
        
        public void GuessARandomNumber()
        {
            Console.WriteLine("make a guess:");
            int guessedNumber = int.Parse(Console.ReadLine());
            
            // check input value
            while (guessedNumber < MinVal || guessedNumber > MaxVal)
            {
                Console.WriteLine($"invalid input, try number between {MinVal} ~ {MaxVal}");
                guessedNumber = int.Parse(Console.ReadLine());
            }

            // valid input will continue
            Random rnd = new Random();
            int num = rnd.Next(MinVal, MaxVal+1);

            while (num != guessedNumber)
            {
                if (guessedNumber > num)
                {
                    Console.WriteLine("guess too high, try again");
                    guessedNumber = int.Parse(Console.ReadLine());
                }else if (guessedNumber < num)
                {
                    Console.WriteLine("guess too low, try again");
                    guessedNumber = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"You got it! {guessedNumber} is correct");

        }
    }
}