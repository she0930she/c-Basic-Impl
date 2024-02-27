using System;
using System.Collections.Generic;

namespace ConsoleApp3.TPrac
{
    public class MyList<T>
    {
        private List<T> _list = new List<T>();

        public void Add(T element)
        {
            _list.Add(element);
        }

        public T Remove(int index)
        {
            if (_list.Count == 0)
            {
                throw new Exception("not valid operation, list is empty");
            }
            
            T removeItem = _list[index];
            _list.RemoveAt(index);
            return removeItem;
            
        }
        
        public bool Contains(T element)
        {
            bool isContained = _list.Contains(element);
            return isContained;
        }
        
        public void Clear()
        {
            _list.Clear();
        }

        public void InsertAt(T element, int index)
        {
            _list.Insert(index, element);
        }
        
        public void DeleteAt(int index)
        {
            _list.RemoveAt(index);
        }
        
        public T Find(int index)
        {
            if (index < 0 || index > _list.Count - 1)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return _list[index];
        }
    }
}