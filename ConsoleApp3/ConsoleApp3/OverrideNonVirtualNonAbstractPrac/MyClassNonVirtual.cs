using System;

namespace ConsoleApp3.OverrideNonVirtualNonAbstractPrac
{
    public class MyClassNonVirtual
    {
        // not extentiated by child
        public void PrintWords()
        {
            Console.WriteLine("in the base class");
        }

        // can be extentiated
        public virtual void PrintVirtualMethod()
        {
            Console.WriteLine("virtual base");
        }
    }
}