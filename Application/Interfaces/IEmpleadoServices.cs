using Domain.Entities.Empleados;

namespace AppCore.Interfaces
{
    public interface IEmpleadoServices : IService<Empleado>
    {
        Empleado FindById(int id);      
    }
}
