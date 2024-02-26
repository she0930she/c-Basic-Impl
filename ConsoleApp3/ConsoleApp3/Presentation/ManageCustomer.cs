using System;
using System.Collections;
using System.Collections.Generic;
using ConsoleApp3.DataModel;
using ConsoleApp3.Repositories;

namespace ConsoleApp3.Presentation
{
    public class ManageCustomer
    {
        private CustomerRepository _customerRepository = new CustomerRepository();

        public void AddCustomer()
        {
            Customer c = new Customer();
            Console.WriteLine("Enter id: ");
            c.Id = Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine("Enter email: ");
            c.Email = Console.ReadLine() ;
            Console.WriteLine("Enter name: ");
            c.Name = Console.ReadLine();

            if (_customerRepository.Insert(c) == 1)
            {
                Console.WriteLine("Customer has been added successfully");
            }
            else
            {
                Console.WriteLine("error failed inserted");
            }
            
        }


        private Dictionary<int, string> dict = new Dictionary<int, string>();
    }
}