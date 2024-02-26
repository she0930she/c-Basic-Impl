using System.Threading.Tasks;

namespace ConsoleApp3.Generics
{
    // make the whole class generic class
    // public static class GenericDemo <T> where T: struct
    
    // public static class GenericDemo <T> where T: class
    public static class GenericDemo <T> 
    {
        // Generic type
        // achieve type safety
        public static bool AreEqual(T a, T b)
        {
            return a.Equals(b);
        }
        
        // a feature that allows for the creation of reusable code by creating parameterized types
        // Object
        // public static bool AreEqual(object a, object b)
        // {
        //     return a.Equals(b);
        // }
        
        
        // public static bool AreEqual(int a, int b)
        // {
        //     return a.Equals(b);
        // }
        // public static bool AreEqual(double a, double b)
        // {
        //     return a.Equals(b);
        // }
        // public static bool AreEqual(string a, string b)
        // {
        //     return a.Equals(b);
        // }
        
    }
}