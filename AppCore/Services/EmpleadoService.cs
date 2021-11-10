using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCore.Interfaces;
using Domain.Entities.Empleados;
using Domain.Enums;
using Domain.Interfaces;

namespace AppCore.Services
{
    public class EmpleadoService : BaseService<Empleado>,IEmpleadoService
    {
        private IEmpleadoRepository empleadoRepository;

        public EmpleadoService(IEmpleadoRepository empleadoRepository) : base (empleadoRepository)
        {
            this.empleadoRepository = empleadoRepository;
        }

        public Empleado GetEmpleadoById(int id)
        {
            return empleadoRepository.GetEmpleadoById(id);
        }

        public int Update(Empleado t, int i)
        {
            return empleadoRepository.Update(t,i);
        }


        public bool Delete(Empleado t)
        {
            return empleadoRepository.Delete(t);
        }

        public EmpleadoDgv GetResumenEmpleado(int id)
        {
            return empleadoRepository.GetResumenEmpleado(id);
        }

        public EmpleadoDgv[] GetResumenEmpleados()
        {
            return empleadoRepository.GetResumenEmpleados();
        }

        public bool Despedir(int id)
        {
            return empleadoRepository.Despedir(id);
        }
        public void QuitarDespedidos(Empleado empleado,int i)
        {
            empleadoRepository.QuitarDespedidos(empleado, i);
        }
        public void QuitarDespedidosDelMes()
        {
            empleadoRepository.QuitarDespedidosDelMes();
        }

        public ICollection<Empleado> FindAll(int tipo)
        {
            return empleadoRepository.FindAll(tipo);
        }

        public Empleado GetEmpleadoById(ICollection<Empleado> empleados, int id)
        {
            return empleadoRepository.GetEmpleadoById(empleados, id);
        }

        public void AumentarAntiguedad(Meses meses)
        {
            empleadoRepository.AumentarAntiguedad(meses);
        }
    }
}
