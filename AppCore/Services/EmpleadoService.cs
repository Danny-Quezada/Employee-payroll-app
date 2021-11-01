using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCore.Interfaces;
using Domain.Entities.Empleados;
using Domain.Interfaces;

namespace AppCore.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private IEmpleadoRepository empleadoRepository;

        public EmpleadoService(IEmpleadoRepository empleadoRepository)
        {
            this.empleadoRepository = empleadoRepository;
        }

        public Empleado GetEmpleadoById(int id)
        {
            return empleadoRepository.GetEmpleadoById(id);
        }

        public void Create(Empleado t)
        {
            empleadoRepository.Create(t);
        }

        public int Update(Empleado t)
        {
            return empleadoRepository.Update(t);
        }

        public Empleado[] FindAll()
        {
            return empleadoRepository.FindAll();
        }

        public bool Delete(Empleado t)
        {
            return empleadoRepository.Delete(t);
        }

        public int GetLastId()
        {
            return empleadoRepository.GetLastId();
        }

        public EmpleadoDgv GetResumenEmpleado(int id)
        {
            return empleadoRepository.GetResumenEmpleado(id);
        }

        public EmpleadoDgv[] GetResumenEmpleados()
        {
            return empleadoRepository.GetResumenEmpleados();
        }

        public void Despedir(int id)
        {
            empleadoRepository.Despedir(id);
        }
        public void QuitarDespedidos(Empleado empleado)
        {
            empleadoRepository.QuitarDespedidos(empleado);
        }
    }
}
