using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCore.Interfaces;
using Domain.Entities.Nominas;
using Domain.Interfaces;

namespace AppCore.Services
{
    public class NominaService : BaseService<Nomina>,INominaService
    {
        private INominaRepository nominaRepository;

        public NominaService(INominaRepository nominaRepository) : base (nominaRepository)
        {
            this.nominaRepository = nominaRepository;
        }

        public ICollection<Nomina> FindAll(Predicate<Nomina> predicate)
        {
            return nominaRepository.FindAll(predicate);
        }

        public Nomina FindAny(Predicate<Nomina> predicate)
        {
            return nominaRepository.FindAny(predicate);
        }
    }
}
