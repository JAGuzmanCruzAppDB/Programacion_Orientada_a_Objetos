using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_Propiedades_Get_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double sueldo=15000;
            double impuestode=16 ;
            Empleado op = new Empleado();
            op.Sueldo=sueldo;
            op.Mutator(impuestode);

            Console.WriteLine("El impuesto del empleado 10000A1 es {0}", op.Impuesto);

            op.Muestra();

            Console.ReadKey();
        }
    }
}
