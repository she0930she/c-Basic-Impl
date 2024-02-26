using System;
using ConsoleApp3.InternalPrac;

namespace EvaPrep
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PublicExample px = new PublicExample();
            //InternalExample inx = new InternalExample(); //Cannot access internal class 'InternalExample' here
        }
    }
}