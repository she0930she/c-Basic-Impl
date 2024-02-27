using System;

namespace ConsoleApp3.OOPPrac
{
    public class Instructor: Person
    {
        
        public int DepartmentId { get; set; }
        public Department Department  { get; set; }

        
        private double bonus;
        
        
        
    }
}