using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ConsoleApp3.OOPPrac
{
    public class Person
    {
        public int Id { get; set; }
        public string PersonName { get; set; }
        private double salary;

        public double Salary
        {
            get { return salary; }

            set
            {
                if (Salary < 0)
                {
                    throw new Exception("salary can only be positive");
                }

                salary = value;
            }
        }
        
        public DateTime DateOfBirth { get; set; }
        //private int ageDiff = DateTime.Now.Year - DateOfBirth.Year;
        public int Age
        {
            get {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }

        private List<string> AddressList = new List<string>();
        
        public void SetAddress(string address)
        {
            AddressList.Add(address);
        }
        
        public List<string> GetAddress()
        {
            
            return AddressList;
        }

        public void TesterGetAddress()
        {
            foreach (var address in AddressList)
            {
                Console.WriteLine(address);
            }
        }

    }
}