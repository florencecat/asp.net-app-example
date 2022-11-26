using System;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> GetList();
        T GetItem(Guid id);
        void CreateItem(T item);
        void UpdateItem(T item);
        void DeleteItem(Guid id);
    }
}
