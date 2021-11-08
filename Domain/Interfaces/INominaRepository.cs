using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Nominas;

namespace Domain.Interfaces
{
    public interface INominaRepository : IModel<Nomina>
    {
        Nomina FindAny(Predicate<Nomina> predicate);
        ICollection<Nomina> FindAll(Predicate<Nomina> predicate);
    }
}
