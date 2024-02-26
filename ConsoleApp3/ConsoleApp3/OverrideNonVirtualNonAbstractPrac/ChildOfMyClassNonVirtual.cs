using System;

namespace ConsoleApp3.OverrideNonVirtualNonAbstractPrac
{
    public class ChildOfMyClassNonVirtual: MyClassNonVirtual
    {
        // can be inherited from parent
        public override void PrintVirtualMethod()
        {
            base.PrintVirtualMethod();
            Console.WriteLine("in child override virtual");
        }
        
        
        public void PrintWords()
        {
            Console.WriteLine("in child PrintWords() method");
        }
    }
}