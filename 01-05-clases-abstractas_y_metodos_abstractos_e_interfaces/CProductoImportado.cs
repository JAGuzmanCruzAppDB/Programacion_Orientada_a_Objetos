using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_05_clases_abstractas_y_metodos_abstractos_e_interfaces
{
    class CProductoImportado:CProducto
    {
        protected double impuesto;

        public CProductoImportado(string descripcion, double precioCompra, double impuesto)
            : base(descripcion, precioCompra)
        {
            this.impuesto = impuesto;
        }
        public override void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio del importado");
            precioVenta = (precioCompra * (1 + impuesto)) * 1.30;
        }
        //si no se implementar el miembro abstracto de la clase padre marcara un error
        public override void MuestraVenta()
        {
            Console.WriteLine("El gran producto {0} se vende en ${1}!!!!!!!", descripcion, precioVenta);
        }
    }
}
