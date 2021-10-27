using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
    public interface IService<T>
    {
        void Create(T t);
        int Update(T t);
        T[] FindAll();
        bool Delete(T t);
        int GetLastId();
    }
}
