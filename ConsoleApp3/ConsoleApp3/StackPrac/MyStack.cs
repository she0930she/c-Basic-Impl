using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3.StackPrac
{
    public class MyStack<T>
    {
        private List<T> _arrList = new List<T>();

        public int Count()
        {
            return _arrList.Count;
        }

        public T Pop()
        {
            //T lastElement = null;
            if (_arrList.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int idx = _arrList.Count - 1;
            T lastElement = _arrList.Last();
            _arrList.RemoveAt(_arrList.Count-1);
            return lastElement;
        }

        public void Push(T newElement)
        {
            _arrList.Add(newElement);
        }

       

        


    }
}