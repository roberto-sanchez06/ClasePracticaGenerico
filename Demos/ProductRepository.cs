using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Inventories;

namespace Demos
{
    public class ProductRepository : IProductRepository
    {
        private ISet<Producto> productos;
        public ProductRepository()
        {
            productos = new HashSet<Producto>();
        }
        public void Create(Producto p)
        {
            productos.Add(p);
        }

        public bool Delete(Producto p)
        {
            return productos.Remove(p);
        }

        public ICollection<Producto> FindAll()
        {
            return this.productos;
        }

        public ICollection<Producto> FindAll(Predicate<Producto> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            return new List<Producto>(productos).FindAll(predicate);
        }

        public Producto FindAny(Predicate<Producto> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            return new List<Producto>(productos).Find(predicate);
        }

        public int Update(Producto p)
        {
            int index = new List<Producto>(productos).FindIndex(x=>x.Id==p.Id);
            if (index < 0)
            {
                throw new ArgumentException($"El producto con id {p.Id} no existe");
            }
            new List<Producto>(productos).Insert(index, p);
            return index;
        }
    }
}
