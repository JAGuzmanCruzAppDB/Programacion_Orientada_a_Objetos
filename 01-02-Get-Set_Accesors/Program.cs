using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_Get_Set_Accesors
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado em = new Empleado();
            Console.WriteLine("El impuesto tomado en cuenta es de " + em.get_impuesto());
            em.set_sueldo(10500.50);

            em.muestra();

            Console.ReadKey();
        }
    }
}
