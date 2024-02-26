using System;
using ConsoleApp3.Generics;
using ConsoleApp3.InternalPrac;

namespace ConsoleApp3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // internal
            InternalExample inx = new InternalExample();
            inx.printInternal();
            
            // Generics
            // make the T <>right after the class, make it class type
            Console.WriteLine(GenericDemo<int>.AreEqual(3,4));
            Console.WriteLine(GenericDemo<double>.AreEqual(3.99,4.76));
            Console.WriteLine(GenericDemo<string>.AreEqual("gerg","abc"));
            
            
            // specify the T in <>
            // Console.WriteLine(GenericDemo.AreEqual<int>(3,4));
            // Console.WriteLine(GenericDemo.AreEqual<double>(3.99,4.76));
            // Console.WriteLine(GenericDemo.AreEqual<string>("gerg","abc"));
            
            // Console.WriteLine(GenericDemo.AreEqual(3,44.88));
            // Console.WriteLine(GenericDemo.AreEqual("efewf","kkkf"));
            // Console.WriteLine(GenericDemo.AreEqual(3,3));
        }
    }
}