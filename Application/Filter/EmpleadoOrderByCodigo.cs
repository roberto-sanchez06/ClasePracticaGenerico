using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Empleados;

namespace AppCore.Filter
{
    public class EmpleadoOrderByCodigo : IComparer<Empleado>
    {
        public int Compare(Empleado x, Empleado y)
        {
            if (x.Codigo > y.Codigo)
            {
                return 1;
            }
            else if (y.Codigo>x.Codigo)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
