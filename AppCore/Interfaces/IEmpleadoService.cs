using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Empleados;

namespace AppCore.Interfaces
{
    public interface IEmpleadoService : IService<Empleado>
    {
        Empleado GetEmpleadoById(int id);
        EmpleadoDgv GetResumenEmpleado(int id);
        EmpleadoDgv[] GetResumenEmpleados();
        void Despedir(int id);
        void QuitarDespedidos(Empleado empleado);
    }
}
