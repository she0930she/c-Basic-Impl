using System;

namespace ConsoleApp3.ColorAndBall
{
    public class Ball
    {
        public int Size { get; set; }
        public Color Color { get; set; }
        public int ThrowCount { get; set; }

        public void MakeBallSizeZero()
        {
            Size = 0;
            Console.WriteLine("size: 0");
        }

        public int AddOneThrowCount()
        {
            if (Size == 0)
            {
                Console.WriteLine(" 0 in size");
                return -1;
            }

            ThrowCount += 1;
            Console.WriteLine(ThrowCount);
            return ThrowCount;

        }

    }
}