using System;

namespace ConsoleApp3.PartialClassPrac
{
    public partial class PartialClassDemo
    {
        public void printAPortion()
        {
            Console.WriteLine("part A");
        }
    }


    public partial class PartialClassDemo
    {
        public void printBPortion()
        {
            Console.WriteLine("part B");
        }
    }
}