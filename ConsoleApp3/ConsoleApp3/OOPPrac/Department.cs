using System;
using System.Collections.Generic;

namespace ConsoleApp3.OOPPrac
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        private DateTime JoinDate { get; set; }
        public Instructor HeadDepartment { get; set; }
        private int YearOfExperience
        {
            get { return DateTime.Now.Year - JoinDate.Year; }

        }
        public decimal Budge { get; set; }
        
        public List<Course> CourseListDepart { get; set; }
        
    }
}