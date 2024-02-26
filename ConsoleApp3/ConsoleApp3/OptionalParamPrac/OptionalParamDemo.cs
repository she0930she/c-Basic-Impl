using System;

namespace ConsoleApp3.OptionalParamPrac
{
    public class OptionalParamDemo
    {
        public void PrintRequireNOptional(string requiredParam, string optionalParam = "I am default")
        {
            // Method implementation
            Console.WriteLine($"Required parameter: {requiredParam}");
            Console.WriteLine($"Optional parameter: {optionalParam}");
        }
    }
}