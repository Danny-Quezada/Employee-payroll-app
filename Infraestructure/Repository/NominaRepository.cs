using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Nominas;
using Domain.Interfaces;

namespace Infraestructure.Repository
{
    public class NominaRepository : BaseRepository<Nomina>, INominaRepository
    {
        public ICollection<Nomina> FindAll(Predicate<Nomina> predicate)
        {
            if (predicate is null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            return datos.FindAll(predicate);
        }

        public Nomina FindAny(Predicate<Nomina> predicate)
        {
            if (predicate is null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            return datos.Find(predicate);
        }
    }
}
