using System;
using System.Collections.Generic;
using ConsoleApp3.ColorAndBall;
using ConsoleApp3.ExtensionMethodPrac;
using ConsoleApp3.FibonacciPrac;
using ConsoleApp3.Generics;
using ConsoleApp3.InternalPrac;
using ConsoleApp3.OOPPrac;
using ConsoleApp3.OptionalParamPrac;
using ConsoleApp3.OverrideNonVirtualNonAbstractPrac;
using ConsoleApp3.PartialClassPrac;
using ConsoleApp3.Presentation;
using ConsoleApp3.ReverseArrayPrac;

namespace ConsoleApp3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Color and Ball
            Color color10 = new Color(3, 100, 88);
            Color color11 = new Color(200, 10, 8);
            Console.WriteLine(color10.GetGrayScale());
            Ball b10 = new Ball();
            b10.Color = color10;
            b10.Size = 10;
            b10.AddOneThrowCount();
            b10.MakeBallSizeZero();
            Console.WriteLine(b10.Size);
            
            
            
            
            // OOP
            Person p10 = new Person();
            p10.Id = 3;
            p10.SetAddress("4488 skyline");
            p10.SetAddress("7746 Lonheed way");
            p10.GetAddress();
            p10.TesterGetAddress();
            Student s10 = new Student();
            Student s11 = new Student();
            s10.Id = 10;
            
            
            Course c10 = new Course();
            Course c11 = new Course();
            c10.Id = 10;
            c10.CourseName = "Chemistry";
            c11.Id = 11;
            c11.CourseName = "Math";
            s10.CourseList = new List<Course>();
            s10.CourseList.Add(c10);
            s10.CourseList.Add(c11);
            Console.WriteLine(s10.CourseList);
            s10.GetCourseList();

            
            
            // Dictionary
            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1[1] = "Jeff";
            dict1[3] = "Mary";
            // Console.WriteLine(dict1);
            // foreach (var item in dict1)
            // {
            //     Console.WriteLine(item.Key);
            //     Console.WriteLine(item.Value);
            // }
            // Console.WriteLine();
            
            // Fibonacci sequence
            FibonacciDemo fd = new FibonacciDemo();
            // Console.WriteLine(fd.PrintFib(2));
            // Console.WriteLine(fd.PrintFib(3));
            // Console.WriteLine(fd.PrintFib(8));
            // Console.WriteLine(fd.Memorization(3));
            
            
            //reverse array
            ReverseArrayDemo ra = new ReverseArrayDemo();
            int[] numbers = ra.GenerateNumbers(10);
            // ra.PrintNumbers(numbers);
            // ra.Reverse(numbers);
            // ra.PrintNumbers(numbers);
            
            
            //non-virtual
            ChildOfMyClassNonVirtual cnv = new ChildOfMyClassNonVirtual();
            // cnv.PrintWords();
            // cnv.PrintVirtualMethod();
            
            //optional param
            OptionalParamDemo op = new OptionalParamDemo();
            // op.PrintRequireNOptional("Mary");
            // op.PrintRequireNOptional("Mary", "Deon");
            
            
            // tuple
            var tuplePrac = (1, "John", false);
            //type seeTypeTuple = typeof(tuplePrac);
            int num10 = 10;
            // Console.WriteLine(tuplePrac);
            // Console.WriteLine(tuplePrac.GetType());
            
            // partial class
            PartialClassDemo pc = new PartialClassDemo();
            // pc.printAPortion();
            // pc.printBPortion();
            
            //Extension Method
            int numDemoExtension = 7;
            //Console.WriteLine("extension method: "+7.EvenOrOddMethod());

            string stringDemoExtensionMethod = "John";
            string stringNullDemoExtensionMethod = null;
            // Console.WriteLine(stringDemoExtensionMethod.HasValue());
            // Console.WriteLine(stringNullDemoExtensionMethod.HasValue());
            
            
            
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