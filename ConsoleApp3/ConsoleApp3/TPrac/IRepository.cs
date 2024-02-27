using System.Collections;

namespace ConsoleApp3.TPrac
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        void Save();
        IEnumerable GetAll();
        T GetById(int id);
    }
}