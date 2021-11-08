using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IModel<T>
    {
        void Create(T t);
        ICollection<T> FindAll();
        int GetLastId();
    }
}
