using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Infraestructure.Repository
{
    public abstract class BaseRepository<T> : IModel<T>
    {
        protected List<T> datos;
        protected BaseRepository()
        {
            datos = new List<T>();
        }
        public void Create(T t)
        {
            if (t == null)
            {
                throw new ArgumentException("El valor de lo que ingreso es nulo");
            }
            datos.Add(t);
        }

        public ICollection<T> FindAll()
        {
            return datos;
        }

        public virtual int GetLastId()
        {
            try
            {
                return datos.Count == 0 ? 0 : (int)datos[datos.Count - 1].GetType().GetProperty("Id").GetValue(datos[datos.Count - 1]);
            }
            catch (Exception)
            {
                throw new ArgumentException("El objeto no posee la propiedad Id");
            }
        }
    }
}
