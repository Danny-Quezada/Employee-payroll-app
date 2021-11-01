using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Empleados;
namespace Domain.Interfaces
{
    public interface IEmpleadoRepository : IModel<Empleado>
    {
        Empleado GetEmpleadoById(int id);
        EmpleadoDgv GetResumenEmpleado(int id);
        EmpleadoDgv[] GetResumenEmpleados();
        void Despedir(int id);
        void QuitarDespedidos(Empleado empleado);
    }
}
