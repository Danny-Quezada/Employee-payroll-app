using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Empleados;
using Domain.Enums;
using Domain.Interfaces;

namespace AppCore.Interfaces
{
    public interface IEmpleadoService : IService<Empleado>
    {
        Empleado GetEmpleadoById(int id);
        EmpleadoDgv GetResumenEmpleado(int id, int mes);
        EmpleadoDgv[] GetResumenEmpleados(int mes);
        bool Despedir(int id);
        void QuitarDespedidos(Empleado empleado,int i);
        int Update(Empleado t,int i);
        bool Delete(Empleado t);
        void QuitarDespedidosDelMes();
        ICollection<Empleado> FindAll(int tipo);
        Empleado GetEmpleadoById(ICollection<Empleado> empleados, int id);
        void AumentarAntiguedad(Meses meses);
    }
}
