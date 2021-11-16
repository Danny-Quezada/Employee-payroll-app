using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using MongoDB.Driver;

namespace Infraestructure.MongoRepository
{
    public class MongoBaseRepository<T> : IModel<T>
    {
        protected IMongoDatabase db;
        protected IMongoCollection<T> collection;
        protected MongoBaseRepository(string nombreColeccion)
        {
            var cliente = new MongoClient();
            db = cliente.GetDatabase("BaseDeDatosNomina");
            collection = db.GetCollection<T>(nombreColeccion);
        }

        public void Create(T t)
        {
            collection.InsertOne(t);
        }

        public ICollection<T> FindAll()
        {
            return collection.Find(x => true).ToList();
        }

        public virtual int GetLastId()
        {
            var datos = FindAll().ToList();
            if (datos.Count == 0)
            {
                return 0;
            }
            else
            {
                try
                {
                    return (int)datos[datos.Count - 1].GetType().GetProperty("Id").GetValue(datos[datos.Count - 1]);
                }
                catch (Exception)
                {
                    throw new ArgumentException("El objeto no posee la propiedad Id");
                }
            }
        }
    }
}
