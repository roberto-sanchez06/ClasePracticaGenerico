using Domain.Entities.Empleados;
using Domain.Interfaces;
using Infraestructure.Inventories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Empleados
{
    public class EmpleadoModel : BaseRepository<Empleado> ,IEmpleadoModel
    {
        public Empleado FindById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException($"El Id: {id} no es valido.");
            }

            if (data == null)
            {
                throw new Exception("Empty data.");
            }

            Empleado empleado = null;
            foreach (Empleado i in data)
            {
                if (i.Id == id)
                {
                    empleado = i;
                    break;
                }
            }
            return empleado;
        }
    }
}
