using Domain.Entities.Inventories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demos
{
    public interface IProductRepository
    {
        void Create(Producto p);
        int Update(Producto p);
        bool Delete(Producto p);
        ICollection<Producto> FindAll();
        Producto FindAny(Predicate<Producto> predicate);
        ICollection<Producto> FindAll(Predicate<Producto> predicate);
    }
}
