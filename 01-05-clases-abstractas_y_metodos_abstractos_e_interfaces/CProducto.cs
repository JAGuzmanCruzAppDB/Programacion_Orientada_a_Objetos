using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_05_clases_abstractas_y_metodos_abstractos_e_interfaces
{
    abstract class CProducto
    {
        protected string descripcion;
        protected double precioCompra;
        protected double precioVenta;

        public CProducto(string descripcion, double precioCompra)
        {
            this.descripcion = descripcion;
            this.precioCompra = precioCompra;
            precioVenta = 0.0;
        }
        public virtual void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio de producto");
            precioVenta = precioCompra * 1.3;
        }
        public abstract void MuestraVenta();
    }
}
