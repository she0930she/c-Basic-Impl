using System;
using System.Collections.Generic;

namespace ConsoleApp3.OOPPrac
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        //private float Grade { get; set; }
        public List<Student> StudentList { get; set; }
        
        //public List<Student> StudentList = new List<Student>();
        
        // public void SetStudent(Student stu1)
        // {
        //     StudentList.Add(stu1);
        // }
        //
        // public List<Student> GetStudentList(string address)
        // {
        //     return StudentList;
        // }
        
        public void TesterGetStudentList()
        {
            foreach (var student in StudentList)
            {
                Console.WriteLine(student);
            }
        }
    }
}