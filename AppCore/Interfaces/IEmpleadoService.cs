using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Empleados;
using Domain.Interfaces;

namespace AppCore.Interfaces
{
    public interface IEmpleadoService : IService<Empleado>
    {
        Empleado GetEmpleadoById(int id);
        EmpleadoDgv GetResumenEmpleado(int id);
        EmpleadoDgv[] GetResumenEmpleados();
        bool Despedir(int id);
        void QuitarDespedidos(Empleado empleado);
        int CalculoFactoy(EmpleadoDgv empleadoDgv);
        int Update(Empleado t);
        bool Delete(Empleado t);
        void QuitarDespedidosDelMes();
        ICollection<Empleado> FindAll(int tipo);
        Empleado GetEmpleadoById(ICollection<Empleado> empleados, int id);
        void AumentarAntiguedad();
    }
}
