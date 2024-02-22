using System;
using ConsoleApplication1.EnumPrac;
using ConsoleApplication1.ParametersImpl;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            // century conversion
            
            
            // Number sizes and ranges
            Console.WriteLine($"sbyte size:  {sizeof(sbyte)}, MinValue: {sbyte.MinValue}, MaxValue: {sbyte.MaxValue}");
            Console.WriteLine($"byte size:  {sizeof(byte)}, MinValue: {byte.MinValue}, MaxValue: {byte.MaxValue}");
            Console.WriteLine($"short size:  {sizeof(short)}, MinValue: {short.MinValue}, MaxValue: {short.MaxValue}");
            Console.WriteLine($"ushort size:  {sizeof(ushort)}, MinValue: {ushort.MinValue}, MaxValue: {short.MaxValue}");
            Console.WriteLine($"int size:  {sizeof(int)}, MinValue: {int.MinValue}, MaxValue: {int.MaxValue}");
            Console.WriteLine($"uint size:  {sizeof(uint)}, MinValue: {uint.MinValue}, MaxValue: {uint.MaxValue}");
            Console.WriteLine($"long size:  {sizeof(long)}, MinValue: {long.MinValue}, MaxValue: {long.MaxValue}");
            Console.WriteLine($"ulong size:  {sizeof(ulong)}, MinValue: {ulong.MinValue}, MaxValue: {ulong.MaxValue}");
            Console.WriteLine($"float size:  {sizeof(float)}, MinValue: {float.MinValue}, MaxValue: {float.MaxValue}");
            Console.WriteLine($"double size:  {sizeof(double)}, MinValue: {double.MinValue}, MaxValue: {double.MaxValue}");
            Console.WriteLine($"decimal size:  {sizeof(decimal)}, MinValue: {decimal.MinValue}, MaxValue: {decimal.MaxValue}");
            byte a = 255;
            //byte a = -1;
            char b = 'g';
            
            
            
            // ReadLine and WriteLine
            // string feeling; //declaring variable feeling           
            //
            // Console.WriteLine("Hey, how do you feel today?");            
            //
            // feeling = Console.ReadLine(); // takes the input from the user           
            //
            // Console.WriteLine("Hello there! I am feeling "+ feeling + "!"); // print the output 
            
            
            


            Console.WriteLine("********");
            ParamPassing demo = new ParamPassing();
            // out Param
            string str;
            // Console.WriteLine(demo.IsAuthentic("Anjila", "Antra123", out str));
            // Console.WriteLine(str);
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