using System;
using System.Collections.Generic;

namespace ConsoleApp3.OOPPrac
{
    public class Student: Person
    {
        public List<Course> CourseList { get; set; }

        public void GetCourseList()
        {
            foreach (var course in CourseList)
            {
                Console.WriteLine(course.CourseName);
            }
        }
        
        //public List<Course> CourseList = new List<Course>();
        
        // private float gpa;
        // public float GPA
        // {
        //     get { return gpa;}
        //     set
        //     {
        //         gpa = value;
        //     }
        // }


    }
}