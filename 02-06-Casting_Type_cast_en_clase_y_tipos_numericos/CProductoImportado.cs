using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_06_Casting_Type_cast_en_clase_y_tipos_numericos
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
            Console.WriteLine("Calcula precion de importado");
            precioVenta = (precioCompra * (1 + impuesto)) * 1.30;
        }
        public override string ToString()
        {
            return string.Format("El gran producto {0} se vende en ${1}!!!!!!", descripcion, precioVenta);
        }
        public void Mensaje()
        {
            Console.WriteLine("Soy un producto importado");
        }
    }
}
