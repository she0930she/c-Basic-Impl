using System;
using ConsoleApplication1.EnumPrac;
using ConsoleApplication1.ParametersImpl;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ParamPassing demo = new ParamPassing();
            // out Param
            string str;
            Console.WriteLine(demo.IsAuthentic("Anjila", "Antra123", out str));
            Console.WriteLine(str);
            // Console.WriteLine(demo.AddNumbers(20,30));
            // Console.WriteLine(demo.AddNumbers(20,30,30,40));

            //demo.AddTwoNumbers(1,2);
            //demo.AddThreeNumbers(1,2,3);
            
            
            DaysOfWeek today = DaysOfWeek.Tuesday;
            //Console.WriteLine(today);

            // boxing and unboxing
            int num = 123;
            object obj = num; // boxed num

            obj = 123;
            num = (int) obj; //unboxing


            // Console.WriteLine("hello world"); //cw tab
            // Console.WriteLine("try shortcut"); // command+ option+ /
        }
    }
}