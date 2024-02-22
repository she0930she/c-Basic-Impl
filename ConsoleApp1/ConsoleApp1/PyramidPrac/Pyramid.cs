using System;

namespace ConsoleApp1.PyramidPrac
{
    public class Pyramid
    {
        public void BuildPyramid(int row)
        {
            string star = "*";
            for (int i = 0; i < row; i++)
            {
                for (int j = row - i; j > 1; j--)
                {
                    Console.Write(" ");
                }
                // for (int j = 0; j <= i; j++)
                // {
                    Console.Write(star);
                    star += "**";
                //}
                Console.WriteLine();
            }
        }
    }
}