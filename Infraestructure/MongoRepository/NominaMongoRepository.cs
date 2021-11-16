using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Nominas;
using Domain.Interfaces;

namespace Infraestructure.MongoRepository
{
    public class NominaMongoRepository : MongoBaseRepository<Nomina>, INominaRepository
    {
        public NominaMongoRepository() : base("Nominas")
        {

        }
        public ICollection<Nomina> FindAll(Predicate<Nomina> predicate)
        {
            if (predicate is null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }
            List<Nomina> nominas = FindAll().ToList();
            return nominas.FindAll(predicate);
        }

        public Nomina FindAny(Predicate<Nomina> predicate)
        {
            if (predicate is null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            List<Nomina> nominas = FindAll().ToList();
            return nominas.Find(predicate);
        }
    }
}
