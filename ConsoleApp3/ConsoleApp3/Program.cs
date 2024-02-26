using System;
using ConsoleApp3.ExtensionMethodPrac;
using ConsoleApp3.Generics;
using ConsoleApp3.InternalPrac;
using ConsoleApp3.OptionalParamPrac;
using ConsoleApp3.OverrideNonVirtualNonAbstractPrac;
using ConsoleApp3.PartialClassPrac;
using ConsoleApp3.Presentation;

namespace ConsoleApp3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
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
            Console.WriteLine(tuplePrac);
            Console.WriteLine(tuplePrac.GetType());
            
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