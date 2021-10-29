using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IService<T>
    {
        void Create(T t);
        int Update(T t);
        bool Delete(T t);
        T[] FindAll();
        int GetLastId();
        void Add(T t, ref T[] data);
        void OrdenarCualquierObj<T1>(T1[] data, IComparer<T1> comparer);
    }
}
