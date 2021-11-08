using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCore.Interfaces;
using Domain.Interfaces;

namespace AppCore.Services
{
    public abstract class BaseService<T> : IService<T>
    {
        private IModel<T> model;
        protected BaseService(IModel<T> model)
        {
            this.model = model;
        }
        public void Create(T t)
        {
            model.Create(t);
        }

        public ICollection<T> FindAll()
        {
            return model.FindAll();
        }

        public int GetLastId()
        {
            return model.GetLastId();
        }
    }
}
